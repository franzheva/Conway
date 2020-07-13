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
        CalculationFunction func = new CalculationFunction();
        public delegate decimal AllCellsFunc(decimal cell);       
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
            int x, y;
            for (int i = 0; i < 9; i++)
            {
                x = (i == 0 || i == 7 || i == 6) ? 0 : (i == 1 || i == 8 || i == 5) ? 30 : 60;
                y = (i == 7 || i == 8 || i == 3) ? 30 : (i == 0 || i == 1 || i == 2) ? 0 : 60;
                panel2.Controls.Add(tb[i] = new TextBox() { Location = new Point(x, y), Width=28 });
            }
            FunctionForCellsCB.Text = "decimal d = 17m; if (x >= 5 / d && x <= 7 / d){ return 1; } else{return 0;} ";
            /*
            
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int p=0;p<9;p++)
            {
                if (tb[p].Text != "")
                    innerParameters[p] = Convert.ToDecimal(tb[p].Text);
                else
                    innerParameters[p] = 0;
                textBox1.Text += innerParameters[p].ToString() + " ";
            }
            fieldSize = Convert.ToInt32(fieldsizetb.Text);
            scale = Convert.ToInt32(scaletb.Text);
            allCellf = new AllCellsFunc(func.FunctionForAllParsed(FunctionForCellsCB.Text));
            //mainFunction = tentCB.Checked ? "Tent" : "Logistic";
         }

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 18; i++)
            {
                textBox1.Text = "";
            }

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

        private void tentCB_CheckedChanged(object sender, EventArgs e)
        {
            if (logisticCB.Checked)
                logisticCB.Checked = false;
        }

        private void logisticCB_CheckedChanged(object sender, EventArgs e)
        {
            if (tentCB.Checked)
                tentCB.Checked = false;
        }
    }
}
