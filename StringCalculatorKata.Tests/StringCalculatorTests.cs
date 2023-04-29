using StringCalculatorKata.Interfaces;


namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        private readonly Converter _converter;
        private readonly StringCalculator _calculator;

        public StringCalculatorTests()
        {
            _converter = new Converter();
            _calculator = new StringCalculator(_converter);
        }



        [Fact]
        public void ShouldReturnZeroIfInputIsNull()
        {

            
            // Act
            var result = _calculator.Add(null);

           // Assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void ShouldReturnZeroIfInputIsEmpty()
        {

            // Act
            var result = _calculator.Add("");

            // Assert
            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1")]
        [InlineData("123")]
        public void ShouldReturnTheSameNumberIfInputOnlyOneNumber(string input)
        {
            // Arrange
            var expected = Int32.Parse(input);

            // Act
            var result = _calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }




    }
}