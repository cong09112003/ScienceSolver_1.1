using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceSolver
{
    public class Chemistry_Const
    {
        private int iID;
        private string sSign;
        private string sName;
        private string sDescription;
        private string sValue;
        private string sUnit;
        private Chemistry_Const Next;
        public Chemistry_Const()
        {
            this.Next = null;
        }
        ~Chemistry_Const()
        { }
        Chemistry_Const(int ID, string Sign, string Name, string Description, string Value, string Unit, Chemistry_Const next)
        {
            this.iID = iID;
            this.sSign = sSign;
            this.sName = sName;
            this.sDescription = sDescription;
            this.sValue = sValue;
            this.sUnit = sUnit;
            this.Next = Next;
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
        public Chemistry_Const Nodenext
        {
            get { return this.Next; }
            set { this.Next = value; }
        }
    }
}
