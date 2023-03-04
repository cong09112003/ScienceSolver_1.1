using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Chemistry_ListElements
    {
        static Chemistry_Elements[] Hash_dsNguyenTo = new Chemistry_Elements[23];
        public static void Docfile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 7)
                    {
                        Chemistry_Elements nguyento = new Chemistry_Elements();
                        nguyento.Element_ID = int.Parse(a[0]);
                        nguyento.Chemis_Sign = a[1];
                        nguyento.Element_Name = a[2];
                        nguyento.Element_Atomic_Mass = double.Parse(a[3]);
                        nguyento.Element_Configuration = a[4];
                        nguyento.Electronegativity = double.Parse(a[5]);
                        nguyento.Oxidation = a[6];
                        Chemistry_ListElements.Chemistry_Insert_Element(nguyento);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Chemistry_Insert_Element(Chemistry_Elements nguyento)
        {
            int index = Chemistry_element_Hash(nguyento.Element_ID);
            if (Chemistry_ListElements.Hash_dsNguyenTo[index] == null)
            {
                Hash_dsNguyenTo[index] = nguyento;
                return;
            }
            else // Chèn vào đầu:
            {
                nguyento.NodeNext = Chemistry_ListElements.Hash_dsNguyenTo[index];
                Chemistry_ListElements.Hash_dsNguyenTo[index] = nguyento;
            }
        }
        public static int Chemistry_element_Hash(int key)
        {
            return (key % 23);
        }
        public static Chemistry_Elements Find_Elements(int ID)
        {
            int index = Chemistry_element_Hash(ID);
            Chemistry_Elements nguyento = Chemistry_ListElements.Hash_dsNguyenTo[index];
            while (nguyento != null)
            {
                if (nguyento.Element_ID == ID) return nguyento;
                nguyento = nguyento.NodeNext;
            }
            return null;
        }
        public static void Output(Chemistry_Elements nguyento)
        {
            Console.WriteLine(nguyento.Element_ID + "-" + nguyento.Chemis_Sign + "-" + nguyento.Element_Name + "-" + nguyento.Element_Atomic_Mass + "-"
            + nguyento.Electronegativity + "-" + nguyento.Element_Configuration + "-" + nguyento.Oxidation);
        }
    }
}
