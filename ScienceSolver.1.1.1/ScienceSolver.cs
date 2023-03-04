namespace ScienceSolver._1._1._1
{
    public partial class ScienceSolver : Form
    {
        public ScienceSolver()
        {
            InitializeComponent();
        }

        private void Mathematics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mathematics math = new Mathematics();
            math.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physics phy = new Physics();
            phy.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chemistry chemistry= new Chemistry();
            chemistry.ShowDialog();
            this.Show();
        }

        private void ScienceSolver_Load(object sender, EventArgs e)
        {

        }

        private void searchingMathematicalFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingMathFormula form= new SearchingMathFormula();
            form.ShowDialog();
            this.Show();
        }

        private void searchingMathematicalTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Mathematics_Theorem form1=new Searching_Mathematics_Theorem();
            form1.ShowDialog();
            this.Show() ;
        }

        private void searchingPhysicsConstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Physical_Constant form2=new Searching_Physical_Constant();
            form2.ShowDialog();
            this.Show();
        }

        private void searchingPhysicalLawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Physics_Theorem form3=new Searching_Physics_Theorem();
            form3.ShowDialog();
            this.Show() ;
        }

        private void searchingPhysicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingPhysicalFormula form4=new SearchingPhysicalFormula();
            form4.ShowDialog();
            this.Show() ;
        }

        private void searchingChemisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalElements form5 =new SearchingChemicalElements();    
            form5.ShowDialog();
            this.Show() ;
        }

        private void searchingChemicalEquationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalEquations form6=new SearchingChemicalEquations();
            form6.ShowDialog();
            this.Show();
        }

        private void searchingChemicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalConst form7=new SearchingChemicalConst();
            form7.ShowDialog();
            this.Show() ;
        }

        private void mathematicalBasicalCalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasicCalculate bs=new BasicCalculate();
            bs.ShowDialog();
            this.Show() ;
        }

        private void mathematicalHighLevelCalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            HighLevelCalculate hv=new HighLevelCalculate(); 
            hv.ShowDialog();
            this.Show() ;
        }

        private void mathematicalSolvingEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equations_Solving Es= new Equations_Solving();  
            Es.ShowDialog();
            this.Show() ;
        }

        private void mathematicalSolvingEquationDegree1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_FirstDegree g1=new Equation_FirstDegree();
            g1.ShowDialog();
            this.Show() ;
        }

        private void mathematicsSolvingEquationDegree2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_SecondeDegree g2=new Equation_SecondeDegree();
            g2.ShowDialog();
            this.Show();
        }

        private void mathematicsSolvingEquationDegree3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_ThirdDegree g3=new Equation_ThirdDegree(); 
            g3.ShowDialog();
            this.Show();
        }

        private void mathematicsSolvingEquationDegree2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_FourthDegree g4=new Equation_FourthDegree();
            g4.ShowDialog();
            this.Show();
        }

        private void mathematicalSolvingSystemOfEquationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquation_2 s2=new SystemOfEquation_2();
            s2.ShowDialog();
            this.Show();
        }

        private void mathematicalSolvingEquationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquation s=new SystemOfEquation();
            s.ShowDialog();
            this.Show();
        }

        private void mathematicalSolvingSystemOfEquationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquations_3 s3=new SystemOfEquations_3();
            s3.ShowDialog();
            this.Show();
        }

        private void mathematicalSolvingSystemOfEquationsStep4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquations_4 s4= new SystemOfEquations_4();  
            s4.ShowDialog();
            this.Show();
        }

        private void mathematicalSearchingFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingMathFormula formula=new SearchingMathFormula();
            formula.ShowDialog();
            this.Show();
        }

        private void mathematicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Mathematics_Theorem k=new Searching_Mathematics_Theorem();
            k.ShowDialog();
            this.Show();
        }

        private void physicalExchangingUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicExchangeUnits U=new PhysicExchangeUnits();
            U.ShowDialog();
            this.Show();
        }

        private void physicalSearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Physical_Constant M=new Searching_Physical_Constant();    
            M.ShowDialog();
            this.Show();
        }

        private void physicalSearchingFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingPhysicalFormula L=new SearchingPhysicalFormula();
            L.ShowDialog();
            this.Show();
        }

        private void physcialSearchingTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Physics_Theorem O=new Searching_Physics_Theorem();
            O.ShowDialog();
            this.Show();
        }

        private void chemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalElements T=new SearchingChemicalElements();
            T.ShowDialog();
            this.Show();
        }

        private void chemicalSearchingEquationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalEquations W=new SearchingChemicalEquations();
            W.ShowDialog();
            this.Show();
        }

        private void chemicalSearchingConstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingChemicalConst B=new SearchingChemicalConst();
            B.ShowDialog();
            this.Show();
        }

        private void chemicalSearchingTheoremsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Chemical_Theorem C = new Searching_Chemical_Theorem();
            C.ShowDialog();
            this.Show();
        }

        private void introduceScienceSolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introduce_ScienceSolver k=new Introduce_ScienceSolver();
            k.ShowDialog();
            this.Show() ;
        }

        private void introduceUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introduce_ScienceSolver_Usage k = new Introduce_ScienceSolver_Usage();
            k.ShowDialog();
            this.Show() ;
        }

        private void mathematicalCalculateMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculating_Matrix k=new Calculating_Matrix();
            k.ShowDialog();
            this.Show() ;
        }

        private void mathematicalCalculatingVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vector v = new Vector();
            v.ShowDialog();
            this.Show();
        }

        private void cHEMISTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}