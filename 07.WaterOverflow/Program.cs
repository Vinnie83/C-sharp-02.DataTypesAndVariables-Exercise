namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int tank = 255;

            int n = int.Parse(Console.ReadLine());

            int sumLiters = 0;

            for (int i = 0; i < n; i++)
            {

                int liters = int.Parse(Console.ReadLine());
                int rest = sumLiters + liters;
                if (rest > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    sumLiters += liters;
                }
                

            }

            Console.WriteLine(sumLiters);

        }
    }
}