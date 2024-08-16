using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main()
        {
            int snowballs = int.Parse(Console.ReadLine());

            BigInteger bestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger totalValue = BigInteger.Pow(snow / time, quality);   

                if (bestValue < totalValue)
                {
                    bestValue = totalValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;

                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}