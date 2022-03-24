using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0,number1 = 0, n = 10000;
            int[] primeNumber = new int[n];
            for (int i=2; i<n; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {   primeNumber[number] = i;
                    number++;
                }
                else if (i%2 !=0 && i%3 !=0 && i%5 !=0 && i%7 !=0)
                {
                primeNumber[number] = i;
                    number++;
                }
            }
            foreach (int item in primeNumber)
            {
                System.Console.Write(item);
                number1++;
                if (number1 == number)
                {
                    break;
                }
                else{
                    System.Console.Write(", ");
                }
                
            }
            
        }
    }
}