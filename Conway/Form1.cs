using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Conway
{

    public partial class Form1 : Form
    {


        public int HeightField = 0; // field size  
        public int WidthField = 0;
        public int iteration = 0;
        Function f;
        public int N1 = 0;        

        ControlSettings cs = new ControlSettings();
        private List<decimal[,]> Cell;
        decimal[,] SetInit;

        public bool isFirstLaunch = true;

        public bool isControl = false;
        public Form1()
        {
            InitializeComponent();
            f = new Function(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
        public void PanelForSettings_Position()
        {            
            PanelForSettings.Width = this.Width;
            DrawingPanel.Location = new Point(0, PanelForSettings.Height);
            DrawingPanel.Width = this.Width;
            DrawingPanel.Height = this.Height - PanelForSettings.Height;

        }
        public decimal[,] Life(decimal[,] ArrayStart)
        {
            //Algorithm of Cellular Automata Game 2D
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            decimal[,] ret = new decimal[HeightField, WidthField];
            decimal[] inF = f.innerParameters;           
            decimal incode = 0;            
            decimal[] weightCoefficient = new decimal[inF.Length];
            for (int i = 0; i < inF.Length; i++)
                incode += inF[i];
            for (int i = 0; i < inF.Length; i++)
                weightCoefficient[i] = inF[i]/incode;
            for (int i = 0; i < HeightField; i++)
            {
                for (int j = 0; j < WidthField; j++)

                {
                    ret[i, j] = ArrayRecalculated(i, j, weightCoefficient, ArrayStart);
                }
            }
            return ret;
        }
       
        public decimal ArrayRecalculated(int i, int j, decimal [] innerCode, decimal[,] array)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            //K = f.fieldSize;
            return Func(
                        innerCode[0] * array[(i - 1) != -1 ? (i-1) : (HeightField - 1), (j - 1) != -1 ? (j-1) : (WidthField - 1)] +
                        innerCode[1] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), j] +
                        innerCode[2] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), (j + 1) != WidthField ? (j+1) : 0] +
                        innerCode[7] * array[i, (j - 1) != -1 ? (j - 1) : (WidthField - 1)] +
                        innerCode[3] * array[i, (j + 1) != WidthField ? (j + 1) : 0] +
                        innerCode[6] * array[(i + 1) != HeightField ? (i+1) : 0, (j - 1) != -1 ? (j - 1) : (WidthField - 1)] +
                        innerCode[5] * array[(i + 1) != HeightField ? (i + 1) : 0, j] +
                        innerCode[4] * array[(i + 1) != HeightField ? (i + 1) : 0, (j + 1) != WidthField ? (j + 1) : 0],
                        innerCode[8] * array[i, j]
                        );
        }
        public decimal Func(decimal y, decimal x)
        {
            var mainFunction = f.allCellf;
            x = f.currentSeparate ? x : x + y;         
            return mainFunction(x,y);            
        }
       
        public void SetInitial()
        {
            // K = f.fieldSize; 
            SetInit = new decimal[f.HeightImg, f.WidthImg];
            Random rand = new Random();
            int x, x1, x2, y, y1, y2;
            for (int i = 0; i < f.HeightImg * f.WidthImg; i++)
            {
                x1 = rand.Next(f.HeightImg);
                x2 = rand.Next(f.HeightImg);
                x = (x1 + x2) / 2;
                y1 = rand.Next(f.WidthImg);
                y2 = rand.Next(f.WidthImg);
                y = (y1 + y2) / 2;
                SetInit[x, y] = 0.75m;//Convert.ToDecimal(rand.Next(100)) / 100;

            }
            // планер в игре Жизнь
            //SetInit[0, 1] = 1;
            //SetInit[1, 2] = 1;
            //SetInit[2, 0] = 1;
            //SetInit[2, 1] = 1;
            //SetInit[2, 2] = 1;
            //Print(SetInit);

            //return SetInit;
        }
        public void SetInitialFromImage(decimal [,] init)
        {
            SetInit = new decimal[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                    SetInit[i, j] = init[i, j];
        }
       
        private void Print(decimal[,] A)
        {
            CreateBitmapAtRuntime(A);
        }

        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime(decimal[,] A)
        {

            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            //K = f.fieldSize;
            var scale = f.scale;
            
            pictureBox1.Size = new Size(WidthField * scale + 10, HeightField * scale + 10);
            //this.Controls.Add(pictureBox1);
            DrawingPanel.Controls.Add(pictureBox1);
            Bitmap myAutomataField = new Bitmap(WidthField * scale,  HeightField * scale);
            Graphics flagGraphics = Graphics.FromImage(myAutomataField);
            for (int j = 0; j < WidthField; j++) 
            {
                for (int i = 0; i < HeightField; i++)
                {
                    int col = Convert.ToInt32((1 - A[i, j]) * 255); //Math.Abs(1 - A[j, i]) old version
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(col, col, col)), j * scale, i * scale, scale, scale); //(col, col, col) try to (col, 0, 0)
                }
            }
            
            pictureBox1.Image = myAutomataField;
            
            myAutomataField.Save($"../../Uploads/{iteration}_iteration.jpg");
        }
        private void funcSet_Click(object sender, EventArgs e)
        {
            startTimerButton.Enabled = true;           
            f = new Function(this);                
            f.Show();           
        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            var population = 0.0m;
           // K = f.fieldSize;
            decimal[,] h = new decimal[HeightField, WidthField];
            decimal[,] b = new decimal[HeightField, WidthField];
           
            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    b[i, j] = Cell[N1][i, j];
                    population += b[i, j] ;
                }
            if (isControl && N1>3)
            {
                b = PredicativeControl(b);
            }

            h = Life(b);
            iteration += 1;
            Print(h);

            Cell.Add(h);               
            N1 += 1;
          
            
            PopulationLabel.Text = population.ToString();
            IterationLabel.Text = iteration.ToString();

        }
        public decimal[,] PredicativeControl(decimal[,] Xn)
        {
            //let's cycle equals 2 T=2

            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            //int CAsize = f.fieldSize;
            int Tcycle = 1; decimal div = 3.0m; decimal Epsilon = 0.000000000001m;
            decimal Tetta = 8.0m;//1 / div * (Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(Tcycle + 1))) - 1) + Epsilon; //4.0m;
            decimal a1 = Tetta / (1 + Tetta); decimal a2 = 1 / (1 + Tetta);
            decimal[,] Xn_predicative = new decimal[HeightField, WidthField];
            decimal[,] Xn_predicativeTemporary = Xn;
            decimal[,] Xn_controled = new decimal[HeightField, WidthField];

            //Calculating for predicative part of control
            for (int p = 0; p < Tcycle; p++)
            {
                Xn_predicative = Life(Xn_predicativeTemporary);
                Xn_predicativeTemporary = Xn_predicative;                              
            }
            //calculating control body for main function

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {                   
                   Xn_controled[i, j] = a1 * Xn[i, j] + a2 * Xn_predicative[i, j];                  
                }
            return Xn_controled;
        }

        //Practical implementation todo:
        public decimal PictureCoder(decimal X0)
        {
            decimal alfa = 2 - 1 / X0;
            if (X0 >= 0 && X0 < alfa)
                return X0 / alfa;
            else if (X0 >= alfa && X0 <= 1)
                return (1 - X0) / (1 - alfa);
            else
                return 0;
        }
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = false;
            if (isFirstLaunch)
            {
                N1 = 0;
                Cell = new List<decimal[,]>();
                //var temp = SetInitial();
                Print(SetInit);
                Cell.Add(SetInit);
                //N1 = 0;

                timer1.Enabled = true;
                isFirstLaunch = false;
            }
            timer1.Enabled = true;
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = true;
            timer1.Enabled = false;
        }

        private void Control_btn_Click(object sender, EventArgs e)
        {
            isControl = isControl ? false : true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
    }
}
