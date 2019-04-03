using System;
using Xunit;

namespace Calculator.Tests
{
    public class adding_numbers_from_user_input
    {
        [Fact]
        public void adding_2_and_2_Should_be_4()
        {
            // arrange -- context     -- given
            var calculator = new CalculationEngine();
            var input = "2+2";
            var expectedResult = 4;

            // act -- do the thing    -- when
            var actualResult = calculator.DoMath(input);

            // assert -- check result -- then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void adding_2_and_5_Should_be_4()
        {
            // arrange -- context     -- given
            var calculator = new CalculationEngine();
            var input = "2+5";
            var expectedResult = 7;

            // act -- do the thing    -- when
            var actualResult = calculator.DoMath(input);

            // assert -- check result -- then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Addition_With_Only_One_Number_Throws_an_Invalid_Input_Exception()
        {
            var calculator = new CalculationEngine();
            var input = "2+";

            Assert.Throws<InvalidInputException>(() => calculator.DoMath(input));
        }

        [Fact]
        public void adding_3_numbers_They_should_be_added_successfully()
        {
            // arrange -- context     -- given
            var calculator = new CalculationEngine();
            var input = "2+5+10";
            var expectedResult = 17;

            // act -- do the thing    -- when
            var actualResult = calculator.DoMath(input);

            // assert -- check result -- then
            Assert.Equal(expectedResult, actualResult);

        }

    }
}
