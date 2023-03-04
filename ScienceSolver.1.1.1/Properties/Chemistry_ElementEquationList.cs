using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Chemistry_ElementsEquationList
    {
        static Chemistry_ElementsEquation[] hash_dsPhuongtrinhChemistry=new Chemistry_ElementsEquation[37];
        public  static void DocFile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 2)
                    {
                        Chemistry_ElementsEquation phuongtrinhhoahoc = new Chemistry_ElementsEquation();
                        phuongtrinhhoahoc.Precursors = a[0];
                        // List of equation for each the precursor
                        phuongtrinhhoahoc.Chemist_Equation = a[1];
                        Chemistry_ElementsEquationList.Chemistry_Insert_Equation(phuongtrinhhoahoc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Chemistry_Insert_Equation(Chemistry_ElementsEquation phuongtrinhhoahoc)
        {
            int index = Chemistry_Equa_Hash(phuongtrinhhoahoc.Precursors);
            if (Chemistry_ElementsEquationList.hash_dsPhuongtrinhChemistry[index] == null)
            {
                hash_dsPhuongtrinhChemistry[index] = phuongtrinhhoahoc;
                return;
            }
            else
            {
                phuongtrinhhoahoc.Nodenext = Chemistry_ElementsEquationList.hash_dsPhuongtrinhChemistry[index];
                Chemistry_ElementsEquationList.hash_dsPhuongtrinhChemistry[index] = phuongtrinhhoahoc;
            }
        }
        public static int Chemistry_Equa_Hash(string sign)
        {
            // Normalize to lowercase
            sign = sign.ToLower();
            int index = 0;
            for (int i = 0; i < sign.Length; i++)
            {
                index += (int)sign[i];
            }
            return (index % 37);
        }
        public static Chemistry_ElementsEquation Find_Chemistr_Equation(string precursors)
        {
            int index = Chemistry_Equa_Hash(precursors);
            Chemistry_ElementsEquation phuongtrinhhoahoc = Chemistry_ElementsEquationList.hash_dsPhuongtrinhChemistry[index];
            while (phuongtrinhhoahoc != null)
            {
                if (phuongtrinhhoahoc.Precursors.ToLower() == precursors.ToLower()) return phuongtrinhhoahoc;
                phuongtrinhhoahoc = phuongtrinhhoahoc.Nodenext;
            }
            return new Chemistry_ElementsEquation();
        }
        public static void Ouput(Chemistry_ElementsEquation phuongtrinhhoahoc)
        {
            if (phuongtrinhhoahoc != null)
            {
                Console.WriteLine(phuongtrinhhoahoc.Precursors + ":");
                for (int i = 0; i < phuongtrinhhoahoc.Chemist_Equation.Count(); i++)
                {
                    Console.WriteLine(phuongtrinhhoahoc.Chemist_Equation[i]);
                }
            }
            else return;
        }
    }
}
