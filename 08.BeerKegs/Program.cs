namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = 0;
            string biggestKegModel = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKegModel = model;
                }


            }

            Console.WriteLine(biggestKegModel);
        }
    }
}