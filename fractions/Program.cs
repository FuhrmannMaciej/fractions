using System;
using System.Collections.Generic;

namespace fractions
{
    class Compare : IComparer<Fraction>
    {
        int IComparer<Fraction>.Compare(Fraction x, Fraction y)
        {
            int result = x.nominator * y.denominator - y.nominator * x.denominator;

            return (result > 0) ? 1 : 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1, 3);
            Fraction fr2 = new Fraction(1, 5);

            Console.WriteLine(fr1.Add(fr2));
            Console.WriteLine(fr1 * fr2);
            Console.WriteLine(fr1 / fr2);

            List<Fraction> list = new List<Fraction>();
            list.Add(fr1);
            list.Add(fr2);
            list.Add(new Fraction(4, 5));
            foreach (var item in list)
            {
            Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            list.Sort(new Compare());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
