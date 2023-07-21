using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;

            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    answer += number;
                }
                else
                {
                    answer -= number;
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           if(str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                return str1.Length;
            }
           else if(str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                return str2.Length;
            }
           else if(str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                return str3.Length;
            }
           else 
            {
                return str4.Length;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }
            else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 <= sideLength3)
            {
                return false;
            }
            else if(sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else if (sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0);

            if (evens.Count() == 0)
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            int factorial = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
