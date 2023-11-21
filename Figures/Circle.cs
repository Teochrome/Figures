using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figures
    {
        private double n = 3.14;
        public Circle(double a) : base(a)
        { this.a = a; }
        protected override double Per()
        {
            P = 2 * n * a;
            return P;
        }
        protected override double Plosh()
        {
            S = n * Math.Pow(a, 2);
            return S;
        }
    }
}