using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
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
            
            try
            {
                Console.WriteLine("Please enter an integer.");
                int intUserInput = -999999;
                string input = Console.ReadLine();
                try {
                    bool success = int.TryParse(input, out intUserInput);
                    
                    if (!success)
                    {
                        throw new Exception("Conversion was not successful.");
                    }
                    
                    int result = intUserInput * 2;
                    Console.WriteLine(result.ToString());

                } catch (Exception ex) 
                {
                    Console.WriteLine("Conversion error: ", ex.Message);

                }
                
                Person.greet();
                Person person1 = new Person();
                Console.WriteLine(person1.getAge());
                person1.setAge(29);
                Console.WriteLine(person1.getAge());
            } catch (Exception ex) {
                Console.WriteLine("There was an error: {0}", ex.Message);
            } finally
            {
                Console.WriteLine("Deal with unhandled resources - open files etc.");
            }
        } 
    }
}
