using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle_Pyramide : Pyramide
    {
        public Triangle_Pyramide(double a, double b) : base(a, b)
        { this.a = a; this.b = b; }
        protected override double Per()
        {
            P = 3 * (a + b);
            return P;
        }
        protected override double osn_S_calc()
        {
            osn_S = Math.Pow(a, 2) * Math.Sqrt(3) / 4;
            return osn_S;
        }
        protected override double side_S_calc()
        {
            side_S = 0.5 * a * 3 * apopheme_calc();
            return side_S;
        }
        protected override void Result()
        {
            Console.WriteLine($"\nАпофема пирамиды: {Math.Round(apopheme, 3)}\n");
            Console.WriteLine($"Периметр пирамиды: {P}\n");
            Console.WriteLine($"Площадь пирамиды: {Math.Round(S, 3)}\n");
            Console.WriteLine($"Объём пирамиды: {Math.Round(V, 3)}\n");
        }
    }
}