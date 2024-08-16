namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());

            int countDays = 0;
          
            int spice = 0;

            while (yield >= 100) 
            {
                countDays++;
                spice += yield;
                spice -= 26;
                yield -= 10;

               
            }

            spice -= 26;

            if (spice < 0)
            {
                spice = 0;
            }


            Console.WriteLine(countDays);
            Console.WriteLine(spice);

        }
    }
}