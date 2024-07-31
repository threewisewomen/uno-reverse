using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class Fields
    {
        public double A { get; set; }
        public double M { get; set; }
        public double N { get; set; }
        public Fields(double a, double m)
        {
            A = a;
            M = m;
        }
        public Fields(double a, double m, double n)
        {
            A = a;
            M = m;
            N = n;
        }
        public static double SinglePower(Fields f)
        {
            return (Math.Pow(f.A, f.M));
        }

        public static double DoublePower(Fields ff)
        {
            return (Math.Pow(Math.Pow(ff.A, ff.M), ff.N));
        }
        public static double MultiplyAndPower(Fields fff)
        {
            return Math.Pow(fff.A * fff.M, fff.N);
        }
        public static double SinglePowerLoop(Fields ffff)
        {
            double pow = 1;
            for (int i = 0; i < ffff.M; i++)
            {
                pow *= ffff.A;
            }
            return pow;
        }
        public static double DoublePowerLoop(Fields fffff)
        {
            double pow = 1;
            for (int j = 0; j < fffff.M * fffff.N; j++)
            {
                pow *= fffff.A;
            }
            return pow;
        }
        public static double MultipleAndPowerLoop(Fields fffff)
        {
            double pow = 1;
            double poww = 1;
            for (int i = 0; i < fffff.N; i++)
            {
                pow *= fffff.A;
            }
            for (int i = 0; i < fffff.N; i++)
            {
                poww *= fffff.M;
            }
            return pow * poww;
        }
    }
}
