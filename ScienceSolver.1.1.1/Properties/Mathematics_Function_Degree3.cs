using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Mathematics_Function_Degree3 : Mathematics_Function
    {
        public void Mathematics_Funtion_Input1(int a, int b, int c, int d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }
        public override void Mathematics_Funtion_Input()
        {
            Console.Write("Input a:"); this.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:"); this.B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:"); this.C = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d:"); this.D = Convert.ToDouble(Console.ReadLine());
        }
        public override void Mathematics_Funtion_Output()
        {
            base.Mathematics_Funtion_Output();
        }
        public override void Mathematics_Function_Solving()
        {
            this.Varible = Mathematics_Function_SolvingDegree3(this.A, this.B, this.C, this.D);
        }
        ~Mathematics_Function_Degree3()
        { }
    }
}
