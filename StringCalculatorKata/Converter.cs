﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Converter
    {

        public IEnumerable<int> Convert(string input)
        {
            List<int> result = new List<int>();
            List<string> numbers = input.Split(',').ToList();

            foreach (string number in numbers)
            {
                var parsed = Int32.Parse(number);
                result.Add(parsed);
            }

            return result;
        }

    }
}
