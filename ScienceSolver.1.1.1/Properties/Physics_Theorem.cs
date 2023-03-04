using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Physics_Theorem
    {
        private int sID;
        private string sName;
        private string sDescription;
        private string sformula;
        private Physics_Theorem next;
        ~Physics_Theorem() { }
        public Physics_Theorem()
        {
            this.next = null;
        }

        public Physics_Theorem(int ID, string Name, string Description, string Fomula, Physics_Theorem Nnext)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.formula = Fomula;
            this.NodeNext = Nnext;
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
            set
            {
                this.sDescription = value;
            }
        }
        public string formula
        {
            get { return this.sformula; }
            set
            {
                this.sformula = value;
            }
        }
        public Physics_Theorem NodeNext
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
