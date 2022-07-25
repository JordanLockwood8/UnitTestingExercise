using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(10,10,10, 30)]
        [InlineData(5, -10, 5, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var add = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = add.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
             Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(20, 10, 10)]
        [InlineData(100, 55, 45)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,10,100)]
        [InlineData(5,5,25)]
        [InlineData(20,20,400)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25,5,5)]
        [InlineData(50,2,25)]
        [InlineData(8,2,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
