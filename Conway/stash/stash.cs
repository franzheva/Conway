using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.stash
{
    class stash
    {
        public double Piecewise(double x, int j, double limitParameter)
        {
            //Piecewise function for Tent map
            double piece = 0;
            if (j == 0)
            {
                if (x >= limitParameter - 1 && x <= limitParameter)
                {
                    piece = x - limitParameter - 1;
                }
                else if (x >= 0 && x <= 1)
                {
                    piece = 1 - x;
                }
            }
            else
            {
                if (x > (j - 1) && x < j)
                {
                    piece = x - j + 1;
                }
                else if (x >= j && x <= j + 1)
                {
                    piece = j - x + 1;
                }
            }
            return piece;
        }
    }
}
