﻿using System;
namespace AlgorithmProblem
{
    public class Program
    {
        public static void Main(string[]args)
        {

            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime Numbers are : ");

            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
        }
    }
}
