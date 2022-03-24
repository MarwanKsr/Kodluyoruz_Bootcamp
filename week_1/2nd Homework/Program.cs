using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int primeNumber = int.Parse(Console.ReadLine());
            if (primeNumber == 2 || primeNumber == 3 || primeNumber == 5 || primeNumber == 7)
            System.Console.WriteLine(primeNumber + " is a prime Number");
            else if (primeNumber%2 !=0 && primeNumber%3 !=0 && primeNumber%5 !=0 && primeNumber%7 !=0)
            {
                System.Console.WriteLine(primeNumber + " is a prime Number");
            }
            else 
            {
                System.Console.WriteLine(primeNumber + " isn't a prime number");
            }
        }
    }
}