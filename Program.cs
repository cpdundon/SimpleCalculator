using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number.");
                string textNumber_1 = Console.ReadLine();
                Console.WriteLine("Please enter a second number.");
                string textNumber_2 = Console.ReadLine();
                Console.WriteLine("Please enter an operation.");
                string textOperation = Console.ReadLine();
                
                double number_1 = NumberConverter.Conversion(textNumber_1);
                double number_2 = NumberConverter.Conversion(textNumber_2);

                double result = Calculator.Process(number_1, number_2, textOperation);

                Console.WriteLine("And the answer is... {0}", result);
            
            } catch (Exception ex) {
                Console.WriteLine("There was an error: {0}", ex.Message);
            } finally
            {
                Console.WriteLine("Finally... Deal with unhandled resources - open files etc.");
            }
        } 
    }
}
