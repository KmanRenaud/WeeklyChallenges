using System;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumAndSubtraction = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumAndSubtraction += numbers[i];
                }
                else
                {
                    sumAndSubtraction -= numbers[i];
                }
            }
            return sumAndSubtraction;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Max(Math.Max(Math.Max(str3.Length, str4.Length), str2.Length), str1.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number3, number4), number2), number1);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Business alright = new Business() { Name = "TrueCoders"};            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            return input.All(char.IsDigit);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            int nonNullCounter = 0;
            foreach (int i in objs)
            {
                if (objs[i] == null)
                {
                    nullCounter++;
                }
                else
                {
                    nonNullCounter++;
                }
            }
            if (nullCounter > nonNullCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            double cntForAvreage = 0;            foreach (var i in numbers)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                    cntForAvreage++;
                }
                else
                {
                    continue;
                }
            }
            return evens / cntForAvreage;
        }

        public int Factorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
