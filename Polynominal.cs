using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Kezin
{
    public class Polynomial
    {
        private double a;
        private double b;
        private double c;

        public Polynomial(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Calculate(double x)
        {
            return a * x * x + b * x + c;
        }

        public static Polynomial operator +(Polynomial first, Polynomial other)
        {
            double newA = first.a + other.a;
            double newB = first.b + other.b;
            double newC = first.c + other.c;
            return new Polynomial(newA, newB, newC);
        }

        public static Polynomial operator -(Polynomial first, Polynomial other)
        {
            double newA = first.a - other.a;
            double newB = first.b - other.b;
            double newC = first.c - other.c;
            return new Polynomial(newA, newB, newC);
        }

        public static Polynomial operator *(Polynomial first, Polynomial other)
        {
            double newA = first.a * other.a;
            double newB = first.b * other.b;
            double newC = first.c * other.c;
            return new Polynomial(newA, newB, newC);
        }

        public void Print()
        {
            Console.WriteLine($"Многочлен: {a}x^2 + {b}x + {c}");
        }
    }
}
