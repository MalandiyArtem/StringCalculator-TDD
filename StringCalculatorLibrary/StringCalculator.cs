using System;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string inputExpression)
        {
            int sum = 0;
            string[] nums;

            if (inputExpression.Trim() == "")
                return 0;

            RegularMatch optional = new RegularMatch(@"(\/{2}\S)\n", inputExpression);

            if (optional.GetMatch().Success)
            {
                RegularMatch delimeter = new RegularMatch(@"[^\/{2}]{1}", inputExpression);
                string expressionWithoutOptional = optional.Replace("");

                nums = expressionWithoutOptional.Split(new char[] { ',', '\n', Convert.ToChar(delimeter.GetMatch().Value) });
            }
            else
                 nums = inputExpression.Split(new char[] { ',', '\n'});

            for (int i = 0; i < nums.Length; i++)
                sum += int.Parse(nums[i]);

            return sum;
        }
    }
}
