using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using StringCalculatorKata.Interfaces;

namespace StringCalculatorKata.Tests
{
    public class ConverterTests
    {
        private readonly IConverter _converter;

        public ConverterTests()
        {
            _converter = new Converter();
        }

        [Fact]
        public void ShouldReturnIEnumWithSumZeroWhenInputIsNull()
        {
            // Arrange
            var expected = new int[] { 0 };

            // Act
            var result = _converter.Convert(null);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldReturnIEnumWithSumZeroIfInputIsEmpty()
        {
            // Arrange
            var expected = new int[] { 0 };

            // Act
            var result = _converter.Convert("");

            // Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("0,1", new int[] {0,1})]
        [InlineData("1,2", new int[] {1,2})] 
        public void ShouldReturnParsedNumbersFromTheInput(string input, int[] expected)
        {
            // Act
            var result = _converter.Convert(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n2", new int[] { 1, 2 })]
        [InlineData("1\n2\n3", new int[] { 1, 2, 3 })]
        public void ShouldReturnParsedNumbersWithNewLines(string input, int[] expected)
        {
            // Act
            var result = _converter.Convert(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1;2", "//;", new int[] { 1, 2 })]
        [InlineData("1!2,3", "//!", new int[] { 1, 2, 3 })]
        public void ShouldReturnParsedNumbersBasedOnCustomDelimiters(string input, string delimiters, int[] expected)
        {

            // Act
            var result = _converter.Convert(input, delimiters);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-1;-2", "//;", new int[] { -1, -2 })]
        [InlineData("-1!-2,-3", "//!", new int[] { -1, -2, -3 })]
        public void ShouldReturnParsedNegativeNumbers(string input, string delimiters, int[] expected)
        {

            // Act
            var result = _converter.Convert(input, delimiters);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
