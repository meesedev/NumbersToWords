using NumbersToWords.Core;

namespace NumbersToWords.Tests
{
    public class ConverterTests
    {
        [Theory]
        [InlineData("0", "Zero")]
        [InlineData("4", "Four")]
        [InlineData("42", "Forty-Two")]
        [InlineData("100", "One hundred")]
        [InlineData("342", "Three hundred and Forty-Two")]
        [InlineData("9999", "Nine thousand Nine hundred and Ninety-Nine")]
        [InlineData("4.4", "Four point Four")]
        [InlineData("4.40", "Four point Four Zero")]
        [InlineData("4.04", "Four point Zero Four")]
        [InlineData("0.01", "Zero point Zero One")]
        [InlineData("60.11", "Sixty point One One")]
        [InlineData("60.10", "Sixty point One Zero")]
        [InlineData("9999.99", "Nine thousand Nine hundred and Ninety-Nine point Nine Nine")]
        public void Convert_ValidInput_ReturnsExpectedWords(string input, string expected)
        {
            var result = NumberToWordsConverter.Convert(input);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(".", "Invalid number")]
        [InlineData("abc", "Invalid number")]
        [InlineData("10000", "Number out of range")]
        [InlineData("-1", "Number out of range")]
        [InlineData("5.123", "Too many decimal places")]
        public void Convert_InvalidInput_ReturnsExpectedMessage(string input, string expected)
        {
            var result = NumberToWordsConverter.Convert(input);
            Assert.Equal(expected, result);
        }

    }
}