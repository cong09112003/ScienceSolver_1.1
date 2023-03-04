using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Mathematics_Formula
    {
        private string sArea;
        private string sID;
        private string sName_For;
        private string sFormula;
        private Mathematics_Formula next;
        ~Mathematics_Formula() { }
        public override string ToString()
        {
            return "Area: " + sArea + "\n" + "ID: " + sID + "\n" + "Name Formula:" + sName_For + "\n" + "Formula:" + sFormula;
        }
        public string Area
        {
            get { return this.sArea; }
            set { this.sArea = value; }
        }
        public string ID
        {
            get { return this.sID; }
            set { this.sID = value; }
        }
        public string Name_For
        {
            get { return this.sName_For; }
            set { this.sName_For = value; }
        }
        public string Formula
        {
            get { return this.sFormula; }
            set { this.sFormula = value; }
        }
        public Mathematics_Formula NodeNext
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Mathematics_Formula()
        {
            this.next = null;
        }
        public Mathematics_Formula(string sArea, string sID, string sName_For, string sFormula, Mathematics_Formula next)
        {
            this.sArea = sArea;
            this.sID = sID;
            this.sName_For = sName_For;
            this.sFormula = sFormula;
            this.next = next;
        }
    }
}
