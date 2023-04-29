using System.ComponentModel;
using StringCalculatorKata;
namespace StringCalculatorKata
{public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0, 1 or 2 numbers to add:");
            var input = Console.ReadLine();
            var Calculator = new StringCalculator();
            Console.WriteLine(Calculator.Add(input));
        }
    }
}