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
                MessageBox.Show(ofd.FileName);
                filePath = ofd.FileName;
            }

        }

        public List<Type> GetSolvers()
        {
            Type t = typeof(SolverRunner);
            SolverRunner runner = new SolverRunner();
            List<Type> result = new List<Type>();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetAssembly(t);


            Type[] types = assembly.GetExportedTypes();
            foreach (Type type in types)
            {
                Type interfacetype = type.GetInterface("ISolver");
                if (interfacetype != null)
                {
                    result.Add(type);
                }
            }
            return result;

        }



        private void lstSolvers_SelectedValueChanged(object sender, EventArgs e)
        {
            lblSummary.Text = lstSolvers.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            SolverRunner runner = new SolverRunner();

            runner.injectedPath = filePath;
          //  runner.SolvePuzzle
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}