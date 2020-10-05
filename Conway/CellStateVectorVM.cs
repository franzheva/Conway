using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway
{
    public class CellStateVectorVM
    {
        public decimal Susceptible { get; set; }
        public decimal Infected { get; set; }
        public decimal Recovered { get; set; }
    }
}
