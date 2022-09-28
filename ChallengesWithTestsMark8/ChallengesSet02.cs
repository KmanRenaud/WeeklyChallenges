using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string isLetter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int a = 0; a < isLetter.Length; a++)
            {
                if (isLetter[a] == c)
                {
                    return true;
                }
                else
                {
                    break;
                }
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int i = 0;
            foreach (var a in vals)
            {
                i++;
            }
            if (i % 2 == 0)
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
            if (number % 2 == 0)
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
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = 0;
            int length2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                length1++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                length2++;
            }
            if (length1 > length2)
            {
                return length2;
            }
            else if (length2 > length1)
            {
                return length1;
            }
            else
            {
                return 0;
            }

        }

        public int Sum(int[] numbers)
        {
            int sum = 0;    
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    continue;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 1; i < number; i += 2)
            {
                count += i;
            }
            return count;
        }
    }
}
