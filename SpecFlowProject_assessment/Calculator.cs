using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_assessment
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Mult()
        {
            int res;
            res = Fnum * Snum;
            return res;
        }
        public int Sub()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }
        public int Div()
        {
            int res;
            res = Fnum / Snum;
            return res;
        }
    }
}
