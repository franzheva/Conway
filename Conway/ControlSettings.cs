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
    public partial class ControlSettings : Form
    {
        double[] aOptParam;
        double[] bOptParam;
        public ControlSettings()
        {
            InitializeComponent();
        }

        private void SetControl_btn_Click(object sender, EventArgs e)
        {
            int controlDeep = Convert.ToInt32(controlDepth_tb.Text);
            int cycleLength = Convert.ToInt32(cycleLength_tb.Text);
            double sigma1 = Convert.ToDouble(sigma1_tb.Text);
            double sigma2 = Convert.ToDouble(sigma2_tb.Text);
            double gamma = Convert.ToDouble(gamma_tb.Text);
            int K = (controlDeep % 2 != 0) ? (controlDeep - 1) / 2 : (controlDeep - 2) / 2;
            double[,] a = new double[controlDeep + 3, K+1];
            double[,] A1;
            double[] b = new double[controlDeep];
            aOptParam = new double[controlDeep];
            bOptParam = new double[controlDeep];

            // double[] c = new double[controlDeep];
            double c =0;
            a[0, 0] = 0;
            a[1, 0] = 0;
            a[2, 0] = 1;
            a[3, 0] = (-2 * Math.Cos(sigma2));
            a[4, 0] = 1;
            
            double[] Psi = new double[K];
            for (int i = 0; i < K; i++)
                Psi[i] = Math.PI * (sigma1 + (2 * i - 1) * cycleLength) / (sigma2 + (controlDeep - 1) * cycleLength);
            for (int i = 0; i < controlDeep-2; i++)
            {
                a[i + 5, 0] = 0;
                for (int j = 1; j < K; j++)
                {
                    a[0, j] = 0;
                    a[1, j] = 0;
                    a[2, j] = 0;
                    a[3, j] = 0;
                    a[i+2, j] = 0;
                    a[2 * K + 3, j] = 0;
                    a[2 * K + 4, j] = 0;
                }
            }
            for (int i = 0; i < 2 * K; i++)
                for (int j = 0; j < K; j++)
                    a[i+2, j + 1] = a[i+2, j] - 2 * a[i +1, j] * Math.Cos(Psi[j]) + a[i, j];
            if (controlDeep % 2 != 0)
            {
                A1 = new double[K, controlDeep + 4];
                for (int i = 0; i < K; i++)
                    for (int j = 0; j < controlDeep + 4; j++)
                        A1[i, j] = a[j - 1, i];
                for (int l = 0; l < controlDeep; l++)
                    b[l] = (1 - (1 + (l - 1) * cycleLength) / (2 + (controlDeep - 1) * cycleLength)) * A1[K, l + 2];
            }
            else
            {
                A1 = new double[K, controlDeep + 3];
                for (int i = 0; i < K; i++)
                    for (int j = 0; j < controlDeep + 3; j++)
                        A1[i, j] = a[j, i];
                double[] x = new double[controlDeep+1];
                x[0] = A1[K-1, 3];
                for (int i = 0; i < controlDeep - 1; i++)
                    x[i +1] = A1[K-1, i + 3] + A1[K-1, i + 2];
                for(int l=0;l<controlDeep;l++)
                    b[l] = (1 - (1 + (l - 1) * cycleLength) / (2 + (controlDeep - 1) * cycleLength)) * x[l];
            }
            
            for (int i = 0; i < controlDeep; i++)
                c += b[i];
            textBox1.Text += "Aj parameters: \r\n";
            for (int i = 0; i < controlDeep; i++)
            {
                aOptParam[i] = b[i] / c;
                textBox1.Text += aOptParam[i] + "\r\n";
            }
            textBox1.Text += "\r\n Bj parameters: \r\n";
            for (int i = 0; i < controlDeep - 1; i++)
            {
                bOptParam[i] = 2 / (2 * Convert.ToDouble(controlDeep) - 1);
                textBox1.Text += bOptParam[i] + "\r\n";
            }
            bOptParam[controlDeep-1]= 1 / (2 * Convert.ToDouble(controlDeep) - 1);
            textBox1.Text += bOptParam[controlDeep-1];
        }
        public double[] AoptimalParameters()
        {
            return aOptParam;
        }
        public double[] BoptimalParameters()
        {
            return bOptParam;
        }

        private void ControlSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
