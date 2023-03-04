using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Mathematics_TheoremList
    {
        static Mathematics_Theorem[] hash_MathematicsTheorem = new Mathematics_Theorem[13];
        public static void Docfile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        Mathematics_Theorem dinhluat = new Mathematics_Theorem();
                        dinhluat.ID = int.Parse(arr[0]);
                        dinhluat.Name = arr[1];
                        dinhluat.Description = arr[2];
                        dinhluat.formula = arr[3];
                        Mathematics_TheoremList.Mathematics_Insert_Hash(dinhluat);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static int Mathematics_Theorem_Hash(int ID)
        {
            return ((ID - 3) % 13);
        }
        public static void Mathematics_Insert_Hash(Mathematics_Theorem dinhluat)
        {
            int index = Mathematics_TheoremList.Mathematics_Theorem_Hash(dinhluat.ID);
            if (Mathematics_TheoremList.hash_MathematicsTheorem[index]==null)
            {
                Mathematics_TheoremList.hash_MathematicsTheorem[index] = dinhluat;
                return;
            }
            else
            {
                dinhluat.NodeNext = Mathematics_TheoremList.hash_MathematicsTheorem[index] = dinhluat;
                Mathematics_TheoremList.hash_MathematicsTheorem[index] = dinhluat;
            }
        }
        public static void Output(Mathematics_Theorem dinhluat)
        {
            if (dinhluat != null)
                Console.WriteLine(dinhluat.ID + " - " + dinhluat.Name + " - " + dinhluat.Description + " - " + dinhluat.formula);
            else return;
        }
        public static Mathematics_Theorem Find_Chemistry_Theorem(int ID)
        {
            int index = Mathematics_TheoremList.Mathematics_Theorem_Hash(ID);
            Mathematics_Theorem dinhluat = Mathematics_TheoremList.hash_MathematicsTheorem[index];
            while (dinhluat != null)
            {
                if (dinhluat.ID == ID) return dinhluat;
                dinhluat = dinhluat.NodeNext;
            }
            return null;
        }
    }
}
