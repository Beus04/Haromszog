using System;
using System.Collections.Generic;
using System.Text;

namespace Haromszog
{
    public class Haromszog
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;

        public Haromszog(int aoldal, int boldal, int coldal)
        {
            a = aoldal;
            b = boldal;
            c = coldal;
        }

        public int Kerulet()
        {
            return a + b + c;       
        }

        public double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }
}
