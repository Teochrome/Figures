using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Figures
    {
        protected double a1, a2;
        protected double S, P, a, b, c, apopheme;
        public Figures(double a)
        { this.a = a; }
        public Figures(double a, double b) : this(b)
        { this.a = a; }
        public Figures(double a, double b, double c) : this(c)
        { this.a = a; this.b = b; }
        public virtual void Actions()
        {
            Per();
            Plosh();
            Result();
        }
        protected virtual double Per()
        {
            return P;
        }
        protected virtual double Plosh()
        {
            return S;
        }
        protected virtual void Result()
        {
            Console.WriteLine($"\nПериметр фигуры: {P}\n");
            Console.WriteLine($"Площадь фигуры: {Math.Round(S, 6)}\n");
        }
    }
}