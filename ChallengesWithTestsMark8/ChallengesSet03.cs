using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }
            foreach (bool i in vals)
            {
                if (i == false)
                {
                    return true;
                }
            }
            return false;
            //return vals?.Contains(false) ?? false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                    
                }
                
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            foreach (char l in password)
            {
                if (Char.IsUpper(l))
                {
                    upper = true;
                }
                if (Char.IsLower(l))
                {
                    lower = true;
                }
                if (Char.IsNumber(l))
                {
                    number = true;
                }
            }
            return upper && lower && number;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
            {
                return 0;
            }
            //return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            return odds.ToArray();
            //return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }
        
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            //Array.Copy(Array.ConvertAll(words, x => x.ToUpper()), words, words.Length);
        }
    }
}
