using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // program to find solution of quadratic equation
            
            try
            {
                Console.WriteLine("aX^2 + bx + c = 0");
                Console.Write("Enter the value of A: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of C: ");
                double c = double.Parse(Console.ReadLine());
                double delta = Math.Pow(b,2) - (4 * a * c);
                if ( delta < 0)
                {
                  Console.WriteLine("the equation doesn't have any solution");
                }
                else if (delta == 0 )
                {
                    Console.WriteLine("the equation has only one solution");
                    double onlySolution = -b / 2*a;
                    Console.WriteLine("the solution of the eqution is " + onlySolution);
                }
                else
                {
                    Console.WriteLine("the equation has two solutions");
                    double firstSolution = (-b - Math.Sqrt(delta)) / (2 * a);
                    double secondSolution = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("the first solution of the eqution is " + firstSolution);
                    Console.WriteLine("the second solution of the eqution is " + secondSolution);
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("the format of A must be a number");
                }
            

        }
    }
}
