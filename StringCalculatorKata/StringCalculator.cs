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

        public int Add(string? numbers)
        {

            var parsedNumbers = _converter.Convert(numbers);


            return parsedNumbers.Sum();
        }



    }
}
