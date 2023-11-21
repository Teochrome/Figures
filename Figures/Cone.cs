using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Cone : Pyramide
    {
        private double n = 3.14;
        public Cone(double a, double b) : base(a, b)
        { this.a = a; this.b = b; }
        public override void Actions()
        {
            Plosh();
            Ob();
            Result();
        }
        protected override double osn_S_calc()
        {
            osn_S = n * Math.Pow(a, 2);
            return osn_S;
        }
        protected override double side_S_calc()
        {
            side_S = n * a * Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return side_S;
        }
        protected override double Ob()
        {
            V = osn_S / 3 * b;
            return V;
        }
        protected override void Result()
        {
            Console.WriteLine($"\nПлощадь конуса: {Math.Round(S, 3)}\n");
            Console.WriteLine($"Объём конуса: {Math.Round(V, 3)}\n");
        }
    }
}