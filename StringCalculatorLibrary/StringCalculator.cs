using System;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Trim() == "")
                return 0;
            if (numbers.Length == 1)
                return int.Parse(numbers);
            return -1;
        }
    }
}
