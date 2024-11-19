using System;

namespace FractionApp
{

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }


        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменник не може бути нульовим.");
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }


        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }


        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }


        public Fraction Add(Fraction other)
        {
            int numerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            int denominator = this.Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }


        public Fraction Subtract(Fraction other)
        {
            int numerator = this.Numerator * other.Denominator - other.Numerator * this.Denominator;
            int denominator = this.Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }


        public Fraction Multiply(Fraction other)
        {
            int numerator = this.Numerator * other.Numerator;
            int denominator = this.Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }


        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new DivideByZeroException("Ділення на нуль недопустиме.");
            int numerator = this.Numerator * other.Denominator;
            int denominator = this.Denominator * other.Numerator;
            return new Fraction(numerator, denominator);
        }


        public bool Equal(Fraction other)
        {
            return this.Numerator * other.Denominator == other.Numerator * this.Denominator;
        }


        public Fraction MultiplyByInt(int number)
        {
            return new Fraction(this.Numerator * number, this.Denominator);
        }


        public Fraction SubtractInt(int number)
        {
            int numerator = this.Numerator - number * this.Denominator;
            return new Fraction(numerator, this.Denominator);
        }


        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}
