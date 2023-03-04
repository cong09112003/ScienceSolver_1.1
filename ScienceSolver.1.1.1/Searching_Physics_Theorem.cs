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
    public partial class Searching_Physics_Theorem : Form
    {
        public Searching_Physics_Theorem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Physics_TheoremList.Docfile(Application.StartupPath + "//DinhLuatVatLy.txt");
            Physics_Theorem res=Physics_TheoremList.Find_Physics_Theorem(int.Parse(textBox1.Text)); 
            if (res != null) 
            {
                textBox2.Text = "Result";
                listBox1.Items.Clear();
                listBox1.Items.Add("ID of theorem:" + res.ID);
                listBox1.Items.Add("Name of theorem:" + res.Name);
                listBox1.Items.Add("Description of theorem:");
                string[] arr=res.Description.Split(".");
                for(int i = 0; i < arr.Length;i++)
                    listBox1.Items.Add(arr[i]);
                listBox1.Items.Add("Formula of theorem:");
                listBox1.Items.Add(res.formula);
            }
            else
            {
                listBox1.Items.Clear();
                textBox2.Text = "ERORR";
            }
        }
        List<Physics_Theorem> ds= new List<Physics_Theorem>();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Docfile();
            try
            {
                textBox2.Text = "Result";
                listBox1.Items.Clear();
                int Count =0;
                foreach(Physics_Theorem res in ds)
                {
                    listBox1.Items.Add("Num of:"+(++Count));
                    listBox1.Items.Add("ID of theorem:" + res.ID);
                    listBox1.Items.Add("Name of theorem:" + res.Name);
                    listBox1.Items.Add("Description of theorem:");
                    string[] arr = res.Description.Split(".");
                    for (int i = 0; i < arr.Length; i++)
                        listBox1.Items.Add(arr[i]);
                    listBox1.Items.Add("Formula of theorem:");
                    listBox1.Items.Add(res.formula);
                    listBox1.Items.Add("");
                }    
            }
            catch(Exception ex) 
            {
                textBox2.Text = "ERORR";
                MessageBox.Show(ex.Message);
            }
        }
        public void Docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "//DinhLuatVatLy.txt", Encoding.UTF8);
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
                        ds.Add(dinhluat);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
