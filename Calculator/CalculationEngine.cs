using System;
using System.Linq;

namespace Calculator
{
    public class CalculationEngine
    {
        public CalculationEngine()
        {

        }

        public int DoMath(string input)
        {
            try
            {
                var stuffToCalculate = input.Split("+")
                    .Select(int.Parse).ToArray();

                return stuffToCalculate.Sum();

            }
            catch(FormatException)
            {
                throw new InvalidInputException();
            }
        }
    }
}