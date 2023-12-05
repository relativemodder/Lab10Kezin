using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Kezin
{
    internal class Task1
    {
        public static void Run()
        {
            Polynomial polynomial1 = new Polynomial(1, 2, 3);
            Polynomial polynomial2 = new Polynomial(4, 5, 6);

            double x = 2;
            double result = polynomial1.Calculate(x);
            Console.WriteLine($"Значение многочлена для x = {x}: {result}");

            Polynomial sum = polynomial1 + polynomial2;
            sum.Print();

            Polynomial difference = polynomial1 - polynomial2;
            difference.Print();

            Polynomial product = polynomial1 * polynomial2;
            product.Print();

            /* Output:
             * Значение многочлена для x = 2: 11
             * Многочлен: 5x^2 + 7x + 9
             * Многочлен: -3x^2 + -3x + -3
             * Многочлен: 4x^2 + 10x + 18
             */
        }
    }
}
