using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Physics_Formula
    {
        private int sID;
        private string sName;
        private string sDescription;
        private string sFormula;
        private Physics_Formula next;
        ~Physics_Formula() { }
        public Physics_Formula()
        {
            this.next = null;
        }
        public Physics_Formula(int ID, string Name, string Description, string Formula, Physics_Formula Nodenext)
        {
            this.sID = ID;
            this.sName = Name;
            this.sDescription = Description;
            this.sFormula = Formula;
            this.next = Nodenext;
        }
        public int ID
        {
            get { return this.sID; }
            set { this.sID = value; }
        }
        public string Name
        {
            get { return this.sName; }
            set { this.sName = value; }
        }
        public string Description
        {
            get { return this.sDescription; }
            set { this.sDescription = value; }
        }
        public string Formula
        {
            get { return this.sFormula; }
            set { this.sFormula = value; }
        }
        public Physics_Formula NodeNext
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
