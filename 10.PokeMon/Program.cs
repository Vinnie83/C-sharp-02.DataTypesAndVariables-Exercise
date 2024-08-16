namespace _10.PokeMon
{
    internal class Program
    {
        static void Main()
        {

            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int countTargets = 0;
            double percent = (double)power * 0.50;

            while (power >= distance)
            {

                power -= distance;
                
                if (power == percent && exhaustion != 0)
                {
                    power /= exhaustion;
                                       
                }

                countTargets++;
            }

            Console.WriteLine(power);
            Console.WriteLine(countTargets);
            
        }
    }
}