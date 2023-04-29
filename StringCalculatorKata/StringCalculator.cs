using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorKata.Interfaces;

namespace StringCalculatorKata
{
    public class StringCalculator : IStringCalculator
    {
        private readonly IConverter _converter;

        public StringCalculator(IConverter converter)
        {
            _converter = converter;
        }

        public int Add(string? numbers, string? delimiters = null)
        {

            var parsedNumbers = _converter.Convert(numbers, delimiters);

            int answer = 0;

            foreach (var number in parsedNumbers)
            {
                if (number >= 0)
                {
                    answer += number;
                }
                else
                {
                    throw new Exception("negatives not allowed");
                }
            }

            return answer;
        }



    }
}
