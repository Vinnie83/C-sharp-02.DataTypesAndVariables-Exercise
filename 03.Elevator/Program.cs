using System.Diagnostics.CodeAnalysis;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int courses = 0;

            if (n % p != 0)
            {
                courses = n / p;
                courses += 1;

            }
            else
            {
                courses = n / p;

            }

            Console.WriteLine(courses);

        }
    }
}