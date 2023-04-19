using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
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
            throw new NotImplementedException();
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            string[] words = { str1, str2 };
            int shortestWord = words.Min(w => w.Length);
            return shortestWord;
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public static int SumEvens(int[] numbers)
        {
            int evens = 0;
            int odds = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens+= num;
                    return evens;
                }
                else
                {
                    odds+= num;
                    return odds;
                }
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
