using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class Searching_Physical_Constant : Form
    {
        public Searching_Physical_Constant()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        List<Physics_Const> ds= new List<Physics_Const>();  
        private void button1_Click(object sender, EventArgs e)
        {
            Physics_ConstList.Docfile(Application.StartupPath + "\\HangSoVatLy.txt");
            Physics_Const res = Physics_ConstList.Find_Physics_Const(textBox1.Text);
            if (res != null) 
            {
                textBox2.Text = "Result";
                listBox1.Items.Clear();
                listBox1.Items.Add("Sign: " + res.Sign);
                listBox1.Items.Add("Name: " + res.Name);
                listBox1.Items.Add("value: " + res.Value);
                listBox1.Items.Add("Unit: " + res.Unit);
            }
            else
            {
                textBox2.Text = "ERROR";
                listBox1.Items.Clear();
            }
        }
        public void docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath+"\\HangSoVatLy.txt", Encoding.UTF8);
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
        private void button2_Click(object sender, EventArgs e)
        {
            docfile();
            listBox1.Items.Clear();
            if(ds.Count==0)
            {
                listBox1.Items.Clear();
                textBox2.Text = "ERROR";
            }
            else
            {
                for(int i=0;i<ds.Count;i++)
                {
                    listBox1.Items.Add("ID: "+ds[i].ID);
                    listBox1.Items.Add("Sign: "+ds[i].Sign);
                    listBox1.Items.Add("Name: "+ds[i].Name);
                    listBox1.Items.Add("Description: "+ds[i].Description);
                    listBox1.Items.Add("value: "+ds[i].Value);
                    listBox1.Items.Add("Unit: "+ds[i].Unit);
                    listBox1.Items.Add("");
                }
            }
        }
    }
}
