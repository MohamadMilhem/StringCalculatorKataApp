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

        public IEnumerable<int> Convert(string input)
        {
            List<int> result = new();
            List<string> numbers = input.Split(',').ToList();

            foreach (string number in numbers)
            {
                var parsed = int.Parse(number);
                result.Add(parsed);
            }

            return result;
        }

    }
}
