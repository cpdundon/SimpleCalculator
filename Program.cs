using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int intUserInput;
            string input = Console.ReadLine();
            Console.WriteLine("TEST");
            bool success = int.TryParse(input, out intUserInput);
            int result = intUserInput * 2;
            Console.WriteLine(result.ToString());
        }
    }
}
