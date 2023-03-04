using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Chemistry_TheoremList
    {
       static Chemistry_Theorem[] hash_chemistry_Theorems=new Chemistry_Theorem[7];
       public static void Docfile(string path)
       {
            try
            {
                StreamReader sr=new StreamReader(path,Encoding.UTF8);
                string line=sr.ReadLine();
                while(line != null) 
                {
                    string[]arr=line.Split(';');
                    if(arr.Length==4)
                    {
                        Chemistry_Theorem dinhluat = new Chemistry_Theorem();
                        dinhluat.ID = int.Parse(arr[0]);
                        dinhluat.Name = arr[1];
                        dinhluat.Description= arr[2];
                        dinhluat.formula = arr[3];
                        Chemistry_TheoremList.Chemistry_Insert_Hash(dinhluat);  
                    }   
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
       }
        public static int Chemistry_Theorem_Hash(int ID)
        {
            return ((ID + 1) % 7);
        }
        public static void Chemistry_Insert_Hash(Chemistry_Theorem dinhluat)
        {
            int index= Chemistry_TheoremList.Chemistry_Theorem_Hash(dinhluat.ID);
            if (Chemistry_TheoremList.hash_chemistry_Theorems[index]==null)
            {
                Chemistry_TheoremList.hash_chemistry_Theorems[index] = dinhluat;
                return;
            }    
            else
            {
                dinhluat.NodeNext = Chemistry_TheoremList.hash_chemistry_Theorems[index] = dinhluat;
                Chemistry_TheoremList.hash_chemistry_Theorems[index]=dinhluat;
            }    
        }
        public static void Output(Chemistry_Theorem dinhluat)
        {
            if (dinhluat != null)
                Console.WriteLine(dinhluat.ID + " - " + dinhluat.Name + " - " + dinhluat.Description + " - " + dinhluat.formula);
            else return;
        }
        public static Chemistry_Theorem Find_Chemistry_Theorem(int ID)
        {
            int index = Chemistry_TheoremList.Chemistry_Theorem_Hash(ID);
            Chemistry_Theorem dinhluat = Chemistry_TheoremList.hash_chemistry_Theorems[index];
            while (dinhluat != null)
            {
                if (dinhluat.ID == ID) return dinhluat;
                dinhluat = dinhluat.NodeNext;
            }
            return null;
        }
    }
}
