using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Figures
    {
        public Square(double a) : base(a)
        {
            this.a = a;
        }
        protected override double Per()
        {
            P = a * 4;
            return P;
        }
        protected override double Plosh()
        {
            S = a * a;
            return S;
        }
    }
}