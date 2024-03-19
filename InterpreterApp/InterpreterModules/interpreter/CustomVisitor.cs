using System.Collections.Immutable;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using InterpreterModules;
using InterpreterModules.interpreter;

/// <summary>
/// Custom visitor for COBOL parse trees that extends the base visitor generated by ANTLR.
/// </summary>
public class CustomVisitor : cobolBaseVisitor<object> 
{
    private Dictionary<string, Value> _valueHashMap = new Dictionary<string, Value>();
    public override object VisitDisplay([NotNull] cobolParser.DisplayContext context)
    {
        int len = context.withnoadvancing() == null ? context.ChildCount : context.ChildCount - 1;
        for (int i = 1; i < len; i++)
        {
            string text = context.GetChild(i).GetText();
            if(char.IsLetter(text[0])){
                Value value;
                _valueHashMap.TryGetValue(text, out value);
                if (value == null)
                    throw new Exception("Incorrect variable name!");
                System.Console.WriteLine(value.Val + " ");
            }
            else{
                System.Console.WriteLine(text + " ");
            }
        }
        if (context.withnoadvancing == null){
            Console.WriteLine("\n");
        }
        return DefaultResult;
    }
    //Problem for now is that i dnot understand how to fill _valueHashMap. it is actuallu null
    //and when trying to get a value from _hashmap we get an object with a null reference
    public override object VisitAdd([NotNull] cobolParser.AddContext context)
    {
        string key;
        key = context.giving() == null ?
            context.identifiers().GetText() : context.giving().identifiers().GetText();

        Value value;
        _valueHashMap.TryGetValue(key, out value);
        if (value != null && !value.IsNumerical())
            throw new ValueIsNotNumericalException();

        int newValue;

        
        if (context.giving() != null)
        {
            newValue = int.Parse(context.@base.Text.Trim());
        }
        else
        {
            newValue = value.Val == null ? 0 : int.Parse(value.Val);
        }

        for(int i = 0; i < context._additions.Count; i++)
        {
            //Potential problems with Text property
            newValue += Int32.Parse(
                context._additions[i].Text.Trim()
                );
        }

        if (value == null){
            value = new Value(newValue.ToString());
        }
        else{
            value.AssignValue(newValue.ToString());
        }
        _valueHashMap[key] = value;

        return DefaultResult;
    }

    public override object VisitAccept([NotNull] cobolParser.AcceptContext context){
        for (int i = 0; i < context.identifiers().Count(); i++)
        {
            if (context.identifiers()[i] != null){
                Value oldValue;
                _valueHashMap.TryGetValue(context.identifiers()[i].GetText(), out oldValue);
                if (oldValue != null){
                    //TODO: Console.ReadLine is probably not the best solution
                    Value newValue = new Value(Console.ReadLine(), oldValue.Picture);
                    if (Value.CheckValueWithPicture(newValue.Val, oldValue.Picture)){
                        _valueHashMap[context.identifiers()[i].GetText()] = newValue;
                    }
                    else{
                        throw new Exception("Value does not correspond to the picture!");
                    }
                }
                else{
                    throw new Exception("The value of given variable was null!");
                }
            }
            else{
                throw new Exception("No variables provided!");
            }
        }

        return DefaultResult;
    }

