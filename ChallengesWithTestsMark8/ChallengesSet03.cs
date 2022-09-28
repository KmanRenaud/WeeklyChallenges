using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
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

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddCount = 0;
            foreach (var i in numbers)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    oddCount += i;
                }
            }
            if (oddCount % 2 != 0)
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
            int upper = 0;
            int lower = 0;
            foreach (var i in password)
            {
                if (char.IsUpper(password[i]))
                {
                    upper += 1;
                }
                else
                {
                    lower += 1;
                }
            }

            if (upper > 0 && lower > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            int a = val.Length;
            return val[a - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int a = nums.Length;
            return nums[a - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
            return odds;
        }
        

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i].ToUpper();
            }
        }
    }
}
