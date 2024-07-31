using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public class ComplexNumbers
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumbers(double real, double imaginary) 
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            return new ComplexNumbers(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            return new ComplexNumbers(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
            double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return new ComplexNumbers(real, imaginary);
        }
        public static ComplexNumbers operator /(ComplexNumbers a, ComplexNumbers b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
            double imaginary = (b.Real * a.Imaginary - a.Real * b.Imaginary) / denominator;
            return new ComplexNumbers(real, imaginary);
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
