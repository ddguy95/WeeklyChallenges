using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals?.Contains(false) ?? false;
            //if (vals == null || vals.Length == 0)
            //{
            //    return false;
            //}
            //bool ans = false;
            //foreach (bool val in vals)
            //{
            //    if (val == false)
            //    {
            //        ans = true;
            //    }
            //    return ans;
        }

            public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            {
                if (numbers == null || numbers.Count() == 0)
                {
                    return false;
                }

                bool ans;
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
                bool isUpper = false;
                bool isLower = false;
                bool isNumber = false;
                foreach (var ele in password)
                {
                    if (Char.IsLower(ele))
                    {
                        isLower = true;
                    }
                    if (Char.IsUpper(ele))
                    {
                        isUpper = true;
                    }
                    if (Char.IsNumber(ele))
                    {
                        isNumber = true;
                    }
                } return (isUpper && isLower && isNumber);

            }

            public char GetFirstLetterOfString(string val)
            {
            return val[0];
                
            }

            public char GetLastLetterOfString(string val)
            {
            return val [^1];
            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
                return divisor == 0 ? 0:  dividend / divisor;
            }

            public int LastMinusFirst(int[] nums)
            {
                return nums[nums.Length - 1] - nums[0];
            }

            public int[] GetOddsBelow100()
            {
                var ans = new List<int>();
            for(int i = 0; i<=100; i++)
            {
                if(i %2 != 0)
                {
                    ans.Add(i);
                }
            }return ans.ToArray();
            }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                    
            }
        }
    }   }
