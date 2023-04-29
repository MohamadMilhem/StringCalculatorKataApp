﻿using System;
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
            if (numbers == null || numbers == string.Empty)
            {
                return 0;
            }

            var number = Int32.Parse(numbers);

            return number;
        }



    }
}
