﻿namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main()
        {
            int n  = int.Parse(Console.ReadLine());

            int sumLetters = 0; 

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sumLetters += (int)letter;
            }

            Console.WriteLine($"The sum equals: {sumLetters}");
        }
    }
}