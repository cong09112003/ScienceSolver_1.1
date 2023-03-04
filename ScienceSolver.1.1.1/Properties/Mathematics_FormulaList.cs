using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Mathematics_FormulaList
    {
        static Mathematics_Formula[] Hash_dsMathFormula = new Mathematics_Formula[13];
        public static List<Mathematics_Formula> Docfile(string path)
        {
            List<Mathematics_Formula> ds = new List<Mathematics_Formula>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 4)
                    {
                        Mathematics_Formula congthuctoanhoc = new Mathematics_Formula();
                        if (a[0] == "Algebra") a[0] = "Đại số";
                        congthuctoanhoc.Area = a[0];
                        congthuctoanhoc.ID = a[1];
                        congthuctoanhoc.Name_For = a[2];
                        congthuctoanhoc.Formula = a[3];
                        ds.Add(congthuctoanhoc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ds;
        }
        public static void DocFile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 4)
                    {
                        Mathematics_Formula congthuctoanhoc = new Mathematics_Formula();
                        if (a[0] == "Algebra") a[0] = "Đại số";
                        if (a[0] == "Geometry") a[0] = "Hình học";
                        congthuctoanhoc.Area = a[0];
                        congthuctoanhoc.ID = a[1];
                        congthuctoanhoc.Name_For = a[2];
                        congthuctoanhoc.Formula = a[3];
                        Mathematics_FormulaList.Mathematics_Insert_Formula(congthuctoanhoc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Mathematics_Insert_Formula(Mathematics_Formula congthuctoanhoc)
        {
            int index =Mathematics_FormulaList.Mathematics_Formula_Hash(congthuctoanhoc.ID);
            if (Mathematics_FormulaList.Hash_dsMathFormula[index] == null)
            {
                Hash_dsMathFormula[index] = congthuctoanhoc;
                return;
            }
            else
            {
                congthuctoanhoc.NodeNext = Mathematics_FormulaList.Hash_dsMathFormula[index];
                Mathematics_FormulaList.Hash_dsMathFormula[index] = congthuctoanhoc;
            }
        }

        public static int Mathematics_Formula_Hash(string iD)
        {
            int index = 0;
            for (int i = 0; i < iD.Length; i++)
            {
                index += iD[i];
            }
            return (index % 13);
        }
        public static Mathematics_Formula Find_Mathematics_Formula(string ID)
        {
            int index = Mathematics_Formula_Hash(ID);
            Mathematics_Formula congthuctoanhoc = Mathematics_FormulaList.Hash_dsMathFormula[index];
            while (congthuctoanhoc != null)
            {
                if (congthuctoanhoc.ID == ID) return congthuctoanhoc;
                congthuctoanhoc = congthuctoanhoc.NodeNext;
            }
            return null;
        }
        public static void Ouput(Mathematics_Formula congthuctoanhoc)
        {
            if (Mathematics_FormulaList.Hash_dsMathFormula != null)
                Console.WriteLine(congthuctoanhoc.Area + " - " + congthuctoanhoc.ID + " - " + congthuctoanhoc.Name_For + " -" + congthuctoanhoc.Formula);
            else return;
        }
    }
}
