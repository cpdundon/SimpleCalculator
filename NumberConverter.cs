using System;

namespace SimpleCalculator
{
    public class NumberConverter
    {
        public static double Conversion(string textNumber)
        {
            double doubleNumber;
            if (!double.TryParse(textNumber, out doubleNumber))
            {
                throw new Exception("Could not parse the number entered.  Please enter a proper number.");
            }
            return doubleNumber;
        }

    }

}