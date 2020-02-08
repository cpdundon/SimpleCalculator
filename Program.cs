using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
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
