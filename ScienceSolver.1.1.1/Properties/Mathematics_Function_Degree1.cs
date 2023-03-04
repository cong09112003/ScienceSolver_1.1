using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Mathematics_Function_Degree1 : Mathematics_Function
    {
        public void Mathematics_Funtion_Input1(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void Input(int a,int b)
        {
            this.A = a;
            this.B = b;
        }
        public override void Mathematics_Funtion_Input()
        {
            Console.Write("Input a:"); this.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:"); this.B = Convert.ToDouble(Console.ReadLine());
        }
        public override void Mathematics_Funtion_Output()
        {
            base.Mathematics_Funtion_Output();
        }
        public override void Mathematics_Function_Solving()
        {
            this.Varible =Mathematics_Function_SolvingDegree1(this.A, this.B);
        }
        ~Mathematics_Function_Degree1()
        { }
    }
}
