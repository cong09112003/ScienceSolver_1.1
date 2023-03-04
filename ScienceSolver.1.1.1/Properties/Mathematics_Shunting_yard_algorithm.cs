
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class ExprHelper
    {
        private const string UNARY_FUNCS = "ln|logb|loor|ceil|cbrt|exp|fabs|round|trunc|e|log|log3|log5|log4|log6|log7|log8|log9|log2|log10|sqrt|sin|cos|tan|cotg|abs|sinh|cosh|tanh|cotanh|asin|acos|atan|acotg|asinh|acosh|atanh|cotanh|";
        ~ExprHelper() { }
        public static string FormatExpression(string expression)
        {
            expression = expression.ToLower().Replace(" ","");
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^){38,}", match => match.Value[0].ToString());
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^)(\+|\*|\/|\%|\^)", match => match.Value[0].ToString());
            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\^|\)|\(", match => String.Format(" {0} ", match.Value));
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
            return expression;
        }

        public static int GetPriority(string op)
        {
            if (UNARY_FUNCS.IndexOf(op, StringComparison.OrdinalIgnoreCase) >= 0)
                return 4;
            if (op == "*" || op == "/" || op == "%" || op == "^")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        public static bool Factorial(string str)
        {
            return (str[0] >= '0' && str[0] <= '9' && str[1] == '!');
        }
        public static bool IsOperator(string str)
        {
            return Regex.Match(str, @"^(\+|\-|\*|\/|\%|\^|" + UNARY_FUNCS + ")$").Success;
        }
        public static bool IsUnaryFunction(string str)
        {
            return Regex.Match(str, @"^(" + UNARY_FUNCS + ")$").Success;
        }
        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
    }
    public class Y2Expression
    {
        private string infix;
        private string posfix;
        private string value;
        ~Y2Expression()
        { }
        public string Infix
        {
            get { return this.infix; }
            set { this.infix = value; }
        }
        public Y2Expression(string infix)
        {
            this.Infix = infix;
        }
        public Y2Expression()
        {
            this.Infix = "";
            this.posfix = "";
            value = "";
        }
        public void input(string infix)
        {
            this.Infix = infix;
        }
        public void run()
        {
            this.posfix = Y2Expression.Infix2Postfix(this.Infix);
            this.value = Y2Expression.EvaluatePostfix(this.posfix);
        }
        public static string Infix2Prefix(string infix)
        {

            infix = ExprHelper.FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            tokens = ProcessConvert(tokens).Split(' ').Reverse().ToArray();

            StringBuilder result = new StringBuilder();

            Array.ForEach(tokens, s => result.Append(s).Append(" "));
            return result.ToString();

        }

        public static string Infix2Postfix(string infix)
        {
            infix = ExprHelper.FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            return ProcessConvert(tokens);
        }

        private static string ProcessConvert(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (ExprHelper.IsOperator(token))
                {
                    if ((i == 0) || (i > 0 && (ExprHelper.IsOperator(tokens[i - 1]) || tokens[i - 1] == "(")))
                    {
                        if (token == "-")
                        {
                            result.Append(token + tokens[i + 1]).Append(" ");
                            i++;
                        }
                        else if (ExprHelper.IsUnaryFunction(token))
                        {
                            stack.Push(token);
                        }
                    }
                    else
                    {
                        while (stack.Count > 0 && ExprHelper.GetPriority(token) <= ExprHelper.GetPriority(stack.Peek()))
                            result.Append(stack.Pop()).Append(" ");
                        stack.Push(token);
                    }
                }

                else if (token == "(")
                    stack.Push(token);
                else if (token == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        result.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// (IsOperand(s))
                {
                    result.Append(token).Append(" ");
                }
            }

            while (stack.Count > 0)
                result.Append(stack.Pop()).Append(" ");

            return result.ToString();
        }

        #region Evaluate

        public static string EvaluatePrefix(string prefix)
        {
            return EvaluatePostfix(prefix.Trim().Split(' ').Reverse());
        }

        public static string EvaluatePostfix(string postfix)
        {
            return EvaluatePostfix(postfix.Trim().Split(' '));
        }

        private static string EvaluatePostfix(IEnumerable<string> tokens)
        {
            string res = "";
            try
            {
                Stack<double> stack = new Stack<double>();

                foreach (string s in tokens)
                {
                    if (ExprHelper.IsOperator(s))
                    {
                        double x = stack.Pop();
                        if (ExprHelper.IsUnaryFunction(s))
                        {
                            switch (s)
                            {
                                case "logb":
                                    x = Math.ILogB(x);
                                    break;
                                case "ln":
                                    x = Math.Log(x);
                                    break;
                                case "floor":
                                    x = Math.Floor(x);
                                    break;
                                case "ceil":
                                    x = Math.Ceiling(x);
                                    break;
                                case "cbrt":
                                    x = Math.Cbrt(x);
                                    break;
                                case "exp":
                                    x = Math.Exp(x);
                                    break;
                                case "fabs":
                                    x = Math.Abs(x);
                                    break;
                                case "trunc":
                                    x = Math.Truncate(x);
                                    break;
                                case "round":
                                    x = Math.Round(x);
                                    break;
                                case "log":
                                    x = Math.Log(x, 10);
                                    break;
                                case "log3":
                                    x = Math.Log(x, 3);
                                    break;
                                case "log4":
                                    x = Math.Log(x, 4);
                                    break;
                                case "log5":
                                    x = Math.Log(x, 5);
                                    break;
                                case "log6":
                                    x = Math.Log(x, 6);
                                    break;
                                case "log7":
                                    x = Math.Log(x, 7);
                                    break;
                                case "log8":
                                    x = Math.Log(x, 8);
                                    break;
                                case "log9":
                                    x = Math.Log(x, 9);
                                    break;
                                case "log2":
                                    x = Math.Log(x, 2);
                                    break;
                                case "log10":
                                    x = Math.Log(x, 10);
                                    break;
                                case "sqrt":
                                    x = Math.Sqrt(x);
                                    break;
                                case "sin":
                                    x = Math.Sin(x);
                                    break;
                                case "cos":
                                    x = Math.Cos(x);
                                    break;
                                case "tan":
                                    x = Math.Tan(x);
                                    break;
                                case "cotg":
                                    x = 1 / Math.Tan(x);
                                    break;
                                case "e":
                                    x = Math.Exp(x);
                                    break;
                                case "abs":
                                    x = Math.Abs(x);
                                    break;
                                case "sinh":
                                    x = Math.Sinh(x);
                                    break;
                                case "cosh":
                                    x = Math.Cosh(x);
                                    break;
                                case "tanh":
                                    x = Math.Tanh(x);
                                    break;
                                case "asin":
                                    x = Math.Asin(x);
                                    break;
                                case "acos":
                                    x = Math.Acos(x);
                                    break;
                                case "atan":
                                    x = Math.Atan(x);
                                    break;
                                case "acotg":
                                    x = 1 / (Math.Atan(x));
                                    break;
                                case "asinh":
                                    x = Math.Asinh(x);
                                    break;
                                case "acosh":
                                    x = Math.Acosh(x);
                                    break;
                                case "atanh":
                                    x = Math.Atanh(x);
                                    break;
                                case "acotanh":
                                    x = 1 / Math.Atanh(x);
                                    break;
                                default:
                                    throw new Exception("Invalid function");
                            }
                            stack.Push(x);
                        }
                        else
                        {
                            double y = stack.Pop();

                            switch (s)
                            {
                                case "+": y += x; break;
                                case "-": y -= x; break;
                                case "*": y *= x; break;
                                case "/": y /= x; break;
                                case "%": y %= x; break;
                                case "^": y = Math.Pow(y, x); break;
                                default:
                                    throw new Exception("Invalid operator");
                            }
                            stack.Push(y);
                        }
                    }
                    else if (((s.Length == 2) && (s[0] >= '0' && s[0] <= '9' && s[1] == '!')))
                    {
                        double value = Mathematics_Calculate.FindFactorial((int)(s[0] - '0'));
                        stack.Push(value);
                    }
                    else if (s.Length == 3 && (s[0] >= '1' && s[0] <= '9') && (s[1] >= '0' && s[1] <= '9') && s[2] == '!')
                    {
                        int value = (int)(s[0] - '0') * 10;
                        value += (int)(s[1] - '0');
                        stack.Push(Mathematics_Calculate.FindFactorial(value));
                    }
                    else if (s.Length == 4 && (s[0] >= '1' && s[0] <= '9') && (s[1] >= '0' && s[1] <= '9') && (s[2] >= '0' && s[2] <= '9') && s[3] == '!')
                    {
                        int value = (int)(s[0] - '0') * 100;
                        value += (int)(s[1] - '0') * 10;
                        value += (int)(s[2] - '0');
                        stack.Push(Mathematics_Calculate.FindFactorial(value));
                    }

                    else  // IsOperand
                    {
                        stack.Push(double.Parse(s));
                    }
                }
                return res + stack.Pop();
            }
            catch (Exception e)
            {
                return "ERROR";
            }
        }
            /*
                public static double EvaluateExpressionTree(BinaryTreeNode node)
                {
                    double t = 0;
                    if (node.IsLeaf)
                        t = double.Parse(node.Value);
                    else
                    {
                        double x = EvaluateExpressionTree(node.LeftChild);

                        string s = node.Value;

                        if (ExprHelper.IsUnaryFunction(s))
                        {
                            switch (s)
                            {
                                case "sqrt":
                                    t = Math.Sqrt(x);
                                    break;
                                case "sin":
                                    t = Math.Sin(x);
                                    break;
                                case "cos":
                                    t = Math.Cos(x);
                                    break;
                                case "tan":
                                    t = Math.Tan(x);
                                    break;
                                case "e^":
                                    x = Math.Exp(x);
                                    break;
                                case "abs":
                                    x = Math.Sqrt(x);
                                    break;
                                case "!":
                                    x = Mathematics_Calculate.FindFactorial((int)x);
                                    break;
                                case "sinh":
                                    x = Math.Sinh(x);
                                    break;
                                case "cosh":
                                    x = Math.Cosh(x);
                                    break;
                                case "tanh":
                                    x = Math.Tanh(x);
                                    break;
                                case "Acotg":
                                    x = 1 / (Math.Atan(x));
                                    break;
                                default:
                                    throw new Exception("Invalid function");
                            }
                        }
                        else if(s=="!") { x=Mathematics_Calculate.FindFactorial((int)x); 
                        }
                        else
                        {
                            double y = EvaluateExpressionTree(node.RightChild);

                            switch (s)
                            {
                                case "+": t = y + x; break;
                                case "-": t = y - x; break;
                                case "*": t = y * x; break;
                                case "/": t = y / x; break;
                                case "%": t = y % x; break;
                                case "^": t = Math.Pow(y, x); break;
                                default:
                                    throw new Exception("Invalid operator");
                            }

                        }
                    }
                    return t;
                }

                #endregion

                #region Create Expression Tree
                /// <summary>
                /// Tạo một cây nhị phân 3 node với node gốc là toán tử, 2 node lá là toán hạng
                /// </summary>
                /// <param name="node"></param>
                /// <param name="opStack"></param>
                /// <param name="nodeStack"></param>        
                private static void CreateSubTree(Stack<BinaryTreeNode> opStack, Stack<BinaryTreeNode> nodeStack)
                {
                    BinaryTreeNode node = opStack.Pop();
                    node.LeftChild = nodeStack.Pop();
                    if (!ExprHelper.IsUnaryFunction(node.Value))
                        node.RightChild = nodeStack.Pop();
                    nodeStack.Push(node);
                }

                public static BinaryTreeNode Infix2ExpressionTree(string infixExpression)
                {
                    List<string> prefix = new List<string>();
                    Stack<BinaryTreeNode> operatorStack = new Stack<BinaryTreeNode>();
                    Stack<BinaryTreeNode> nodeStack = new Stack<BinaryTreeNode>();

                    infixExpression = ExprHelper.FormatExpression(infixExpression);

                    string[] tokens = infixExpression.Split(' ').ToArray();

                    for (int i = 0; i < tokens.Count(); i++)
                    {
                        if (ExprHelper.IsOperator(tokens[i]))
                        {
                            if ((i == 0) || (i > 0 && (ExprHelper.IsOperator(tokens[i - 1]) || tokens[i - 1] == "(")))
                            {
                                if (tokens[i] == "-")
                                {
                                    nodeStack.Push(new BinaryTreeNode(tokens[i] + tokens[i + 1]));
                                    i++;
                                }
                                else if (ExprHelper.IsUnaryFunction(tokens[i]))
                                    operatorStack.Push(new BinaryTreeNode(tokens[i]));
                            }
                            else
                            {
                                while (operatorStack.Count > 0 && ExprHelper.GetPriority(operatorStack.Peek().Value) >= ExprHelper.GetPriority(tokens[i]))
                                    CreateSubTree(operatorStack, nodeStack);

                                operatorStack.Push(new BinaryTreeNode(tokens[i]));
                            }
                        }


                        else if (tokens[i] == "(")
                            operatorStack.Push(new BinaryTreeNode(tokens[i]));
                        else if (tokens[i] == ")")
                        {
                            while (operatorStack.Peek().Value != "(")
                                CreateSubTree(operatorStack, nodeStack);
                            operatorStack.Pop();
                        }
                        else //if (IsOperand(tokens[i]))
                            nodeStack.Push(new BinaryTreeNode(tokens[i]));
                    }

                    while (operatorStack.Count > 0)
                        CreateSubTree(operatorStack, nodeStack);

                    return nodeStack.Peek();
                }

                public static BinaryTreeNode Postfix2ExpressionTree(string postfixExpression)
                {
                    Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

                    IEnumerable<string> enumer = postfixExpression.Split(' ');

                    foreach (string s in enumer)
                    {
                        BinaryTreeNode node = new BinaryTreeNode(s);
                        if (ExprHelper.IsOperand(s))
                            stack.Push(node);
                        else if (ExprHelper.IsOperator(s))
                        {
                            node.RightChild = stack.Pop();
                            node.LeftChild = stack.Pop();
                            stack.Push(node);
                        }
                    }
                    return stack.Pop();
                }
                #endregion
            }
            public class BinaryTreeNode
            {
                public BinaryTreeNode LeftChild;
                public BinaryTreeNode RightChild;
                public string Value;

                public bool IsLeaf
                {
                    get { return this.LeftChild == null && this.RightChild == null; }
                }

                public BinaryTreeNode(string value)
                {
                    Value = value;
                }
            }
            */
            #endregion
    }
}
