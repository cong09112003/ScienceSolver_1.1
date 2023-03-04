using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class SearchingChemicalConst : Form
    {
        public SearchingChemicalConst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chemistry_ConstList.Docfile(Application.StartupPath + "\\HangSoHoaHoc.txt");
            Chemistry_Const res = Chemistry_ConstList.Find_Chemistry_Const(textBox1.Text);
            if (res != null) 
            {
                listBox1.Items.Clear();
                textBox2.Text = "SUCCESS";
                listBox1.Items.Add("ID:" + res.ID);
                listBox1.Items.Add("Sign:" + res.Sign);
                listBox1.Items.Add("Name:" + res.Name);
                listBox1.Items.Add("Value:" + res.Value);
                listBox1.Items.Add("Unit:" + res.Unit);
            }
        }
        static List<Chemistry_Const> ds=new List<Chemistry_Const>();
        private void button2_Click(object sender, EventArgs e)
        {
            docfile();
            try
            {
                textBox2.Text = "SUCCESS";
                listBox1.Items.Clear();
                foreach (Chemistry_Const res in ds)
                {
                    listBox1.Items.Add("ID:" + res.ID);
                    listBox1.Items.Add("Sign:" + res.Sign);
                    listBox1.Items.Add("Name:" + res.Name);
                    listBox1.Items.Add("Value:" + res.Value);
                    listBox1.Items.Add("Unit:" + res.Unit);
                    listBox1.Items.Add("");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void  docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath+ "\\HangSoHoaHoc.txt", Encoding.UTF8);
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
                        ds.Add(hangso);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
