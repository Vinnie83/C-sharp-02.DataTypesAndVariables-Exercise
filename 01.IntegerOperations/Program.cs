namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());   
            int secondNumber = int.Parse(Console.ReadLine());   
            int thirdNumber = int.Parse(Console.ReadLine());   
            int fourthNumber = int.Parse(Console.ReadLine());

            int result = firstNumber + secondNumber;

            int result2 = result / thirdNumber;

            int result3 = result2 * fourthNumber;

            Console.WriteLine(result3);


        }
    }
}