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
            int[] numbers = { 1, 1, 3 };

            var nums = PluseOne(numbers);

            foreach (var item in nums)
            {
                Console.Write(item);
            }

        }



        public static string ReverseVowels(string s)    
        {    

            var listVowels = new List<char>{'a', 'A', 'o', 'O', 'u', 'U', 'e', 'E', 'i', 'I'};

            char[] charArray = s.ToCharArray();                       //     h e l l o 
            int left = 0;                                                          //     0 1 2 3 4  
            int right = s.Length - 1;

            while (left < right)
            {
                if(listVowels.Contains(charArray[left]) && (listVowels.Contains(charArray[right])))
                {
                    char c = charArray[left];

                    c = charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = c;

                    left++;
                    right--;
                }
               

                if(listVowels.Contains(charArray[left]) && !listVowels.Contains(charArray[right]))
                    right--;
                else

                if (!listVowels.Contains(charArray[left]) && listVowels.Contains(charArray[right]))
                    left++;

                if(!listVowels.Contains(charArray[left]) && !listVowels.Contains(charArray[right]))
                {
                    left++;
                    right--;
                }
            }

            string str = string.Empty;

            foreach (var item in charArray)
            {
                str = str + item;
            }

            return str;
        }

        #region Linked List funks
        public static void PrintLinkedList(ListNode node)
        {
            while (node.next is not null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var result = new ListNode();

            if (list1 == null)
                return list2;
            else
            {
                if (list2 == null)
                    return list1;
            }


            do
            {
                if (list1.val < list2.val)
                {
                    SetResult(result, new ListNode(list1.val));
                    if (list1.next != null)
                        list1 = list1.next;
                    else
                    {
                        SetResult(result, list2);
                        result = result.next;
                        return result;
                    }

                }
                else
                {
                    SetResult(result, new ListNode(list2.val));
                    if (list2.next != null)
                        list2 = list2.next;
                    else
                    {
                        SetResult(result, list1);
                        result = result.next;
                        return result;
                    }

                }
            }
            while (list1.next != null || list2.next != null);

            if (list1.next == null)
                SetResult(result, list2);

            if (list2.next == null)
                SetResult(result, list1);


            result = result.next;

            return result;
        }

        public static void SetResult(ListNode result, ListNode newNode)
        {
            if (result.next == null)
                result.next = newNode;
            else
                SetResult(result.next, newNode);
        }
        #endregion
        public static int RemoveDuplicates(int[] nums)
        {
            List<int> resultNums = new List<int> ();

            for (int i = 0; i < nums.Length; i++)
            {
                if(!resultNums.Contains(nums[i]))
                    resultNums.Add(nums[i]);
            }

            resultNums.Sort();

            nums = resultNums.ToArray();

            return resultNums.Count;
        }
        public static string RecursiveReverseString(string str)
        {
            if (str.Length == 0)
                return str;

            var reversedStr = RecursiveReverseString(str.Substring(1));
            return reversedStr + str[0];
        }
        public static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                char c = s[left];
                c = s[left];
                s[left] = s[right];
                s[right] = c;

                left++;
                right--;
            }
        }
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);

            return nums[nums.Length / 2];
        }
        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                if(!(i % 3 == 0 || i % 5 == 0))
                    list.Add(i.ToString());

                if (i % 3 == 0 && i % 5 == 0)
                    list.Add("FizzBuzz");
                else
                {
                    if(i % 3 == 0)
                        list.Add("Fizz");
                    else
                    {
                        if (i % 5 == 0)
                            list.Add("Buzz");
                        else
                        {
                            list.Add(i.ToString());
                        }
                    }
                }


            }

            return list;
        }
        public static string ToLowerCase(string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if (((byte)c) >= 65 && ((byte)c) <= 90)
                    sb.Append(((char)(((byte)c)+32)));
                else
                    sb.Append(c);

                c.GetHashCode();
            }

            return sb.ToString();
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0;

            List<int> list = new List<int>();

            foreach (int num in nums1)
            {
                list.Add(num);
            }

            foreach (int num in nums2)
            {
                list.Add(num);
            }

            list.Sort();

            if (list.Count % 2 == 0)
            {
                int index1 = list.Count / 2;
                int index2 = index1 + 1;

                result = ((double)list[index1] + (double)list[index2]) / 2;

            }

            if (list.Count % 2 == 1)
            {
                int index = list.Count / 2;

                result = list[index];
            }

            return result;
        }
        public static int HammingWeight(uint n)
        {
            int sum = 0;
           
            var number = n.ToString().ToCharArray().ToList();

            while(number.Contains('1'))
            {
                sum++;
                int index = number.IndexOf('1');
                number[index] = '0';
            }
            return sum;
        }
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>
            {
                new List<int>{1},
                new List<int>{1, 1},
            };


            IList<int> list1 = new List<int> { 1, 1 };
            IList<int> list2 = new List<int>();
            for (int j = 2; j < numRows; j++)
            {

                int i = 0;
                list2.Add(1);
                while(i <= list1.Count / 2)
                {
                    list2.Add(list1[i] + list1[i + 1]);
                }
                list2.Add(1);

                result.Add(list2);
                list1 = list2;
            }

            return result;
        }
        public static int MissingNumber(int[] nums)
        {
            int result = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                bool check = nums.ToList().Contains(i);
                if (!check)
                {
                    result = i;
                    break;
                }
                
            }

            return result;
        } 
        public static int SingleNumber(int[] nums)
        {
            int target = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                target = nums[i];
                var numsList = nums.ToList();

                numsList.Remove(target);
                if (!numsList.Contains(target))
                {
                    break;
                }
                
            }
            return target;

        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            if (strs.Length == 1)
                return strs[0];

            return new string("ksbcjhdsbc");
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
        public static int[] PluseOne(int[] digits)
        {
           return _PlusOne(digits, digits.Length - 1);
        }
        
        public static int[] _PlusOne(int[] digits, int k)
        {
            if(digits.Length == 0)
            {
                if (digits[0] == 9)
                    return new int[] { 1, 0 };

                digits[0]++;

                return digits;
            }

            if (digits[k] != 9)
            {
                digits[k]++;
                return digits;
            }
            else
            {
                if (k == 0)
                {
                    digits[k] = 1;
                    var numList = digits.ToList();
                    numList.Add(0);
                    return numList.ToArray();
                }
                else
                {
                    digits[k] = 0;
                    return _PlusOne(digits, --k);
                }
            }
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int targetIndex = 0;
            if (nums.Contains(target))
                return nums.ToList().IndexOf(target);
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < target)
                    {
                        targetIndex = i+1;
                        break;
                    }
                    
                }

                return targetIndex;
            }

            //return targetIndex;
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

    #region Classes
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int value = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    #endregion
}
