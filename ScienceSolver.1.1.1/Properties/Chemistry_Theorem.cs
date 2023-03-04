using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Chemistry_Theorem
    {
        private int sID;
        private string sName;
        private string sDescription;
        private string sformula;
        public Chemistry_Theorem next;
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
        public Chemistry_Theorem NodeNext
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Chemistry_Theorem()
        {
            this.NodeNext = null;
        }
        ~Chemistry_Theorem()
        { }
        public Chemistry_Theorem(int ID,string Name,string Description,string Fomula,Chemistry_Theorem next)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.formula = Fomula;
            this.NodeNext = next;

        }
    }
}
