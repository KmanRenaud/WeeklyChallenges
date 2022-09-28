using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int a = n;
            while (true)
            {
                if (a > startNumber)
                {
                    return a;
                }
                else
                {
                    a += a;
                }
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (i == numbers.Length - 1)
                    {
                        sum = 0 + sum;
                    }
                    else
                    {
                        sum += numbers[i + i];
                    }
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if (i == 0)
                {
                    sentence += words[i];
                }
                else
                {
                    sentence += " " + words[i];
                }
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[] { };
            }

            int ayo = 4;
            double[] count = new double[elements.Count / ayo];
            int j = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements.Count >= ayo)
                {
                    count[j] = elements[ayo - 1];
                    ayo += 4;
                    j++;
                }
                else break;
            }
            return count;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    else if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
