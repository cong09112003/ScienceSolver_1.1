using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Physics_ListFormula
    {
        static Physics_Formula[] Hash_List_PhysicsFormulas = new Physics_Formula[10];
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
                        Physics_Formula congthuc = new Physics_Formula();
                        congthuc.ID = int.Parse(arr[0]);
                        congthuc.Name = arr[1];
                        congthuc.Description = arr[2];
                        congthuc.Formula = arr[3];
                        Physics_ListFormula.Physics_Insert_Hash(congthuc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Physics_Insert_Hash(Physics_Formula congthuc)
        {
            int index = Physics_Formula_Hash(congthuc.ID);
            if (Physics_ListFormula.Hash_List_PhysicsFormulas[index] == null)
            {
                Physics_ListFormula.Hash_List_PhysicsFormulas[index] = congthuc;
                return;
            }
            else
            {
                congthuc.NodeNext = Physics_ListFormula.Hash_List_PhysicsFormulas[index];
                Physics_ListFormula.Hash_List_PhysicsFormulas[index] = congthuc;
            }
        }
        public static int Physics_Formula_Hash(int iD)
        {
            return ((7 * iD) % 10);
        }
        public static void Output(Physics_Formula congthuc)
        {
            if (congthuc != null)
                Console.WriteLine(congthuc.ID + " - " + congthuc.Name + " - " + congthuc.Description + " - " + congthuc.Formula);
            else return;
        }
        public static Physics_Formula Find_Physics_Formula(int ID)
        {
            int index = Physics_Formula_Hash(ID);
            Physics_Formula congthuc = Physics_ListFormula.Hash_List_PhysicsFormulas[index];
            while (congthuc != null)
            {
                if (congthuc.ID == ID) return congthuc;
                congthuc = congthuc.NodeNext;
            }
            return null;
        }
    }
}
