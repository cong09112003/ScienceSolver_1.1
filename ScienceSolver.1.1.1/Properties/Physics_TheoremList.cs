using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Physics_TheoremList
    {
        static Physics_Theorem[] hash_Physical_Theorem = new Physics_Theorem[13];
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
                        Physics_Theorem dinhluat = new Physics_Theorem();
                        dinhluat.ID = int.Parse(arr[0]);
                        dinhluat.Name = arr[1];
                        dinhluat.Description = arr[2];
                        dinhluat.formula = arr[3];
                        Physics_TheoremList.Physics_Insert_Hash(dinhluat);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static int Physics_Theorem_Hash(int ID)
        {
            return ((ID - 3) % 13);
        }
        public static void Physics_Insert_Hash(Physics_Theorem dinhluat)
        {
            int index = Physics_TheoremList.Physics_Theorem_Hash(dinhluat.ID);
            if (Physics_TheoremList.hash_Physical_Theorem[index] == null)
            {
                Physics_TheoremList.hash_Physical_Theorem[index] = dinhluat;
                return;
            }
            else
            {
                dinhluat.NodeNext = Physics_TheoremList.hash_Physical_Theorem[index];
                Physics_TheoremList.hash_Physical_Theorem[index] = dinhluat;
            }
        }
        public static void Output(Physics_Theorem dinhluat)
        {
            if (dinhluat != null)
                Console.WriteLine(dinhluat.ID + " - " + dinhluat.Name + " - " + dinhluat.Description + " - " + dinhluat.formula);
            else return;
        }
        public static Physics_Theorem Find_Physics_Theorem(int ID)
        {
            int index=Physics_TheoremList.Physics_Theorem_Hash(ID);
            Physics_Theorem dinhluat = Physics_TheoremList.hash_Physical_Theorem[index];
            while(dinhluat!=null)
            {
                if(dinhluat.ID== ID) return dinhluat;
                dinhluat = dinhluat.NodeNext;
            }
            return null;
        }
    }
}
