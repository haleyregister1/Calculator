using System;
using CalculaterUIConsole;
using Xunit;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 20, 30)]
        public void Add(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new Operations();

            //Act
            var actual = sut.AddMethod(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(12, 8, 4)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sut = new Operations();

            //Act
            var actual = sut.SubtractMethod(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new Operations();

            //Act
            var actual = sut.MultiMethod(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new Operations();

            //Act
            var actual = sut.DivideMethod(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }
    }
}
