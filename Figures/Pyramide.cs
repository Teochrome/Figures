using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Pyramide : Triangle
    {
        protected double V;
        protected double side_S;
        protected double osn_S;
        public Pyramide(double a, double b) : base(a, b)
        { this.a = a; this.b = b; }
        public override void Actions()
        {
            Existence();
            Per();
            Plosh();
            Ob();
            Result();
        }
        protected override void Result()
        {
            Console.WriteLine($"\nАпофема пирамиды: {Math.Round(apopheme, 3)}\n");
            Console.WriteLine($"Периметр пирамиды: {P}\n");
            Console.WriteLine($"Площадь пирамиды: {Math.Round(S, 3)}\n");
            Console.WriteLine($"Объём пирамиды: {Math.Round(V, 3)}\n");
        }
        protected double apopheme_calc()
        {
            apopheme = Math.Sqrt(Math.Pow(b, 2) - Math.Pow((a / 2), 2));
            return apopheme;
        }
        protected override void tr_cin()
        {
        cin:
            Console.WriteLine("Введите основание и боковое ребро правильной пирамиды: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = b;
            if (a > (b + c) || b > (c + a) || c > (a + b) || (a + b) == c || (a + c) == b || (b + c) == a)
            {
                Console.WriteLine("Такой пирамиды не существует\n");
                goto cin;
            }
        }
        protected override void Existence()
        {
            c = b;
            if (a > (b + c) || b > (c + a) || c > (a + b) || (a + b) == c || (a + c) == b || (b + c) == a)
            {
                Console.WriteLine("Такой пирамиды не существует\n");
                tr_cin();
            }
        }
        protected override double Per()
        {
            P = 4 * (a + b);
            return P;
        }
        protected virtual double side_S_calc()
        {
            side_S = 0.5 * a * 4 * apopheme_calc();
            return side_S;
        }
        protected virtual double osn_S_calc()
        {
            osn_S = a * a;
            return osn_S;
        }
        protected override double Plosh()
        {
            S = side_S_calc() + osn_S_calc();
            return S;
        }
        protected double Visota()
        {
            h = Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a / 2, 2) * 2);
            return h;
        }
        protected virtual double Ob()
        {
            V = Visota() / 3 * osn_S;
            return V;
        }
    }
}