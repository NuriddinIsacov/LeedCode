using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeedCode
{
    public class Program
    {
        static void Main(string[] args) 
        {
            string[] strs = { "ab", "a" };
            Console.WriteLine(LongestCommonPrefix(strs));

        }


        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            string result = string.Empty;
            string prefix = strs[0];
            bool check = true;
            List<string> list = new List<string>();

            foreach (var item in strs)
            {
                if (item.Length < prefix.Length)
                {
                    prefix = item;
                }
            }

            for (int i = 0; i < prefix.Length; i++)
            {
                foreach (var item in strs)
                {
                    if (!item.Contains(prefix[i]))
                    {
                        check = false;
                    }
                }
                if (check is true)
                {
                    result += prefix[i];
                }
                else
                {
                    list.Add(result);
                    result = string.Empty;
                }

                check = true;
            }

            string answer = string.Empty;

            foreach (var item in list)
            {
                if (item.Length > answer.Length)
                {
                    answer = item;
                }
            }

            return answer;
        }

        public static string WordPattern(string pattern, string s)
        {
            bool result = false;
            string satr = "1";

            string[] str = s.Split(" ");                //"dog cat cat fish"  "abba"
            Dictionary<char, string> stringPattern = new Dictionary<char, string>();

            for (int i = 1; i < pattern.Length; i++)
            {
                if (pattern[i] != pattern[i-1])
                {
                    satr += $"{i + 1}";
                }else
                {
                    satr += satr;
                }
            }

            return satr;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            var listWork = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums.Contains(-(nums[i] + nums[j])) && j != nums.ToList().IndexOf(-(nums[i] + nums[j])) &&  i != nums.ToList().IndexOf(-(nums[i] + nums[j])))
                    {
                        var addedList = new List<int>
                                {
                                    nums[i],
                                    nums[j],
                                    -(nums[i] + nums[j])
                                };
                        addedList.Sort();

                        string s = string.Empty;

                        foreach (var item in addedList)
                        {
                            s = s + item.ToString();
                        }

                        //s = addedList.ToString();

                        if (!listWork.Contains(s))
                        {
                            list.Add(addedList);
                            listWork.Add(s);
                        }   
                        addedList = null;
                    }
                }
            }

            return list;
        }

        public static IList<IList<int>> ThreeSumOne(int[] nums)
        {
            var list = new List<IList<int>>();
            var listWork = new List<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        if (i != j && j != k && i != k)
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                var addedList = new List<int>
                                {
                                    nums[i],
                                    nums[j],
                                    nums[k]
                                };
                                addedList.Sort();

                                string s = string.Empty;

                                foreach (var item in addedList)
                                {
                                    s = s + item.ToString();
                                }

                                //s = addedList.ToString();

                                if (!listWork.Contains(s))
                                {
                                    list.Add(addedList);
                                    listWork.Add(s);
                                }
                                addedList = null;
                            }
                        }
                    }
                }
            }

            return list;
        }

        public static string AddBinary(string a, string b)
        {
            return "bla bla bla bla 🤪";
        }

        public static int MySqrt(int x)
        {
            return (int)Math.Floor(Math.Sqrt(x));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Equals(val))
                {
                    nums[i] = int.MinValue;
                    counter++;
                }
            }

            nums.ToList().Sort();
            nums.ToArray();

            return nums.Length - counter;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        if(nums[i] + nums[j] == target)
                            return new int[]{i, j};
                    }
                }
            }
            return null;
        }

        public static int Reverse(int x)
        {
            bool check = false;
            if (x < 0)
            {
                check = true;
                x = x * (-1);
            }

            long m = 0, q = 0;
            while (x > 0)
            {
                q = x % 10;
                m = (m + q) * 10;        //1534236469
                x = x / 10;
            }
            m = m / 10;

            if (m>int.MaxValue)
            {
                return 0;
            }

            if (check)
                m = m * (-1);

            int result = (int)m;
            return result;
        }

        public static int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] str = s.Split(' ');
            return str[str.Length - 1].Length;
            

        }

        public static int ClimbStairs(int n)
        {
            var nums = new int[n];
            if (n==1)
            {
                return 1;
            }
            if (n > 1)
            {
                nums[0] = 1;
                nums[1] = 2;
                for (int i = 2; i < n; i++)
                {
                    nums[i] = nums[i - 2] + nums[i - 1];
                }
                return nums[nums.Length-1];
            }
            return 0;
        }

        public static int MajorityElement(int[] nums)
        {
            int index = 0;
            int counter = 0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    counter++;
                }
                if(max<counter)
                {
                    max = counter;
                    index = i;
                }
                counter = 0;
            }

            return nums[index]; 
        }

        public static int[] PluseOne(int[] digits)
        {
            int i = digits.Length - 1;

            while (i >= 0)
            {
                if (digits[i] == 9 && i == 0)
                {
                    int[] newDigits = new int[i + 2];
                    newDigits[0] = 1;
                    return newDigits;
                }

                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    i--;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            return digits;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int targetIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= target)
                {
                    targetIndex = i;
                    
                }
            }

            return targetIndex;
        }

        public static long PowOn(int a)
        {
            long result = 1;
            for (int i = 0; i < a; i++)
            {
                result = result * 10;
            }
            return result;
        }
    }
}
