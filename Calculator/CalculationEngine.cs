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
                return input.Split("+")
                    .Select(int.Parse)
                    .ToArray().Sum();
            }
            catch(FormatException)
            {
                throw new InvalidInputException();
            }
        }
    }
}