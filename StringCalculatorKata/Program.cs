using System.ComponentModel;
using StringCalculatorKata;
namespace StringCalculatorKata
{public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to add:");
            var input = Console.ReadLine();
            var converter = new Converter();
            var Calculator = new StringCalculator(converter);
            Console.WriteLine(Calculator.Add(input));
        }
    }
}