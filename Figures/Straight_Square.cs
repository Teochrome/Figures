using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Straight_Square : Figures
    {
        public Straight_Square(double a, double b) : base(a, b)
        { this.a = a; this.b = b; }
        protected override double Per()
        {
            P = (a + b) * 2;
            return P;
        }
        protected override double Plosh()
        {
            S = a * b;
            return S;
        }
    }
}