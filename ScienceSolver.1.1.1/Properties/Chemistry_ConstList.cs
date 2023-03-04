using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public static class Chemistry_ConstList
    {
        static Chemistry_Const[] Hash_DsHangSo = new Chemistry_Const[13];
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
                        Chemistry_Const hangso = new Chemistry_Const();
                        hangso.ID = int.Parse(a[0]);
                        hangso.Sign = a[1];
                        hangso.Name = a[2];
                        hangso.Description = a[3];
                        hangso.Value = a[4];
                        hangso.Unit = a[5];
                        Chemistry_ConstList.Chemistry_Insert_Const(hangso);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Chemistry_Insert_Const(Chemistry_Const hangso)
        {
            int index = Chemistry_Const_Hash(hangso.Sign);
            if (Chemistry_ConstList.Hash_DsHangSo[index] == null)
            {
                Hash_DsHangSo[index] = hangso;
                return;
            }
            else// Chen vao dau
            {
                hangso.Nodenext = Chemistry_ConstList.Hash_DsHangSo[index];
                Chemistry_ConstList.Hash_DsHangSo[index] = hangso;
            }
        }
        public static int Chemistry_Const_Hash(string sign)
        {
            int index = 0;
            for (int i = 0; i < sign.Length; i++)
            {
                index += (int)sign[i];
            }
            return (index % 13);
        }
        public static Chemistry_Const Find_Chemistry_Const(string sign)
        {
            int index = Chemistry_Const_Hash(sign);
            Chemistry_Const hangso = Chemistry_ConstList.Hash_DsHangSo[index];
            while (hangso != null)
            {
                if (hangso.Sign == sign) return hangso;
                hangso = hangso.Nodenext;
            }
            return null;
        }
        public static void Output(Chemistry_Const hangso)
        {
            if (hangso != null)
                Console.WriteLine(hangso.ID + " - " + hangso.Sign + " - " + hangso.Name + " - " +
                    hangso.Description + " - " + hangso.Value + " - " + hangso.Unit);
            else return;
        }
    }
}
