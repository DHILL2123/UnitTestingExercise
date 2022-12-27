using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4,5,3,12)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();



            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }   

        [Theory]
        [InlineData(6,4,2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.SubtractTest(minuend, subtrhend, expected);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.MultiplyTest(num1, num2, expected);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.DivideTest(num1, num2, expected);
            //Assert

        }

    }
}