    public override object VisitData_division([NotNull] cobolParser.Data_divisionContext context)
    {
        // No variables
        if (context.variables().Count() == 0){
            return base.VisitData_division(context);
        }

        String parent = "";
        int highestLevel = int.Parse(context.variables(0).level().GetText());
        var variablesContexts = context.variables();
        for (int i = 0; i < variablesContexts.Count(); i++)
        {
             if (int.Parse(variablesContexts[i].level().GetText()) == highestLevel)
             {
                 parent = variablesContexts[i].IDENTIFIER().GetText();
             }
             String picture = "";
             if (variablesContexts[i].picture() != null){
                 picture = variablesContexts[i].picture().REPRESENTATION().GetText();
             }
             else if (variablesContexts[i].like() != null){
                 Value likeValue;
                 _valueHashMap.TryGetValue(variablesContexts[i].like().identifiers().GetText(), out likeValue);
                 if (likeValue != null){
                     picture = likeValue.Picture;
                 }
                 else{
                     throw new Exception("Can not assign picture from a given variable");
                 }

             }
             else if (i+1 < variablesContexts.Count() && int.Parse(variablesContexts[i+1].level().GetText()) == highestLevel){
                 throw new Exception("Picture was expected but not given!");
             }
             else if (i+1 > variablesContexts.Count()){
                 throw new Exception("The variable was not properly defined. Use picture or like for definying!");
             }

             if (picture != ""){
                 String value = Value.MakeValueByPicture(picture);
                 if (variablesContexts[i].OCCURS() != null){
                     for (int j = 0; j < int.Parse(variablesContexts[i].OCCURS().GetText()); j++)
                     {
                         String variable = variablesContexts[i].IDENTIFIER().GetText();
                         variable += "[" + j + "]";
                         if (int.Parse(variablesContexts[i].level().GetText()) > highestLevel)
                             variable+="OF"+parent;
                         _valueHashMap.Add(variable, new Value(value, picture));
                     }
                 }
                 else{
                     String variable = variablesContexts[i].IDENTIFIER().GetText();
                     if (int.Parse(variablesContexts[i].level().GetText()) > highestLevel)
                         variable+="OF"+parent;
                     _valueHashMap.Add(variable, new Value(value, picture));
                 }
             }
        }
        return base.VisitData_division(context);
    }

    public override object VisitMultiply([NotNull] cobolParser.MultiplyContext context)
    {
        string key;
        Value valueObj;
        int newValue;

        if (context.giving() == null)
        {
            for(int i = 0; i < context.identifiers().Length; i++)
            {
                key = context.identifiers()[i].GetText();
                valueObj = _valueHashMap[key];
                if (!valueObj.IsNumerical())
                    return new ValueIsNotNumericalException();

                newValue = Convert.ToInt32(valueObj.Val);

                newValue *= Convert.ToInt32(context.multiplier.Text.Trim());
                valueObj.AssignValue(newValue.ToString());
                _valueHashMap[key] = valueObj;
            }
        }
        else
        {
            key = context.giving().identifiers().GetText();
            //valueObj = _valueHashMap[key];
            _valueHashMap.TryGetValue(key, out valueObj);
            if (valueObj != null && !valueObj.IsNumerical())
                throw new ValueIsNotNumericalException();
            newValue = Convert.ToInt32(context.@base.Text.Trim());
            newValue *= Convert.ToInt32(context.multiplier.Text.Trim());

            if (valueObj == null){
                valueObj = new Value(newValue.ToString());
            }
            else{
                valueObj.AssignValue(newValue.ToString());
            }
            _valueHashMap[key] = valueObj;
        }
        return DefaultResult;
    }

    public override object VisitSubtract(cobolParser.SubtractContext context)
    {
        String key;
        Value valueObj;
        int newValue;

        key = context.giving() != null ? 
            context.giving().identifiers().GetText() : context.identifiers().GetText();

        //valueObj = _valueHashMap[key];
        _valueHashMap.TryGetValue(key, out valueObj);
        if (valueObj!=null && !valueObj.IsNumerical())
            throw new ValueIsNotNumericalException();

        if (context.giving() != null)
        {
            newValue = Convert.ToInt32(context.@base.Text.Trim());
        }
        else
        {
            newValue = valueObj.Val == null ? 0 : Convert.ToInt32(valueObj.Val);
        }
        
        for (int i = 0; i < context._subtractors.Count; i++)
        {
            newValue -= Convert.ToInt32(context._subtractors[i].Text.Trim());
        }
        
        if (valueObj == null){
            valueObj = new Value(newValue.ToString());
        }
        else{
            valueObj.AssignValue(newValue.ToString());
        }
        _valueHashMap[key] = valueObj;
        
        return base.VisitSubtract(context);
    }

    public override object VisitDivide(cobolParser.DivideContext context)
    {
        String key;
        String remainderKey;
        Value valueObj;
        int newValue;
        int remainder;
        
        
        return base.VisitDivide(context);
    }
}