using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_ScienceSolver
{
    public class Mathematics_Vector_3E
    {
        private double x;
        private double y;
        private double z;
        ~Mathematics_Vector_3E() { }
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
        public double Z
        {
            get { return this.z; }
            set
            {
                this.z = value;
            }
        }
        public Mathematics_Vector_3E() { }
        public Mathematics_Vector_3E(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public void Input()
        {

            Console.Write("x:"); this.X = Convert.ToDouble(this.X);
            Console.Write("y:"); this.Y = Convert.ToDouble(this.Y);
            Console.Write("z:"); this.Z = Convert.ToDouble(this.Z);
            
        }
        public void Ouput()
        {
            Console.Write("x=" + this.X + "\n");
            Console.Write("y=" + this.Y + "\n");
            Console.Write("z=" + this.Z + "\n");
        }
        public static Mathematics_Vector_3E operator +(Mathematics_Vector_3E vecto1, Mathematics_Vector_3E vecto2)
        {
            Mathematics_Vector_3E res = new Mathematics_Vector_3E();
            res.X = vecto1.X + vecto2.X;
            res.Y = vecto1.Y + vecto2.Y;
            res.Z = vecto1.Z + vecto2.Z;
            return res;
        }
        public static Mathematics_Vector_3E operator -(Mathematics_Vector_3E vecto1, Mathematics_Vector_3E vecto2)
        {
            Mathematics_Vector_3E res = new Mathematics_Vector_3E();
            res.X = vecto1.X - vecto2.X;
            res.Y = vecto1.Y - vecto2.Y;
            res.Z = vecto1.Z - vecto2.Z;
            return res;
        }
        // distance of vecto
        public static double AbsoulteVecto(Mathematics_Vector_3E vector1)
        {
            return (Math.Sqrt(Math.Pow(vector1.X, 2) + Math.Pow(vector1.Y, 2) + Math.Pow(vector1.Z,2)));
        }
        // Scalar product of 2 vecto
        public static double ScalarProductVecto(Mathematics_Vector_3E vector1, Mathematics_Vector_3E vector2)
        {
            return (vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z);
        }
        public static double FindingAngle(Mathematics_Vector_3E vecto1, Mathematics_Vector_3E vecto2)
        {
            return Math.Acos(Mathematics_Vector_3E.ScalarProductVecto(vecto1, vecto2) / (Mathematics_Vector_3E.AbsoulteVecto(vecto1) * Mathematics_Vector_3E.AbsoulteVecto(vecto2)));
        }
        public static Mathematics_Vector_3E DirectedProductVector(Mathematics_Vector_3E vecto1,Mathematics_Vector_3E vecto2)
        {
            Mathematics_Vector_3E res=new Mathematics_Vector_3E();
            res.X = vecto1.Y * vecto2.Z - vecto2.Y * vecto1.Z;
            res.Y = vecto1.Z * vecto2.X - vecto2.Z * vecto1.X;
            res.Z = vecto1.X * vecto2.Y - vecto1.Y * vecto2.X;
            return res;
        }
        public static double FindingSinAngle(Mathematics_Vector_3E vecto1,Mathematics_Vector_3E vecto2)
        {
            return ((Mathematics_Vector_3E.AbsoulteVecto(Mathematics_Vector_3E.DirectedProductVector(vecto1, vecto2))) / ((Mathematics_Vector_3E.AbsoulteVecto(vecto1)) * Mathematics_Vector_3E.AbsoulteVecto(vecto2)));
        }
        public static double ExchangeRadian_To_C(double x)
        {
            return 180 * x;
        }
    }
}
