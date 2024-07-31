using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    internal class RealAnalysis
    {
    }
    class PositiveInteger
    {
        public int Value { get; private set; }
        public PositiveInteger(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Value must be a positive integer.");
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    public class PositiveRational
    {
        public Rational Value { get; set; }
        public PositiveRational(int numerator, int denominator)
        {
            if (numerator <= 0 || denominator <= 0)
                throw new ArgumentException("numerator and denominator must be positive integer");

            Value = new Rational(numerator, denominator);
        }

        public static PositiveRational operator +(PositiveRational a, PositiveRational b)
        {
            Rational result = a.Value + b.Value;
            return new PositiveRational(result.Numerator, result.Denominator);
        }
        public static PositiveRational operator *(PositiveRational a, PositiveRational b)
        {
            Rational result = a.Value * b.Value;
            return new PositiveRational(result.Numerator, result.Denominator);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    public class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0) { throw new ArgumentException("Denominator cannot be zero"); }
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }
        public void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator; Denominator = -Denominator;
            }
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

    }
}
