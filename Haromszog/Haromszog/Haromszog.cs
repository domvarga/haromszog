using System;

namespace haromszog
{
    public class Haromszog
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Haromszog(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }

        public bool szerkesztheto()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            throw new HaromszogException();
        }

        public double kerulet()
        {
            return a + b + c;
        }

        public double terulet()
        {
            double s = kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double magassag()
        {
            double s = a+b+c;
            return s / 2; 
        }
    }
}
