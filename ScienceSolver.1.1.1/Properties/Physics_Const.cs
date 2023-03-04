using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Physics_Const
    {
        private int iID;
        private string sSign;
        private string sName;
        private string sDescription;
        private string sValue;
        private string sUnit;
        private Physics_Const next;// node
        ~Physics_Const() { }
        public Physics_Const()
        {
            this.next = null;
        }
        public Physics_Const(int ID, string Sign, string sName, string sDescription, string sValue, string Unit, Physics_Const next)
        {
            this.iID = ID;
            this.sSign = Sign;
            this.sName = sName;
            this.sDescription = sDescription;// Save type of value
            this.sValue = sValue;
            this.sUnit = Unit;
            this.next = next;
        }
        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }
        public string Sign
        {
            get { return this.sSign; }
            set { this.sSign = value; }
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
        public string Value
        {
            get { return this.sValue; }
            set { this.sValue = value; }
        }
        public string Unit
        {
            get { return this.sUnit; }
            set { this.sUnit = value; }
        }
        public Physics_Const Nodenext
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
