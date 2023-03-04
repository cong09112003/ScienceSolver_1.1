using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Mathematics_Function_Degree4 : Mathematics_Function
    {
        public void Mathematics_Funtion_Input1(int a, int b, int c, int d, int e)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
        }
        public override void Mathematics_Funtion_Input()
        {
            Console.Write("Input a:"); this.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b:"); this.B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c:"); this.C = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d:"); this.D = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input e:"); this.E = Convert.ToDouble(Console.ReadLine());
        }
        public override void Mathematics_Funtion_Output()
        {
            base.Mathematics_Funtion_Output();
        }
        public override void Mathematics_Function_Solving()
        {
            this.Varible = Mathematics_Function_Solving_Degree4(this.A, this.B, this.C, this.D, this.E);
        }
        ~Mathematics_Function_Degree4()
        { }
    }
}
