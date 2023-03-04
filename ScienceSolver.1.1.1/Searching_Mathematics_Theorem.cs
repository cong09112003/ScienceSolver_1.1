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
    public partial class Searching_Mathematics_Theorem : Form
    {
        public Searching_Mathematics_Theorem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mathematics_TheoremList.Docfile(Application.StartupPath + "DinhLyToanHoc.txt");
            Mathematics_Theorem res= Mathematics_TheoremList.Find_Chemistry_Theorem(int.Parse(textBox1.Text));
            listBox1.Items.Clear(); 
            if(res != null) 
            {
                textBox2.Text = "Success";
                listBox1.Items.Add("ID of theorem:" + res.ID);
                listBox1.Items.Add("Name of theorem:" + res.Name);
                string[]arr=res.Description.Split('.');
                for(int i=0;i<arr.Length;i++) 
                {
                    listBox1.Items.Add(arr[i]);
                }
                listBox1.Items.Add("Formula of theorem:");
                string[] arr2 = res.formula.Split('#');
                for(int i=0;i<arr2.Length;i++) 
                {
                    listBox1.Items.Add(arr2[i]);
                }
            }
            else
            {
                listBox1.Items.Clear();
                textBox2.Text = "ERROR";
            }
        }
        static List<Mathematics_Theorem> ds=new List<Mathematics_Theorem>();   
        public void docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath+"DinhLyToanHoc.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        Mathematics_Theorem dinhluat = new Mathematics_Theorem();
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

        private void button2_Click(object sender, EventArgs e)
        {
            docfile();
            listBox1.Items.Clear();
            foreach(Mathematics_Theorem res in ds) 
            {
                textBox2.Text = "Success";
                listBox1.Items.Add("ID of theorem:" + res.ID);
                listBox1.Items.Add("Name of theorem:" + res.Name);
                string[] arr = res.Description.Split('.');
                for (int i = 0; i < arr.Length; i++)
                {
                    listBox1.Items.Add(arr[i]);
                }
                listBox1.Items.Add("Formula of theorem:");
                string[] arr2 = res.formula.Split('#');
                for (int i = 0; i < arr2.Length; i++)
                {
                    listBox1.Items.Add(arr2[i]);
                }
                listBox1.Items.Add("");
            }
        }
    }

}
