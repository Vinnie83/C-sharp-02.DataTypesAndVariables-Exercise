namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumDigits = 0;

            while (number > 0)
            {
                int currentNumber = number;

                currentNumber %= 10;

                sumDigits += currentNumber;

                number /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}