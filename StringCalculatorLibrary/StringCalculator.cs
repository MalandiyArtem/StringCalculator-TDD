using System;
using System.Text.RegularExpressions;

namespace StringCalculatorLibrary
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Trim() == "")
                return 0;


            //Regex optional = new Regex(@"^\/\/.");
            Regex optional = new Regex(@"(\/{2}\S)\n");
            Match matchOptional = optional.Match(numbers);
            int sum = 0;

            // Проверяем есть ли опциональная часть строки
            if (matchOptional.Success)
            {
                // Нахоим кастомный разделитель
                Regex findCustomDelimiter = new Regex(@"[^\/{2}]{1}");
                Match customDelimiter = findCustomDelimiter.Match(numbers);

                // отрезаем опциональную часть
                string newNums = optional.Replace(numbers, "");

                string[] nums = newNums.Split(new char[] { ',', '\n', Convert.ToChar(customDelimiter.Value) });

                for (int i = 0; i < nums.Length; i++)
                    sum += int.Parse(nums[i]);

            }
            else
            {
                string[] nums = numbers.Split(new char[] { ',', '\n'});

                for (int i = 0; i < nums.Length; i++)
                    sum += int.Parse(nums[i]);
            }

            return sum;
        }
    }
}
