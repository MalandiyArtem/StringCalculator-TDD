using System;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            string[] nums = numbers.Split(',');
            int sum = 0;

            if (numbers.Trim() == "")
                return 0;

            for (int i = 0; i < nums.Length; i++)
                sum += int.Parse(nums[i]);

            return sum;
        }
    }
}
