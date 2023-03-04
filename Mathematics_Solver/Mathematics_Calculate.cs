using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics_Solver
{
    public class Mathematics_Calculate
    {
        // fields
        public string sInfix;
        public string sPostfix;
        public string infix
        {
            get { return this.sInfix; }
            set { this.sInfix = value; }
        }
        // constructors
        public Mathematics_Calculate()
        {
            this.infix = "";
            this.sPostfix = "";
        }
        public Mathematics_Calculate(string infix)
        {
            this.sInfix = infix;
        }
        ~Mathematics_Calculate() { }
        //Methods
        public void Input()
        {
            Console.WriteLine("Input the Expressions:");
            this.infix = Console.ReadLine();
        }
        public void Input(string infix)
        {
            this.infix = infix;
        }
        public void Output()
        {
            Console.WriteLine(this.sPostfix);
            Console.WriteLine(this.EvaluatePostfix(this.sPostfix));
        }
        public void Solving()
        {
            this.sPostfix = Infix_to_Postfix(this.infix);
        }
        public static string AnalyizePrimeFators(int n)
        {
            string res = "";
            int i = 2;
            if (n <= 1) return "Error";
            else
            {
                int temp = 0;
                while (i <= n)
                {
                    temp = 0;
                    while (n % i == 0)
                    {
                        ++temp;
                        n /= i;
                    }
                    if (temp != 0)
                    {
                        res += i;
                        if (temp > 1) res += "^" + temp;
                        if (n > i) res += "*";
                    }
                    i++;
                }
                return res;
            }
        }
        public static string Infix_to_Postfix(string infix)
        {
            // Initiation
            Stack<char> stack = new Stack<char>();
            string res = "";
            for (int i = 0; i < infix.Length; i++)
            {
                char temp = infix[i];
                if ((temp >= 'a' && temp <= 'z') || (temp >= 'A' && temp <= 'Z')
                    || (temp >= '0' && temp <= '9'))
                    res += temp;
                else if (temp == '(')
                {
                    stack.Push('(');
                }
                else if (temp == ')')
                {
                    // stack.top ->stack.peek
                    while (stack.Peek() != '(')
                    {
                        res += stack.Peek();
                        stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count != 0 && getPriority(infix[i]) <= getPriority(stack.Peek()))
                    {
                        res += stack.Peek();
                        stack.Pop();
                    }
                    stack.Push(temp);
                }
            }
            while (stack.Count != 0)
            {
                res += stack.Peek();
                stack.Pop();
            }
            return res;
        }
        public static int getPriority(char x)
        {
            if (x == '!') return 4;
            else if (x == '^') return 3;
            else if (x == '/' || x == '*' || x == '%' || x == 'x' || x == '÷' || x == '%') return 2;
            else if (x == '+' || x == '-') return 1;
            else return -1;
        }
        public static double FindFactorial(int x)
        {
            if (x == 0) return 1;
            else if (x == 1) return 1;
            else return (x * FindFactorial(x - 1));
        }
        public static double Find_logarit_W1(double Dbase, double product)
        {
            if (Dbase == product)
                return 1;
            if (product == 1)
                return 0;
            double current_log = 1;
            bool closet_int = false;
            while (!closet_int)
            {
                double current_errer = System.Math.Abs(product - System.Math.Pow(Dbase, current_log));
                if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log + 1)))
                    current_log += 1;
                else if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log - 1)))
                    current_log -= 1;
                else closet_int = true;
            }
            double pow_change = 1;
            for (int i = 0; i <= 20; i++)
            {
                pow_change /= 2;
                double current_errer = System.Math.Abs(product - System.Math.Pow(Dbase, current_log));
                if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log + pow_change)))
                    current_log += pow_change;
                else if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log - pow_change)))
                    current_log -= pow_change;
            }
            return current_log;
        }
        public static double Find_Logatit_W2(double Dbase, double Dproduct)
        {
            return (System.Math.Log(Dbase, Dproduct));
        }
        public double EvaluatePostfix(string exp)
        {
            Stack<double> stack = new Stack<double>();
            double a, b;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] >= '0' && exp[i] <= '9' && exp[i + 1] == '!')
                {
                    stack.Push(FindFactorial(exp[i] - '0')); i += 1;
                }
                else if (exp[i] >= '0' && exp[i] <= '9')
                {
                    stack.Push(exp[i] - '0');
                }
                else
                {
                    a = stack.Peek(); stack.Pop();
                    b = stack.Peek(); stack.Pop();
                    switch (exp[i])
                    {
                        case '+':
                            stack.Push(b + a);
                            break;
                        case '-':
                            stack.Push(b - a);
                            break;
                        case '*':
                            stack.Push(b * a);
                            break;
                        case '/':
                            stack.Push(b / a);
                            break;
                        case '^':
                            stack.Push(System.Math.Pow(b, a));
                            break;
                        case 'x':
                            stack.Push(b * a);
                            break;
                        case '÷':
                            stack.Push(b / a);
                            break;
                        case '%':
                            stack.Push(b % a);
                            break;
                    }
                }
            }
            return stack.Peek();
        }
    }
}
