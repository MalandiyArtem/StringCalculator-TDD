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
            if(numbers.Length == 3)
            {
                string[] nums = numbers.Split(',');
                return int.Parse(nums[0]) + int.Parse(nums[1]);
            }
                
            return -1;
        }
    }
}
