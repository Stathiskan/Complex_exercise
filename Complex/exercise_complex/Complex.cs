using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public double Re { get; private set; }
        public double Im { get; private set; }
        public Complex(double x, double y)
        {
            Re = x;
            Im = y;
        }
        public static double Norm(Complex a)
        {
            double norm = Math.Sqrt(Math.Pow(a.Re, 2) + Math.Pow(a.Im, 2));
            return norm;
        }
        public static Complex Add(Complex a, Complex b)
        {
            double r = a.Re + b.Re;
            double i = a.Im + b.Im;
            return new Complex(r, i);
        }
        public static Complex Mult(Complex a, Complex b)
        {
            double r = (a.Re * b.Re) - (a.Im * b.Im);
            double i = (a.Re * b.Im) + (a.Im * b.Re);
            return new Complex(r, i);
        }
        public static Complex Add(Complex c, double e)
        {
            double m = c.Re + e;
            double n = c.Im;
            return new Complex(m, n);
        }
        public static Complex Sub(Complex a, Complex b)
        {
            double r = a.Re - b.Re;
            double i = a.Im - b.Im;
            return new Complex(r, i);
        }
        public static Complex Div(Complex a, Complex b)
        {
            if (b.Re != 0 || b.Im != 0)
            {
                double r = ((a.Re * b.Re) + (a.Im * b.Im)) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
                double i = ((b.Re * a.Im) - (a.Re * b.Im)) / (Math.Pow(b.Re, 2) + Math.Pow(b.Im, 2));
                return new Complex(r, i);
            }
            else { throw new Exception("denominator can't be zero"); }
        }
        public override string ToString()
        {
            if (Im >= 0)
                return $"{Re}+{Im}i";
            else return $"{Re}{Im}i";
        }
    }
}




















