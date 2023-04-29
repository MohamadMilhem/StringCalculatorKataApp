using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public StringCalculator() { }

        public int Add(string? numbers)
        {
            if (numbers == null || numbers == string.Empty)
            {
                return 0;
            }

            var number = Int32.Parse(numbers);

            return number;
        }



    }
}
