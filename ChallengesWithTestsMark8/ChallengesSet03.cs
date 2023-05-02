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
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = 0;

            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                else
                {
                    continue;
                }
            }
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasLower = false;
            bool hasUpper = false;
            bool hasNumber = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else
                {
                    continue;
                }
            }
            return hasUpper && hasLower && hasNumber;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend /= divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums[nums.Length - 1];
            var first = nums[0];
            
            return last -= first;
        }

        public static int[] GetOddsBelow100()
        {
            var list = new List<int>();
             for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }

             return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0;i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
