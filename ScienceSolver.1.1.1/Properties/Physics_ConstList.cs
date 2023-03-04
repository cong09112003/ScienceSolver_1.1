using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Physics_ConstList
    {
        static Physics_Const[] Hash_DsHangSo = new Physics_Const[10];
        public static void Docfile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 6)
                    {
                        Physics_Const hangso = new Physics_Const();
                        hangso.ID = int.Parse(a[0]);
                        hangso.Sign = a[1];
                        hangso.Name = a[2];
                        hangso.Description = a[3];
                        hangso.Value = a[4];
                        hangso.Unit = a[5];
                        Physics_ConstList.Physics_Insert_Const(hangso);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static  void Physics_Insert_Const(Physics_Const hangso)
        {
            int index = Physics_Const_Hash(hangso.Sign);
            if (Physics_ConstList.Hash_DsHangSo[index] == null)
            {
                Hash_DsHangSo[index] = hangso;
                return;
            }
            else// Chen vao dau
            {
                hangso.Nodenext = Physics_ConstList.Hash_DsHangSo[index];
                Physics_ConstList.Hash_DsHangSo[index] = hangso;
            }
        }
        public static int Physics_Const_Hash(string sign)
        {
            int index = 0;
            for (int i = 0; i < sign.Length; i++)
            {
                index += (int)sign[i];
            }
            return (index % 10);
        }
        public static Physics_Const Find_Physics_Const(string sign)
        {
            int index = Physics_Const_Hash(sign);
            Physics_Const hangso = Physics_ConstList.Hash_DsHangSo[index];
            while (hangso != null)
            {
                if (hangso.Sign == sign) return hangso;
                hangso = hangso.Nodenext;
            }
            return null;
        }
        public static void Output(Physics_Const hangso)
        {
            if (hangso != null)
                Console.WriteLine(hangso.ID + " - " + hangso.Sign + " - " + hangso.Name + " - " +
                    hangso.Description + " - " + hangso.Value + " - " + hangso.Unit);
            else return;
        }
    }
}
