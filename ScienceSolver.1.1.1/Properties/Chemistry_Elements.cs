using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Chemistry_Elements
    {
        private int iElement_ID;
        private string sChemis_Sign;
        private string sElement_Name;
        private double dElement_Atomic_Mass;
        private string sElement_Configuration;
        private double dElement_Electronegativity;
        private string sElement_Oxidation;
        private Chemistry_Elements next;
        public Chemistry_Elements()
        {
            this.next = null;
        }
        ~Chemistry_Elements()
        {
        }
        public Chemistry_Elements(int Element_ID, string Chemis_Sign, string sElement_Name,
        double dElement_Atomic_Mass, string sElement_Configuration, double dElement_Electronegativity,
        string Element_Oxidation, Chemistry_Elements Next)
        {
            this.iElement_ID = Element_ID;
            this.sChemis_Sign = Chemis_Sign;
            this.sElement_Name = sElement_Name;
            this.dElement_Atomic_Mass = dElement_Atomic_Mass;
            this.sElement_Configuration = sElement_Configuration;
            this.dElement_Electronegativity = dElement_Electronegativity;
            this.sElement_Oxidation = Element_Oxidation;
            this.next = Next;
        }
        public int Element_ID
        {
            get { return this.iElement_ID; }
            set { this.iElement_ID = value; }
        }
        public string Chemis_Sign
        {
            get { return this.sChemis_Sign; }
            set { this.sChemis_Sign = value; }
        }
        public string Element_Name
        {
            get { return this.sElement_Name; }
            set { this.sElement_Name = value; }
        }
        public double Element_Atomic_Mass
        {
            get { return this.dElement_Atomic_Mass; }
            set { this.dElement_Atomic_Mass = value; }
        }
        public string Element_Configuration
        {
            get { return this.sElement_Configuration; }
            set { this.sElement_Configuration = value; }
        }
        public double Electronegativity
        {
            get { return this.dElement_Electronegativity; }
            set { this.dElement_Electronegativity = value; }
        }
        public string Oxidation
        {
            get { return this.sElement_Oxidation; }
            set { this.sElement_Oxidation = value; }
        }
        public Chemistry_Elements NodeNext
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
