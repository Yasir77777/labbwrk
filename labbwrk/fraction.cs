using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labbwrk
{
    class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void Display()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }
    }

}
