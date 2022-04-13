using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalcWindowApp
{
    class Complex
    {
        double real;
        double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator+(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);

            return c3;
        }
        public static Complex operator*(Complex c1, Complex c2)
        {
            Complex c3 = new Complex((c1.real * c2.real) - (c1.imaginary * c2.imaginary), (c1.real * c2.imaginary) + (c1.imaginary * c2.imaginary));
         
            return c3;
        }
        public string PrintReal()
        {
            return real + "";
        }
        public string PrintImaginary()
        {
            return imaginary + "";
        }
    }
}
