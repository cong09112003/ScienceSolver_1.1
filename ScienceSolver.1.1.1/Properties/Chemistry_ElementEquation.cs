using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Chemistry_ElementsEquation
    {
        // fields
        private string sPrecursors;
        private string sChemist_Equation;
        private Chemistry_ElementsEquation next;
        // properties
        public string Precursors
        {
            get { return this.sPrecursors; }
            set { this.sPrecursors = value; }
        }
        public string Chemist_Equation
        {
            get { return this.sChemist_Equation; }
            set { this.sChemist_Equation = value; }
        }
        public Chemistry_ElementsEquation Nodenext
        {
            get { return this.next; }
            set { this.next = value; }
        }
        // Constructor
        public Chemistry_ElementsEquation()
        {
            this.Precursors = "";
            this.Nodenext = null;
        }
        public Chemistry_ElementsEquation(string pre, string equa, Chemistry_ElementsEquation next)
        {
            this.sPrecursors = pre;
            this.Chemist_Equation = equa;
            this.Nodenext = next;
        }

        ~Chemistry_ElementsEquation()
        { }
    }
}
