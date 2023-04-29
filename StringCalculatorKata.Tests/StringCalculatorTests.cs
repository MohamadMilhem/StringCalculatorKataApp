namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void ShouldReturnZeroIfInputIsNull()
        {
            // Arrange
            var Calculator = new StringCalculator();
            
            // Act
            var result = Calculator.Add(null);

           // Assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void ShouldReturnZeroIfInputIsEmpty()
        {
            // Arrange
            var Calculator = new StringCalculator();

            // Act
            var result = Calculator.Add("");

            // Assert
            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1")]
        [InlineData("123")]
        public void ShouldReturnTheSameNumberIfInputOnlyOneNumber(string input)
        {
            // Arrange
            var Calculator = new StringCalculator();
            var expected = Int32.Parse(input);

            // Act
            var result = Calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }




    }
}