using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorKata.Interfaces;

namespace StringCalculatorKata
{
    public class Converter : IConverter
    {

        public IEnumerable<int> Convert(string? input, string? delimiters)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new List<int> { 0 };
            }

            string delimitersToPass = ",\n";

            Console.WriteLine(delimitersToPass.Length);
           
            if (!string.IsNullOrEmpty(delimiters))
            {
                foreach (char delimiter in delimiters)
                {
                    if (delimiters.IndexOf(delimiter) > 1)
                    {
                        delimitersToPass += delimiter;
                    }
                }
            }


            List<int> result = new();
            List<string> numbers = input.Split(delimitersToPass.ToCharArray()).ToList();

            foreach (string number in numbers)
            {
                var parsed = int.Parse(number);
                result.Add(parsed);
            }

            return result;
        }

    }
}
