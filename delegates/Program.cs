using System;

namespace Assignment8ex2
{
    public delegate void ComparisonDelegate(double a, double b);

    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        public static void SmallerAction(double a, double b)
        {
            MathSolutions solution = new MathSolutions();
            solution.GetSmaller(a, b);
        }

        public static double SumFunc(double x, double y)
        {
            MathSolutions solution = new MathSolutions();
            return solution.GetSum(x, y);
        }

        static void Main(string[] args)
        {
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            Console.WriteLine($" {num1} + {num2} = {SumFunc(num1, num2)}");
            SmallerAction(num1, num2);

            ComparisonDelegate comparisonDelegate = new ComparisonDelegate(answer.GetSmaller);
            comparisonDelegate(num1, num2);
        }
    }
}

