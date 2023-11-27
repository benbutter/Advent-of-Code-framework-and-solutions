using System.Security;
using System.Windows.Forms;
using AOC_2022;

namespace Gui
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();

            var solvers = GetSolvers();

            lstSolvers.DataSource = solvers;

        }

        //need to create a solver runner and pass in filepath and puzzle date - should then return answer
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                UpdateSummary();
            }

        }

        public List<string> GetSolvers()
        {
            Type t = typeof(SolverRunner);
            SolverRunner runner = new SolverRunner();
            List<string> result = new List<string>();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetAssembly(t);


            Type[] types = assembly.GetExportedTypes();
            foreach (Type type in types)
            {
                Type interfacetype = type.GetInterface("ISolver");
                if (interfacetype != null)
                {
                    result.Add(FormatSolverName(type.ToString()));
                }
            }
            return result;

        }

        private string FormatSolverName(string solverName)
        {
            return solverName;
            var split = solverName.Split('.');
            return split.Last();
        }


        private void lstSolvers_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            lblSummary.Text = $"{lstSolvers.Text} will be run with {filePath}";
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            var fact = new SolverFactory(lstSolvers.Text, filePath);

            var solver = fact.CreateSolver();

            lblResult.Text = "Answer: " + solver.GetSolution();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}