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
    }
}