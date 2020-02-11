using System;

namespace SimpleCalculator
{
    class NumberConverter
    {
        static double Conversion(number_1, number_2, textOperation)
        {
            double ret = -999999;

            switch (textOperation)
            {
                case "+":
                case "add":
                    ret = number_1 + number_2;
                    break;
                case "-":
                case "subtract":
                    ret = number_1 - number_2;
                    break;
                case "*":
                case "multiply":
                    ret = number_1 * number_2;
                    break;
                case "/":
                case "divide":
                    ret = number_1 / number_2;
                    break;
                default:
                    throw new Exception("Operand entry error - please enter a supported operation.");
            }

            return ret;
        }

    }

}