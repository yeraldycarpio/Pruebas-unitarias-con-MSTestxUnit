using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HYCM.Calculadora.UnitTest.AppxUnit
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            //Act 
            double result = calculator.Add(num1, num2);

            //Assert
            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 8.0;
            double num2 = 3.0;

            //Act
            double result = calculator.Subtract(num1, num2);

            //Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 4.0;
            double num2 = 2.0;

            //Act
            double result = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(8.0, result);
        }


        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 10.0;
            double num2 = 2.0;

            //Act
            double result = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 0.0;

            //Act and Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(num1, num2));

        }
    }
}
