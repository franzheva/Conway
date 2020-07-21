using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;




namespace Conway
{

    public partial class Form1 : Form
    {

        public int Height = 0; // field size  
        public int Width = 0;
        int N1 = 0;
        Function f = new Function();
        ControlSettings cs = new ControlSettings();
        private List<decimal[,]> Cell;
        decimal[,] SetInit;

        private bool isFirstLaunch = true;
        public bool isControl = false;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }
        public decimal[,] Life(decimal[,] ArrayStart)
        {
            //Algorithm of Cellular Automata Game 2D
            Height = f.Height;
            Width = f.Width;
            decimal[,] ret = new decimal[Height, Width];
            decimal[] inF = f.innerParameters;           
            decimal incode = 0;            
            
            decimal[] weightCoefficient = new decimal[inF.Length];

            for (int i = 0; i < inF.Length; i++)
                incode += inF[i];
            //double limitParameter = incode + 1;
            for (int i = 0; i < inF.Length; i++)
                weightCoefficient[i] = inF[i]/incode;


            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    ret[i, j] = ArrayRecalculated(i, j, weightCoefficient, ArrayStart);
                }
            }
            return ret;
        }
       
        public decimal ArrayRecalculated(int i, int j, decimal [] innerCode, decimal[,] array)
        {
            Height = f.Height;
            Width = f.Width;
            //K = f.fieldSize;
            return Func(
                        innerCode[0] * array[(i - 1) != -1 ? (i-1) : (Height - 1), (j - 1) != -1 ? (j-1) : (Width - 1)] +
                        innerCode[1] * array[(i - 1) != -1 ? (i - 1) : (Height - 1), j] +
                        innerCode[2] * array[(i - 1) != -1 ? (i - 1) : (Height - 1), (j + 1) != Width ? (j+1) : 0] +
                        innerCode[7] * array[i, (j - 1) != -1 ? (j - 1) : (Width - 1)] +
                        innerCode[3] * array[i, (j + 1) != Width ? (j + 1) : 0] +
                        innerCode[6] * array[(i + 1) != Height ? (i+1) : 0, (j - 1) != -1 ? (j - 1) : (Width - 1)] +
                        innerCode[5] * array[(i + 1) != Height ? (i + 1) : 0, j] +
                        innerCode[4] * array[(i + 1) != Height ? (i + 1) : 0, (j + 1) != Width ? (j + 1) : 0] +
                        innerCode[8] * array[i, j]
                        );
        }
        public decimal Func(decimal x)
        {
            var mainFunction = f.allCellf; 
            return mainFunction(x);
        }
       
        public void SetInitial()
        {
           // K = f.fieldSize; 
            Random rand = new Random();
            int x, x1, x2, y, y1, y2;
            for (int i = 0; i < f.Height * f.Width; i++)
            {
                x1 = rand.Next(f.Height);
                x2 = rand.Next(f.Height);
                x = (x1 + x2) / 2;
                y1 = rand.Next(f.Width);
                y2 = rand.Next(f.Width);
                y = (y1 + y2) / 2;
                SetInit[x, y] = 1.0m;//Convert.ToDecimal(rand.Next(100)) / 100;

            }
            // планер в игре Жизнь
            //SetInit[0, 1, 0] = 1;
            //SetInit[1, 2, 0] = 1;
            //SetInit[2, 0, 0] = 1;
            //SetInit[2, 1, 0] = 1;
            //SetInit[2, 2, 0] = 1;
            //Print(SetInit);

            //return SetInit;
        }
        public void SetInitialFromImage(decimal [,] init)
        {
            for (int i = 0; i < f.Height; i++)
                for (int j = 0; j < f.Width; j++)
                    SetInit[i, j] = init[i, j];
        }
       
        private void Print(decimal[,] A)
        {
            CreateBitmapAtRuntime(A);
        }

        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime(decimal[,] A)
        {
            Height = f.Height;
            Width = f.Width;
            //K = f.fieldSize;
            var scale = f.scale;
            pictureBox1.Size = new Size(Height * scale + 10, Width * scale + 10);
            this.Controls.Add(pictureBox1);

            Bitmap myAutomataField = new Bitmap(Height * scale, Width * scale);
            Graphics flagGraphics = Graphics.FromImage(myAutomataField);            
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    int col = Convert.ToInt32((1 - A[i, j]) * 255); //Math.Abs(1 - A[j, i]) old version
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(col, col, col)), i * scale, j * scale, scale, scale); //(col, col, col) try to (col, 0, 0)
                }
            }
            
            pictureBox1.Image = myAutomataField;
        }
        private void funcSet_Click(object sender, EventArgs e)
        {
            startTimerButton.Enabled = true;
            f.Show();
        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
            Height = f.Height;
            Width = f.Width;
           // K = f.fieldSize;
            decimal[,] h = new decimal[Height, Width];
            decimal[,] b = new decimal[Height, Width];
           
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    b[i, j] = Cell[N1][i, j];
                }
            if (isControl && N1>3)
            {
                b = PredicativeControl(b);
            }
           
            h = Life(b);
                        
            Print(h);

            Cell.Add(h);               
            N1 += 1;
        }
        public decimal[,] PredicativeControl(decimal[,] Xn)
        {
            //let's cycle equals 2 T=2
            Height = f.Height;
            Width = f.Width;
            //int CAsize = f.fieldSize;
            int Tcycle = 1; decimal div = 3.0m; decimal Epsilon = 0.000000000001m;
            decimal Tetta = 8.0m;//1 / div * (Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(Tcycle + 1))) - 1) + Epsilon; //4.0m;
            decimal a1 = Tetta / (1 + Tetta); decimal a2 = 1 / (1 + Tetta);
            decimal[,] Xn_predicative = new decimal[Height, Width];
            decimal[,] Xn_predicativeTemporary = Xn;
            decimal[,] Xn_controled = new decimal[Height, Width];

            //Calculating for predicative part of control
            for (int p = 0; p < Tcycle; p++)
            {
                Xn_predicative = Life(Xn_predicativeTemporary);
                Xn_predicativeTemporary = Xn_predicative;                              
            }
            //calculating control body for main function
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
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
            if (isFirstLaunch)
            {
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
            timer1.Enabled = false;
        }

        private void Control_btn_Click(object sender, EventArgs e)
        {
            isControl = isControl ? false : true;
            //cs.Show();
        }
    }
}
