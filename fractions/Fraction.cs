using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Fraction : IComparable<Fraction>
    {
        public readonly int nominator;
        public readonly int denominator;

        public Fraction(int nominator, int denominator)
        {
            if(denominator == 0)
            {
                throw new Exception("Denominator cannot be 0");
            }
            this.nominator = nominator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction secondFraction)
        {
            return new Fraction(nominator * secondFraction.denominator + secondFraction.nominator * denominator, denominator * secondFraction.denominator);
        }

        public int CompareTo(Fraction fraction)
        {
            int result = nominator * fraction.denominator - fraction.nominator * denominator;

            return (result > 0)? 1 : 0;
        }

        public override string ToString()
        {
            return $"{nominator}/{denominator}";
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.nominator * fr2.denominator + fr2.nominator * fr1.denominator, fr1.denominator * fr2.denominator);
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.nominator * fr2.denominator - fr2.nominator * fr1.denominator, fr1.denominator * fr2.denominator);
        }

        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.nominator * fr2.nominator, fr1.denominator * fr2.denominator);
        }

        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            if (fr2.nominator == 0)
            {
                throw new ArgumentException("Substraction is not possible");
            }
            return new Fraction(fr1.nominator * fr2.denominator, fr1.denominator * fr2.nominator);
        }
    }
}
