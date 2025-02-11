using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:


            //Arrange
            // create a Calculator object
            var Calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = Calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]//Add test data <-------
        public void SubtractTest(int min, int subt, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Calculator = new Calculator();
            //Act
            var actual = Calculator.Subtract(min, subt);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, 8)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Calculator = new Calculator();
            //Act
            var actual = new Calculator().MulitiplyTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 2, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.DivideTest(num1 , num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
