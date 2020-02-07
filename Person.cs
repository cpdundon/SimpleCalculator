using System;

namespace SimpleCalculator
{
    class Person
    {
        private int _age = 25;
        public int getAge()
        {
            return _age;
        }
        public void setAge(int newAge)
        {
            _age = newAge;

        }

        static public void greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}