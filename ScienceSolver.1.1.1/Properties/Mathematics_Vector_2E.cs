using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_ScienceSolver
{
    public class Mathematics_Vector_2E
    {
        private double x;
        private double y;
        ~Mathematics_Vector_2E() { }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public Mathematics_Vector_2E() 
        { }
        public Mathematics_Vector_2E(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Input()
        {
            Console.Write("x:");this.X=Convert.ToDouble(this.X);
            Console.Write("y:");this.Y=Convert.ToDouble(this.Y);
        }
        public void Output()
        {
            Console.Write("x="+this.X+"\n");
            Console.Write("y=" + this.Y+"\n");
        }
        public static double FindingAngle(Mathematics_Vector_2E vecto1, Mathematics_Vector_2E vecto2) 
        {
            return Math.Acos(Mathematics_Vector_2E.ScalarProductVecto(vecto1, vecto2) 
                / (Mathematics_Vector_2E.AbsoulteVecto(vecto1) * Mathematics_Vector_2E.AbsoulteVecto(vecto2)));
        }
        public static double AbsoulteVecto(Mathematics_Vector_2E vector1)
        {
            return (Math.Sqrt(Math.Pow(vector1.X, 2) + Math.Pow(vector1.Y, 2)));
        }
        public static double ScalarProductVecto(Mathematics_Vector_2E vector1, Mathematics_Vector_2E vector2) 
        {
            return (vector1.X*vector2.X+ vector1.Y*vector2.Y);  
        } 
        public static Mathematics_Vector_2E operator +(Mathematics_Vector_2E vecto1,Mathematics_Vector_2E vecto2)
        {
            Mathematics_Vector_2E res=new Mathematics_Vector_2E();
            res.X = vecto1.X+vecto2.X;
            res.Y = vecto1.Y+vecto2.Y;
            return res;
        }
        public static Mathematics_Vector_2E operator -(Mathematics_Vector_2E vecto1, Mathematics_Vector_2E vecto2)
        {
            Mathematics_Vector_2E res = new Mathematics_Vector_2E();
            res.X = vecto1.X - vecto2.X;
            res.Y = vecto1.Y - vecto2.Y;
            return res;
        }

    }
}
