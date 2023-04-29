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




    }
}
