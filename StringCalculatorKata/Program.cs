using System.ComponentModel;
using StringCalculatorKata;
namespace StringCalculatorKata
{public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers to add:");
            var converter = new Converter();
            var Calculator = new StringCalculator(converter);
            var firstLine = Console.ReadLine();
            int result;
            if (firstLine != null && firstLine.StartsWith("//"))
            {
                var secondLine = Console.ReadLine();
                result = Calculator.Add(secondLine, firstLine);
            }
            else
            {
                result = Calculator.Add(firstLine);
            }

            Console.WriteLine(result);
        }
    }
}