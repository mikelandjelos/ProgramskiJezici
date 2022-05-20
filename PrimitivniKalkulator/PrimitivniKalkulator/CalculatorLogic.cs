using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivniKalkulator
{
    internal class CalculatorLogic
    {

        private string expression;

        public CalculatorLogic(string _expression)
        {
            if (ExpressionValidator.Instance.Validate(_expression))
                throw new ArgumentException("Expression not valid!");
            expression = _expression;
        }

        public string Expression
        { 
            get { return expression; }
        }

        #region Precendence
        protected static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
        #endregion

        #region InfixtoPostfix_Conversion
        public string InfixToPostfix()
        {
            // initializing empty String for result 
            string result = "";

            // initializing empty stack 
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < expression.Length; ++i)
            {
                char c = expression[i];


                // If the scanned character is an operand, add it to output. 
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                else if (char.IsDigit(expression[i]))
                {
                    int operand = 0;
                    while (i < expression.Length && char.IsDigit(expression[i]))
                    {
                        operand = (operand * 10) + (expression[i] - '0');
                        i++;
                    }
                    i--;
                    result = result + operand.ToString() + " ";

                }
                else if (expression[i] == '.')
                {
                    result = result.Trim() + expression[i];
                }

                // If the scanned character is an '(', push it to the stack. 
                else if (c == '(')
                {
                    stack.Push(c);
                }

                // If the scanned character is an ')', pop and output from the stack 
                // until an '(' is encountered. 
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result = result + " " + stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        Console.WriteLine("Invalid Expression"); // invalid expression 
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else // an operator is encountered 
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result = result + " " + stack.Pop();
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack 
            while (stack.Count > 0)
            {
                result = result + " " + stack.Pop();
            }
            return result;
        }
        #endregion

        public static bool IsDigit(char c)
        {
            return (c >= 48 && c <= 57 || c == '.') ? true : false;
        }

        #region InfixtoPostfix_Evaluation
        public double CalculateExpression()
        {
            string postfix = InfixToPostfix();
            double result, op1, op2;
            Stack<double> stack = new Stack<double>();
            int len = (postfix.Length);
            for (int i = 0; i < len; i++)
            {
                string x = ""; double read_x = 0; char c = ' ';
                if (postfix[i] == ' ')
                    continue;
                #region multidigit_check
                //else if (char.IsDigit(postfix[i]))
                //{
                //int num = 0;

                //while (char.IsDigit(postfix[i]))
                //{
                //    num = num * 10 + (postfix[i] - '0');
                //    i++;
                //}
                //i--;
                //stack.Push(num);
                //}
                #endregion
                //If c is a number or decimal point
                else if (IsDigit(c = postfix[i]))
                {
                    x += c;
                    //The cycle reading includes a decimal point (for example, 8.88+7.777, here will be read in three times, the first cycle reads 8.88,
                    //the second time reads +, the third cycle reads 7.77)
                    while (i < len - 1 && IsDigit(c = postfix[++i]))
                        x += c;
                    read_x = float.Parse(x);
                    //Read the data into the data stack
                    stack.Push(read_x);
                }
                else
                {
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    switch (postfix[i])
                    {
                        case '+':
                            result = (double)(op2 + op1);
                            stack.Push(result);
                            break;
                        case '-':
                            result = (double)(op2 - op1);
                            stack.Push(result);
                            break;
                        case '*':
                            result = (double)(op2 * op1);
                            stack.Push(result);
                            break;
                        case '/':
                            result = (double)(op2 / op1);
                            stack.Push(result);
                            break;
                        case '^':
                            result = (double)(Math.Pow(op2, op1));
                            stack.Push(result);
                            break;
                    }
                }
            }
            result = (double)stack.Pop();
            return result;
        }
        #endregion

    }
}
