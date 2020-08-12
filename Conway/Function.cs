using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway
{
    public partial class Function : Form
    {
        
        public delegate decimal AllCellsFunc(decimal x, decimal y);        
        public CaclulationFunctionVM funcParsing = new CaclulationFunctionVM();
        public AllCellsFunc allCellf;
        private readonly Form1 mainForm;
        TextBox[] tb = new TextBox[9];
       
        public decimal[] innerParameters = new decimal[9];
        public bool currentSeparate = false;
        public int Height = 0;
        public int Width = 0;
        public int scale = 0;

        bool initFromImage = false;
        public Function(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
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
            if (fieldsizeHeighttb.Text != "" && fieldsizeWidthtb.Text != "" && scaletb.Text != "")
            {
                for (int p = 0; p < 9; p++)
                {
                    if (tb[p].Text != "")
                        innerParameters[p] = Convert.ToDecimal(tb[p].Text);
                    else
                        innerParameters[p] = 0;

                }
                allCellf = new AllCellsFunc(funcParsing.FunctionForAllParsed("return 4*(1-0.5m*y)*x*(1-x);"));//CalcFunctionCB.SelectedValue.ToString()
                Height = Convert.ToInt32(fieldsizeHeighttb.Text);
                Width = Convert.ToInt32(fieldsizeWidthtb.Text);
                scale = Convert.ToInt32(scaletb.Text);
                ok.Enabled = true;
            }
            else
            {
                fieldSizeEmpty.Text = fieldsizeHeighttb.Text != "" && fieldsizeWidthtb.Text != "" ? "" : "*Field size is required";
                ScaleEmpty.Text = scaletb.Text != "" ? "" : "*Scale is required";
            }           
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            fieldsizeHeighttb.ReadOnly = false;
            fieldsizeHeighttb.Text = "Height";
            fieldsizeHeighttb.ForeColor = Color.DarkGray;
            Height = 0;

            fieldsizeWidthtb.ReadOnly = false;
            fieldsizeWidthtb.Text = "Width";
            fieldsizeWidthtb.ForeColor = Color.DarkGray;
            Width = 0;

            scaletb.Text = "";
            scale = 0;

            for (int i = 0; i < 9; i++)
                tb[i].Text = "";

            ResetCBData();
        }
       
        private void ok_Click(object sender, EventArgs e)
        {
            if (initFromImage)
            {
                MessageBox.Show("Initial Data uploaded from image will be applied");
            }
            else
            {
                MessageBox.Show("Random Initial Data will be applied");
                mainForm.SetInitial();
            }
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

        private void UploadInit_btn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            ImageData(Upload(openFileDialog.FileName));            
        }
        private string Upload(string fileName)
        {           
            try
            {
                var data = File.ReadAllBytes(fileName);
                using (FileStream fcreate = File.Open(fileName, FileMode.Create))
                {
                    fcreate.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fileName;
        }
        public void ImageData(string path)
        {
            if (path != "")
            {
                var image = new Bitmap(path);
                Height = image.Height;
                Width = image.Width;
                var initData = new decimal[Height, Width];
                fieldsizeHeighttb.Text = Height.ToString();
                fieldsizeHeighttb.ReadOnly = true;
                fieldsizeWidthtb.Text = Width.ToString();
                fieldsizeWidthtb.ReadOnly = true;
                scale = 1;
                scaletb.Text = scale.ToString();
                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                        initData[i, j] = 1 - ((decimal)image.GetPixel(j, i).R) / 255;

                mainForm.SetInitialFromImage(initData);
                initFromImage = true;
            }
        }

        private void FieldsizeHeighttb_MouseDown(object sender, MouseEventArgs e)
        {
            fieldsizeHeighttb.Text = "";
            fieldsizeHeighttb.ForeColor = Color.Black;
        }

        private void FieldsizeWidthtb_MouseDown(object sender, MouseEventArgs e)
        {
            fieldsizeWidthtb.Text = "";
            fieldsizeWidthtb.ForeColor = Color.Black;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (useCurrentAsSeparate.Checked)
            {
                tb[8].Text = "1";
                tb[8].ReadOnly = true;
                currentSeparate = true;
            }
            else {
                tb[8].Text = "";
                tb[8].ReadOnly = false;
                currentSeparate = false;
            }
        }
    }    
}
