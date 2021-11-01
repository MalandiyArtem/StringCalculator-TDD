using System;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            string[] nums = numbers.Split(',');

            if (numbers.Trim() == "")
                return 0;
            if (nums.Length == 1)
                return int.Parse(nums[0]);
            if (nums.Length == 2)
                return int.Parse(nums[0]) + int.Parse(nums[1]);

            return -1;
        }
    }
}
