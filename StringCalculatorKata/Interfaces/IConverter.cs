namespace StringCalculatorKata.Interfaces
{
    public interface IConverter
    {
        IEnumerable<int> Convert(string? input, string? delimiters = null);
    }
}