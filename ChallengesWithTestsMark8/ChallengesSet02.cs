using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            if (letters.Contains(Char.ToLower(c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int elements = vals.Length;
            if (elements % 2 == 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach (double number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int answer = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    answer += item;
                }      
            }
            return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int item in numbers)
            {  
                    sum += item;
            }
            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
