using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    public class CalculatorTest
    {
        public void AddsTwoNumbers_NonSymbol()
        {
            int number1 = 1;
            int number2 = 2;
            double result = 3;

            double ret = SimpleCalculator.Calculator.Process(number1, number2, "add");
            assert
        }
    }
}
