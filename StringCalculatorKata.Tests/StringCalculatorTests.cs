using StringCalculatorKata.Interfaces;


namespace StringCalculatorKata.Tests
{
    using Moq;

    public class StringCalculatorTests
    {
        private readonly Mock<IConverter> _converter;
        private readonly StringCalculator _calculator;

        public StringCalculatorTests()
        {
            _converter = new Mock<IConverter>();
            _calculator = new StringCalculator(_converter.Object);
        }



        [Fact]
        public void ShouldReturnZeroIfInputIsNull()
        {
            // Arrange
            _converter.Setup(x => x.Convert(null)).Returns(new int[] { 0 });

            // Act
            var result = _calculator.Add(null);

            // Assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void ShouldReturnZeroIfInputIsEmpty()
        {
            // Arrange
            _converter.Setup(x => x.Convert("")).Returns(new int[] { 0 });

            // Act
            var result = _calculator.Add("");

            // Assert
            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1", new int[] { 1 })]
        [InlineData("123", new int[] { 123 })]
        public void ShouldReturnTheSameNumberIfInputOnlyOneNumber(string input, int[] numbers)
        {
            // Arrange
            _converter.Setup(x => x.Convert(input)).Returns(numbers);
            var expected = numbers.Sum(x => x);

            // Act
            var result = _calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("0,1", new int[] { 0, 1 })]
        [InlineData("1,2", new int[] { 1, 2 })]
        public void ShouldReturnTheSumOfTwoNumbersInInput(string input, int[] numbers)
        {
            // Arrange
            _converter.Setup(x => x.Convert(input)).Returns(numbers);
            var expected = numbers.Sum(x => x);
            // Act
            var result = _calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,\n2", new int[] { 1, 2 })]
        public void ShouldReturnTheSumOfNumbersInInputWithNewLines(string input, int[] numbers)
        {
            // Arrange
            _converter.Setup(x => x.Convert(input)).Returns(numbers);
            var expected = numbers.Sum(x => x);


            // Act
            var result = _calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }


    }
}