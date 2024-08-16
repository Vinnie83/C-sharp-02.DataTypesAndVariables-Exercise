namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main()
        {
            
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            

            for (int i = startIndex; i <= endIndex; i++)
            {
                char letter = (char) i;

                Console.Write($"{letter} ");
            }

        }
    }
}