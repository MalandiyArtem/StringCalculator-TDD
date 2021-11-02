using System;
using System.Collections.Generic;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string inputExpression)
        {
            string[] nums;

            if (inputExpression.Trim() == "")
                return 0;

            RegularMatch optional = new RegularMatch(@"^\/\/(.*)(?=\n)", inputExpression);

            if (optional.GetMatch().Success)
            {
                RegularMatch delimeter = new RegularMatch(@"(?<=\[)(.)(?=\])|(?<=\[)(.*)(?=\])|(?<=\/\/)(.){1}(?=\n)", inputExpression);
                string expressionWithoutOptional = optional.Replace("");

                nums = expressionWithoutOptional.Split(delimeter.GetDelimiters(), StringSplitOptions.RemoveEmptyEntries);
            }
            else
                nums = inputExpression.Split(new char[] { ',', '\n' });

            return GetSum(nums);
        }

        private int GetSum(string[] nums)
        {
            List<int> positiveNumbers = CheckNumbers(nums);
            int sum = 0;

            foreach (var item in positiveNumbers)
            {
                if (item <= 1000)
                    sum += item;
            }
            return sum;
        }

        private List<int> CheckNumbers(string[] nums)
        {
            List<int> negativeNumbersList = new List<int>();
            List<int> positiveNumbersList = new List<int>();
            string negativeNumbers = "";

            for (int i = 0; i < nums.Length; i++)
            {
                int num = int.Parse(nums[i]);

                if (num < 0)
                {
                    negativeNumbers += $"{num} ";
                    negativeNumbersList.Add(num);
                }
                else
                    positiveNumbersList.Add(num);
            }

            if (negativeNumbersList.Count > 1)
                throw new NegativesNotAllowedException(negativeNumbers.Trim());
            if (negativeNumbersList.Count == 1)
                throw new NegativesNotAllowedException();

            return positiveNumbersList;
        }
    }
}
