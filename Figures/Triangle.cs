using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figures
    {
        private double half_P;
        protected double h;
        public Triangle(double a, double b) : base(a, b)
        { this.a = a; this.b = b; }
        public Triangle(double a, double b, double c) : base(a, b, c)
        { this.a = a; this.b = b; this.c = c; }
        public override void Actions()
        {
            Existence();
            Per();
            Plosh();
            Result();
        }
        protected virtual void Existence()
        {
            if (a > (b + c) || b > (c + a) || c > (a + b) || (a + b) == c || (a + c) == b || (b + c) == a)
            {
                Console.WriteLine("Такого треугольника не существует\n");
                tr_cin();
            }
        }
        protected virtual void tr_cin()
        {
        cin:
            Console.WriteLine("Введите стороны а, b и с: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a > (b + c) || b > (c + a) || c > (a + b) || (a + b) == c || (a + c) == b || (b + c) == a)
            {
                Console.WriteLine("Такого треугольника не существует\n");
                goto cin;
            }
        }
        protected override double Per()
        {
            P = a + b + c;
            half_P = P;
            return P;
        }
        protected override double Plosh()
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2))
            {
                if (a == b && b == c && a == c)
                {
                    S = Math.Pow(a, 2) * Math.Sqrt(3) / 4;
                }
                else if (a == b && a != c && b != c)
                {
                    a1 = a;
                    a2 = c;
                }
                else if (a == c && a != b && b != c)
                {
                    a1 = a;
                    a2 = b;
                }
                else if (b == c && a != c && a != b)
                {
                    a1 = b;
                    a2 = a;
                }
                h = Math.Sqrt(Math.Pow(a1, 2) - Math.Pow(a2 / 2, 2));
                S = 0.5 * a2 * h;
            }
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) || a != b && b != c && a != c)
            {
                half_P /= 2;
                S = Math.Sqrt(half_P * (half_P - a) * (half_P - b) * (half_P - c));
            }
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                S = 0.5 * (a * b);
            }
            return S;
        }
    }
}