using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivniKalkulator
{
    internal class ExpressionValidator
    {

        public static ExpressionValidator instance;
        private static object syncRoot = new object();

        public ExpressionValidator() { }

        public static ExpressionValidator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ExpressionValidator();
                    }
                }

                return instance;

            }
        }

        public bool Validate(string expression)
        {
            int previous = 0;
            int previous1 = 0;
            string expEvaluated = string.Empty;
            int operatorOperand = 1;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == ')')
                {
                }
                else
                if (c == '(')
                {
                    int j = expression.IndexOf(')', i);
                    if (j == -1)
                        return false;

                    string substring = expression.Substring(i + 1, j - i - 1);

                    while (CharacterCount(substring, '(') != CharacterCount(substring, ')'))
                    {
                        if (j < expression.Length - 1)
                            j = expression.IndexOf(')', j + 1);
                        else
                            break;

                        substring = expression.Substring(i + 1, j - i - 1);
                    }

                    i = j - 1; //Changing the counter i to point to the next character
                    //validating the sub expression
                    if (Validate(substring) == true)
                    {
                        if (previous != 0 && previous1 != 0 && previous > previous1)
                        {
                            previous1 = operatorOperand;
                            operatorOperand++;
                            previous = 0;
                        }
                        else if (previous != 0 && previous1 != 0 && previous <= previous1)
                        {
                            return false;
                        }
                        else if (previous1 != 0)
                        {
                            return false;
                        }
                        else
                        {
                            previous1 = operatorOperand;
                            operatorOperand++;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    if (c == '+'
                   || c == '-'
                   || c == '*'
                   || c == '/')
                {
                    if (previous != 0)
                    {
                        return false;
                    }
                    previous = operatorOperand;
                    operatorOperand++;
                }
                else
                {
                    if (previous != 0 && previous1 != 0 && previous > previous1)
                    {
                        previous1 = operatorOperand;
                        operatorOperand++;
                        previous = 0;
                    }
                    else if (previous != 0 && previous1 != 0 && previous <= previous1)
                    {
                        return false;
                    }
                    else if (previous1 != 0)
                    {
                        return false;
                    }
                    else
                    {
                        previous1 = operatorOperand;
                        operatorOperand++;
                    }
                }
            }
            if (previous != 0)
                return false;
            return true;
        }

        private int CharacterCount(string expression, char _c)
        {
            int count = 0;
            foreach (char c in expression)
            {
                if (c == _c)
                    count++;
            }
            return count;
        }

        private bool IsValidChar(in char c)
        {
            switch (c)
            {
                case '(': case ')': case '0': case '1': case '2':
                case '3': case '4': case '5': case '6': case '7':
                case '8': case '9': case '+': case '-': case '/':
                case '*': case '=': return true;
                default: return false;
            }
        }

    }
}
