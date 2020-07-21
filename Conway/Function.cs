using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway
{
    public partial class Function : Form
    {
        
        public delegate decimal AllCellsFunc(decimal cell);        
        public CaclulationFunctionVM funcParsing = new CaclulationFunctionVM();
        public AllCellsFunc allCellf;
        
        TextBox[] tb = new TextBox[9];
        List<int> Parameters=new List<int>();
        decimal[] innerParameters = new decimal[9];
        string mainFunction = string.Empty;
        public int fieldSize = 0;
        public int scale = 0;
        public Function()
        {
            InitializeComponent();
           
        }

        private void Function_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cellularAutomataDataSet.Common_AnalyticalCA' table. You can move, or remove it, as needed.
            this.common_AnalyticalCATableAdapter.Fill(this.cellularAutomataDataSet.Common_AnalyticalCA);
            int x, y;
            for (int i = 0; i < 9; i++)
            {
                x = (i == 0 || i == 7 || i == 6) ? 0 : (i == 1 || i == 8 || i == 5) ? 30 : 60;
                y = (i == 7 || i == 8 || i == 3) ? 30 : (i == 0 || i == 1 || i == 2) ? 0 : 60;
                panel2.Controls.Add(tb[i] = new TextBox() { Location = new Point(x, y), Width=28 });
            }
            ok.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fieldsizetb.Text != "" && scaletb.Text != "")
            {
                for (int p = 0; p < 9; p++)
                {
                    if (tb[p].Text != "")
                        innerParameters[p] = Convert.ToDecimal(tb[p].Text);
                    else
                        innerParameters[p] = 0;

                }
                allCellf = new AllCellsFunc(funcParsing.FunctionForAllParsed(CalcFunctionCB.SelectedValue.ToString()));
                fieldSize = Convert.ToInt32(fieldsizetb.Text);
                scale = Convert.ToInt32(scaletb.Text);
                ok.Enabled = true;
            }
            else
            {
                fieldSizeEmpty.Text = fieldsizetb.Text != "" ? "" : "*Field size is required";
                ScaleEmpty.Text = scaletb.Text != "" ? "" : "*Scale is required";
            }
            //mainFunction = allCellf;
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }
        public List<int> GetFunc()
        {            
            return Parameters;
        }
        public decimal[] innerFunc()
        {
            return innerParameters;
        }
        public string MainFunction()
        {
            return mainFunction;
        }
        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ResetCBData()
        {            
            this.commonAnalyticalCABindingSource.ResetBindings(true);
            CalcFunctionCB.Refresh();
        }

        private void AddNewFunctionBtn_Click(object sender, EventArgs e)
        {

            AddNewFunction addFuncForm = new AddNewFunction(this);
            addFuncForm.Show();
        }

        //private void tentCB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (logisticCB.Checked)
        //        logisticCB.Checked = false;
        //}

        //private void logisticCB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (tentCB.Checked)
        //        tentCB.Checked = false;
        //}
    }
}
