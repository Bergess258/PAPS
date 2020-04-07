using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    class Data
    {
        Dictionary<string, int> variables;
        public Data()
        {
            variables = new Dictionary<string, int>();
        }
        public int GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
    interface IMath
    {
        int Interpret(Data context);
    }
    class Number : IMath
    {
        string name;
        public Number(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Data context)
        {
            return context.GetVariable(name);
        }
    }
    class Addition : IMath
    {
        IMath leftExpression;
        IMath rightExpression;

        public Addition(IMath left, IMath right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Data context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
    class Substract : IMath
    {
        IMath leftExpression;
        IMath rightExpression;

        public Substract(IMath left, IMath right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Data context)
        {
            return leftExpression.Interpret(context) - rightExpression.Interpret(context);
        }
    }
}
