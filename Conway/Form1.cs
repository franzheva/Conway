using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Conway
{

    public partial class Form1 : Form
    {


        public int HeightField = 0; // field size  
        public int WidthField = 0;
        public int iteration = 0;
        public int Tcycle = 30;
        public decimal Tetta = 512.0m;
           
        //public decimal population = 0.0m;
        //public decimal avrPopulation = 0.0m;
        //public decimal tcyclePopulation = 0.0m;
        //public List<decimal> populationStatistic = new List<decimal>();
        //public List<populationTCycleStatisticVM> populationTCycleStatistic = new List<populationTCycleStatisticVM>();
        Function f;
        public int N1 = 0;        

       // ControlSettings cs = new ControlSettings();
        private List<CellStateVectorVM[,]> Cell;
        CellStateVectorVM[,] SetInit;

        public bool isFirstLaunch = true;

        public bool isControl = false;

        PictureBox pictureBox1 = new PictureBox();
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
            DrawingPanel.Location = new System.Drawing.Point(0, PanelForSettings.Height);
            DrawingPanel.Width = this.Width;
            DrawingPanel.Height = this.Height - PanelForSettings.Height;

        }
        public CellStateVectorVM[,] Epidemia(CellStateVectorVM[,] ArrayStart)
        {
            //Algorithm of Cellular Automata Game 2D
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            //var ret = new CellStateVectorVM[HeightField, WidthField];
            //decimal[] inF = f.innerParameters;
            //decimal incode = 0;
            //decimal[] weightCoefficient = new decimal[inF.Length];
            //var retI = new decimal[HeightField, WidthField];
            //var retS = new decimal[HeightField, WidthField];
            //var retR = new decimal[HeightField, WidthField];

            //for (int i = 0; i < inF.Length; i++)
            //    incode += inF[i];

            //for (int i = 0; i < inF.Length; i++)
            //    weightCoefficient[i] = inF[i] / incode;

            var epidemiaRecalcStart = new CellStateVectorVM[HeightField, WidthField];

            for (int i = 0; i < HeightField; i++)
                for (int j = 0; j < WidthField; j++)
                {
                    epidemiaRecalcStart[i, j] = new CellStateVectorVM()
                    {
                        Infected = (1 - f.epsilon) * ArrayStart[i, j].Infected + f.nu * ArrayStart[i, j].Susceptible * ArrayStart[i, j].Infected,
                        Susceptible = ArrayStart[i, j].Susceptible - f.omega*ArrayStart[i,j].Susceptible - f.nu * ArrayStart[i, j].Susceptible * ArrayStart[i, j].Infected,
                        Recovered = ArrayStart[i, j].Recovered + f.epsilon * ArrayStart[i, j].Infected +f.omega* ArrayStart[i, j].Susceptible
                    };
                    //retI[i, j] = epidemiaRecalcStart[i, j].Infected;
                    //retS[i, j] = epidemiaRecalcStart[i, j].Susceptible;
                    //retR[i, j] = epidemiaRecalcStart[i, j].Recovered;
                }
            //for (int i = 0; i < HeightField; i++)
            //    for (int j = 0; j < WidthField; j++)
            //    {
            //        retI[i, j] = ArrayRecalculated(i, j, weightCoefficient, retI);
            //        retS[i, j] = ArrayRecalculated(i, j, weightCoefficient, retS);
            //        retR[i, j] = ArrayRecalculated(i, j, weightCoefficient, retR);
            //    }
            //for (int i = 0; i < HeightField; i++)
            //    for (int j = 0; j < WidthField; j++)
            //        ret[i, j] = new CellStateVectorVM()
            //        {
            //            Infected = retI[i, j],
            //            Susceptible = retS[i, j],
            //            Recovered = retR[i, j]
            //        };

                    return epidemiaRecalcStart;
        }       
        public decimal ArrayRecalculated(int i, int j, decimal [] innerCode, decimal[,] array)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;
            return Func(
                        innerCode[0] * array[(i - 1) != -1 ? (i-1) : (HeightField - 1), (j - 1) != -1 ? (j-1) : (WidthField - 1)] +
                        innerCode[1] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), j] +
                        innerCode[2] * array[(i - 1) != -1 ? (i - 1) : (HeightField - 1), (j + 1) != WidthField ? (j+1) : 0] +
                        innerCode[7] * array[i, (j - 1) != -1 ? (j - 1) : (WidthField - 1)] +
                        innerCode[3] * array[i, (j + 1) != WidthField ? (j + 1) : 0] +
                        innerCode[6] * array[(i + 1) != HeightField ? (i+1) : 0, (j - 1) != -1 ? (j - 1) : (WidthField - 1)] +
                        innerCode[5] * array[(i + 1) != HeightField ? (i + 1) : 0, j] +
                        innerCode[4] * array[(i + 1) != HeightField ? (i + 1) : 0, (j + 1) != WidthField ? (j + 1) : 0],
                        innerCode[8] == 0 ? array[i, j] : innerCode[8] * array[i, j]
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
            //population = 0.0m;
            //avrPopulation = 0.0m;
            //tcyclePopulation = 0.0m;
            //populationStatistic = new List<decimal>();
            //populationTCycleStatistic = new List<populationTCycleStatisticVM>();
            SetInit = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            Random rand = new Random();

            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)
                {
                    var S = (Convert.ToDecimal(rand.Next(100)) + 1) / 101;
                    var I = (1 - S) / (Convert.ToDecimal(rand.Next(100)) + 1);
                    SetInit[i, j] = new CellStateVectorVM()
                    {                        
                        Susceptible = S,
                        Infected = I,
                        Recovered = 1-(S+I)
                    };
                }
                    
         
           // PopulationCalculation(SetInit);
        }
        public void SetInitialFromImage(CellStateVectorVM [,] init)
        {
            //population = 0.0m;
            //avrPopulation = 0.0m;
            //tcyclePopulation = 0.0m;
            //populationStatistic = new List<decimal>();
            //populationTCycleStatistic = new List<populationTCycleStatisticVM>();
            SetInit = new CellStateVectorVM[f.HeightImg, f.WidthImg];
            for (int i = 0; i < f.HeightImg; i++)
                for (int j = 0; j < f.WidthImg; j++)                
                    SetInit[i, j] = init[i, j];
                
            
           // PopulationCalculation(SetInit);
        }       
        private void Print(CellStateVectorVM[,] A)
        {
            CreateBitmapAtRuntime(A);
        }        
        public void CreateBitmapAtRuntime(CellStateVectorVM[,] A)
        {
            HeightField = f.HeightImg;
            WidthField = f.WidthImg;            
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
                    int colorOfSusceptible = Convert.ToInt32((1 - A[i, j].Susceptible) * 255);
                    int colorOfInfected = Convert.ToInt32((1 - A[i, j].Infected) * 255);
                    int colorOfRecovered = Convert.ToInt32((1 - A[i, j].Recovered) * 255);
                    
                    flagGraphics.FillRectangle(new SolidBrush(Color.FromArgb(colorOfSusceptible, colorOfInfected, colorOfRecovered)), j * scale, i * scale, scale, scale); //(col, col, col) try to (col, 0, 0)
                }
            }
            
            pictureBox1.Image = myAutomataField;

           // myAutomataField.Save($"../../Uploads/logs/{iteration}_iteration.jpg");
            //WriteLog(A);
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
            //population = 0.0m;
            //avrPopulation = 0.0m;
            //tcyclePopulation = 0.0m;       
            
            //if (isControl && N1 > 3)
            //{
            //    Cell.Add(PredicativeControl());                
            //}
            //else
            //{
                Cell.Add(Epidemia(Cell[N1]));
            //}
            N1 += 1;
            IterationLabel.Text = N1.ToString();
            // PopulationCalculation();
            Print(Cell[N1]);

        }
        //public decimal[,] PredicativeControl()
        //{
        //    //let's cycle equals 2 T=2
        //    Tetta = 4.15m*(decimal)Math.Pow(10,7);//(decimal) Math.Pow(2,9);
        //    HeightField = f.HeightImg;
        //    WidthField = f.WidthImg;
        //    //int CAsize = f.fieldSize;
        //    decimal div = 3.0m; decimal Epsilon = 0.000000000001m;           
        //    decimal a1 = Tetta / (1 + Tetta); decimal a2 = 1 / (1 + Tetta);
        //    decimal[,] Xn_predicative = new decimal[HeightField, WidthField];
        //    decimal[,] Xn_predicativeTemporary = Cell[N1];
        //    decimal[,] Xn_controled = new decimal[HeightField, WidthField];

        //    //Calculating for predicative part of control
        //    for (int p = 0; p < Tcycle; p++)
        //    {
        //        Xn_predicative = Life(Xn_predicativeTemporary);
        //        Xn_predicativeTemporary = Xn_predicative;                              
        //    }
        //    //calculating control body for main function

        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {                   
        //           Xn_controled[i, j] = a1 * Cell[N1][i, j] + a2 * Xn_predicative[i, j];                  
        //        }
        //    return Life(Xn_controled);
        //}
        //public decimal[,] FeedBackControl()
        //{
        //    //let's cycle equals 2 T=2
        //    var Xn = Life(Cell[N1]);
        //    var Xn_1 = Life(Cell[N1-1]);
           
        //    HeightField = f.HeightImg;
        //    WidthField = f.WidthImg;

        //    decimal div = 3.0m;             
        //    decimal a1 = 2 / div; decimal a2 = 1 / div;
            
        //    decimal[,] Xn_controled = new decimal[HeightField, WidthField];            
            
        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {
        //            Xn_controled[i, j] = a1 * Xn[i, j] + a2 * Xn_1[i, j];
        //        }
          
        //    return Xn_controled;
        //}
        //public decimal[,] FeedBackControlLinear()
        //{
        //    //let's cycle equals 2 T=2
        //    var Xn = Cell[N1];
        //    var Xn_1 = Cell[N1 - 2];
        //    var Xn_2 = Cell[N1 - 4];
        //    HeightField = f.HeightImg;
        //    WidthField = f.WidthImg;
            
        //    decimal a1 = 0.56m; decimal a2 = 0.33m; decimal a3 = 0.11m;
            
        //    decimal[,] Xn_average = new decimal[HeightField, WidthField];

        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {
        //            Xn_average[i, j] = a1 * Xn[i, j] + a2 * Xn_1[i, j]+a3*Xn_2[i,j];
        //        }           
        //    return Life(Xn_average);
        //}
        //public decimal[,] FeedBackControlSemiLinear()
        //{
        //    //for nonlinear part T=9
        //    var X_nonL = new List<decimal[,]>();
        //    var X_L = new List<decimal[,]>();
        //    var optCoeff = new List<decimal>();

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        X_nonL.Add(Cell[N1 - i * Tcycle+Tcycle]);
        //        X_L.Add(Cell[N1 - i * Tcycle + 1]);
        //    }

        //    optCoeff.Add(0.6327m);
        //    optCoeff.Add(0.1211m);
        //    optCoeff.Add(0.0676m);
        //    optCoeff.Add(0.0466m);
        //    optCoeff.Add(0.0354m);
        //    optCoeff.Add(0.0284m);
        //    optCoeff.Add(0.0237m);
        //    optCoeff.Add(0.02m);
        //    optCoeff.Add(0.0166m);
        //    optCoeff.Add(0.0079m);

        //    //var Xn = Cell[N1];
        //    //var Xn_1 = Cell[N1 - 1* Tcycle];
        //    //var Xn_2 = Cell[N1 - 2* Tcycle];
        //    //var Xn_3 = Cell[N1 - 3* Tcycle];
        //    //var Xn_4 = Cell[N1 - 4* Tcycle];

        //    ////for linear part
        //    //var Xn_0t_1 = Cell[N1-1* Tcycle+1];            
        //    //var Xn_t_1 = Cell[N1 - 2 * Tcycle + 1];
        //    //var Xn_2t_1 = Cell[N1 - 3 * Tcycle + 1];
        //    //var Xn_3t_1 = Cell[N1 - 4 * Tcycle + 1];
        //    //var Xn_4t_1 = Cell[N1 - 5 * Tcycle + 1];

        //    //optimal coefficients
        //    var a1 = 0.7532m;var a2 = 0.1164m;var a3 = 0.0683m;var a4 = 0.0416m;var a5 = 0.0205m;

        //    var gamma = 0.1m; var div = 19.0m;//var T = 3.0m;
        //    //var a1 = (T + 1) / (T + 2); var a2 = 1 / (T + 2);           

        //    HeightField = f.HeightImg;
        //    WidthField = f.WidthImg;            

        //    var Xn_average = new decimal[HeightField, WidthField];
           
        //    var Xn_controled = new decimal[HeightField, WidthField];
            
        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {
        //            for (int k = 0; k < 10; k++)
        //                Xn_average[i, j] += optCoeff[k] * X_nonL[k][i,j]; //a1 * Xn[i, j] + a2 * Xn_1[i, j]+a3 * Xn_2[i, j] + a4 * Xn_3[i, j] + a5 * Xn_4[i, j];
        //        }

        //    var Xl_average = new decimal[HeightField, WidthField];

        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {
        //            for (int k = 0; k < 9; k++)
        //                Xl_average[i, j] += 2 / div * X_L[k][i, j];
        //            Xl_average[i, j] += 1 / div * X_L[9][i, j];
        //        }

        //    var temp = Life(Xn_average);

        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {                

        //            Xn_controled[i, j] = (1 - gamma) * temp[i, j] + gamma * Xl_average[i,j];
        //        }

        //    return Xn_controled;
        //}
        //public decimal[,] FeedBackControlLinearT3()
        //{
        //    //let's cycle equals 3 T=3
        //    var Xn = Cell[N1];
        //    var Xn_1 = Cell[N1 - 3];
        //    var Xn_2 = Cell[N1 - 6];
        //    var Xn_3 = Cell[N1 - 9];
        //    HeightField = f.HeightImg;
        //    WidthField = f.WidthImg;

        //    decimal a1 = 0.639m; decimal a2 = 0.269m; decimal a3 = 0.092m; decimal a4 = 0.0m;

        //    decimal[,] Xn_average = new decimal[HeightField, WidthField];

        //    for (int i = 0; i < HeightField; i++)
        //        for (int j = 0; j < WidthField; j++)
        //        {
        //            Xn_average[i, j] = a1 * Xn[i, j] + a2 * Xn_1[i, j] + a3 * Xn_2[i, j] + a4*Xn_3[i,j];
        //        }           
        //    return Life(Xn_average);
        //} 
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            funcSet.Enabled = false;
            if (isFirstLaunch)
            {
                N1 = 0;
                Cell = new List<CellStateVectorVM[,]>();                
                Print(SetInit);
                Cell.Add(SetInit);
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
            Control_Label.Text = isControl ? "Control is on" : "Control is off";
            Control_Label.ForeColor = isControl ? Color.Green : Color.Red;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelForSettings_Position();
        }
        //public void WriteLog(decimal[,] logArray)
        //{
        //    var CA_dt = new System.Data.DataTable($"iteration_{iteration}");
        //    for (int i = 0; i < WidthField; i++)
        //        CA_dt.Columns.Add();
        //    for (int i = 0; i < HeightField; i++)
        //    {
        //        var dr = CA_dt.NewRow();
        //        //dr[0] = i;
        //        for (int j = 0; j < WidthField; j++)
        //            dr[j] = logArray[i, j];
        //        CA_dt.Rows.Add(dr);
        //    }

        //    var pop_row = CA_dt.NewRow();
        //    pop_row[0] = "Population:";
        //    pop_row[1] = population;
        //    CA_dt.Rows.Add(pop_row);
        //    var wb = new XLWorkbook();
        //    wb.Worksheets.Add(CA_dt).Columns().AdjustToContents();

        //    wb.SaveAs($"../../Uploads/logs/{iteration}_iteration.xlsx");
        //}
        //private void ExportPopDataBtn_Click(object sender, EventArgs e)
        //{
        //    var statistic_dt = new System.Data.DataTable($"iteration_{iteration}");
        //    var Columns = new string[] { "Iteration", "Average Population", "_", "Iteration_", "Tcycle coincides" };
        //    for (int i = 0; i < 5; i++)
        //     statistic_dt.Columns.Add(Columns[i]);                

        //    for (int i = 0; i < N1; i++)
        //    {
        //        var dr = statistic_dt.NewRow();
        //        //dr[0] = i;

        //        dr[0] = i;
        //        dr[1] = populationStatistic[i];
        //        dr[2] = "";
        //        dr[3] = populationTCycleStatistic.Count - i <= 0 ? "" : populationTCycleStatistic[i].iteration.ToString();
        //        dr[4] = populationTCycleStatistic.Count-i<=0 ? "": populationTCycleStatistic[i].population.ToString();

        //        statistic_dt.Rows.Add(dr);
        //    }

        //    var wb = new XLWorkbook();
        //    wb.Worksheets.Add(statistic_dt).Columns().AdjustToContents();

        //    wb.SaveAs($"../../Uploads/logs/{iteration}_populationStatistic.xlsx");
        //}
        //public void PopulationCalculation(decimal [,] Data = null)
        //{
        //    var data = Data ?? Cell[N1];
        //    var dataTcycle = Data ?? (N1 > Tcycle ? Cell[N1 - Tcycle] : null);


        //    for (int i = 0; i < f.HeightImg; i++)
        //        for (int j = 0; j < f.WidthImg; j++)
        //            population += data[i,j];

        //    for (int i = 0; i < f.HeightImg; i++)
        //        for (int j = 0; j < f.WidthImg; j++)
        //            tcyclePopulation += N1 > Tcycle ? Math.Abs(data[i, j] - dataTcycle[i, j]) : 0;

        //    iteration += 1;
        //    avrPopulation = population / (f.HeightImg * f.WidthImg);
        //    tcyclePopulation = tcyclePopulation / (f.HeightImg * f.WidthImg);

        //    populationStatistic.Add(avrPopulation);
        //  //  tcyclePopulation = N1 > Tcycle ? Math.Abs(populationStatistic[N1 - Tcycle] - populationStatistic[N1]) : 0;
        //    if (isControl) { populationTCycleStatistic.Add(new populationTCycleStatisticVM { iteration = N1, population = tcyclePopulation }); }
        //    PopulationLabel.Text = population.ToString();
        //    AveragePopulationLbl.Text = avrPopulation.ToString();
        //    TcycleCoincidenceLbl.Text = tcyclePopulation.ToString();
        //    IterationLabel.Text = iteration.ToString();
        //}
    }
}
