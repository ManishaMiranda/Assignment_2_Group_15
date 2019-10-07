using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2_Group_15
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Q1
            int result = SearchInsert((new int[] { 23, 25, 33, 54, 78 }), 35);
            Console.WriteLine("Q1: " + "The index of target number is: " + result);
            Console.ReadLine();

            ////Q2
            var intersection = Intersect(new int[] { 1, 2, 2 }, new int[] { 2, 2 });
            Console.WriteLine("Q2: " + "The numbers in the intersection are as follows:");
            foreach (var num in intersection)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

            //////Q3
            int Value = LargestUniqueNumber((new int[] { 1, 2, 2, 3, 3 }));
            Console.WriteLine("Q3: " + "The max qualified Value is: " + Value);
            Console.ReadKey();

            ////Q4
            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "cba";
            Console.WriteLine("Q4: Time taken to type with one finger = {0}\n", CalculateTime(keyboard, word));

            int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };
            int[,] flipAndInvertedImage = FlipAndInvertImage(image);
            Console.WriteLine("Q5: The resulting flipped and inverted image is:\n");
            Display2DArray(flipAndInvertedImage);
            Console.Write("\n");

            int[,] intervals = { { 0, 30 }, { 5, 10 }, { 15, 20 } };
            int minMeetingRooms = MinMeetingRooms(intervals);
            Console.WriteLine("Q6: Minimum meeting rooms needed = {0}\n", minMeetingRooms);

            int[] arr = { -4, -1, 0, 3, 10 };
            int[] sortedSquares = SortedSquares(arr);
            Console.WriteLine("Q7: Squares of the array in sorted order is:");
            DisplayArray(sortedSquares);
            Console.Write("\n");

            string s = "abca";
            if (ValidPalindrome(s))
            {
                Console.WriteLine("Q8: The given string \"{0}\" can be made PALINDROME", s);
            }
            else
            {
                Console.WriteLine("Q8: The given string \"{0}\" CANNOT be made PALINDROME", s);
            }
        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        public static void Display2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }

        public static int SearchInsert(int[] arr, int key)
        {
            int res = 0;
            try
            {
                int min = 0;
                int max = arr.Length - 1;
                int val = 0;
                int mid = (min + max) / 2;
                if (key < arr[0])
                    return 0;
                else if (key > arr[max])
                    return max + 1;

                while (min < max)
                {

                    val = arr[mid];

                    if (val == key)
                        return mid;

                    if (key < val)
                        max = mid;
                    else if (key > val && min != max - 1)
                        min = mid;
                    else
                        return min + 1;

                    val = arr[mid];

                    if (val == key)
                        return mid;

                    if (min == max - 1 && key != arr[min])
                        return min + 1;

                    mid = (min + max) / 2;
                }

                // return res;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing SearchInsert()");
            }
            return res;
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dic1 = new Dictionary<int, int>();
            var dic2 = new Dictionary<int, int>();
            List<int> common = new List<int>();
            try
            {

                for (int i = 0; i < nums1.Length; i++)
                {
                    dic1.Add(i, nums1[i]);
                }

                for (int i = 0; i < nums2.Length; i++)
                {
                    dic2.Add(i, nums2[i]);
                }

                foreach (var dic in dic1)
                {
                    if (dic2.ContainsValue(dic.Value))
                    {

                        common.Add(dic.Value);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");
            }
            return common.ToArray();
        }

        static int LargestUniqueNumber(int[] nums1)
        {
            var dic1 = new Dictionary<int, int>();
            int max = -1;
            try
            {

                for (int i = 0; i < nums1.Length; i++)
                {
                    dic1.Add(i, nums1[i]);
                }

                foreach (var key in dic1)
                {
                    var dic = dic1.Where(x => x.Value == key.Value);

                    if (dic.Count() == 1 && key.Value > max)
                        max = key.Value;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing LargestUniqueNumber()");
            }
            return max;
        }

        public static int CalculateTime(string keyboard, string word)
        {
            try
            {
                
                int diff = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0) { diff = keyboard.IndexOf(word[i]); }

                    else
                    {

                        diff = diff + Math.Abs(keyboard.IndexOf(word[i - 1]) - keyboard.IndexOf(word[i]));

                    }
                }


                return diff;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing CalculateTime()");
            }

            return 0;
        }

        public static int[,] FlipAndInvertImage(int[,] A)
        {
            try
            {
                // Write your code here
                int r = A.GetLength(0);
                int c = A.GetLength(1);
                int[,] temp = new int[r, c];
                for (int i = 0; i < r; i++)
                {


                    for (int j = c - 1; j >= 0; j--)
                    {
                        temp[i, c - 1 - j] = 1 - A[i, j];

                    }


                }

                return temp;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing FlipAndInvertImage()");
            }

            return new int[,] { };
        }

        public static int MinMeetingRooms(int[,] intervals)
        {
            try
            {
                // Write your code here
                List<int> start_time = new List<int>();
                List<int> end_time = new List<int>();
                for (int i = 0; i < intervals.GetLength(0); i++)
                {
                    start_time.Add(intervals[i, 0]);
                }
                for (int i = 0; i < intervals.GetLength(0); i++)
                {
                    end_time.Add(intervals[i, 1]);
                }
                start_time.Sort();
                end_time.Sort();
                int k = 0, j = 0, rooms = 0;

                while (k < intervals.GetLength(0))
                {
                    if (start_time[k] < end_time[j])
                    {
                        k++;
                    }

                    else if (start_time[k] > end_time[j])
                    {
                        j++;
                    }
                    rooms = Math.Max(rooms, k - j);
                }
                return rooms;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing MinMeetingRooms()");
            }

            return 0;
        }

        public static int[] SortedSquares(int[] A)
        {
            try
            {
                // Write your code here
                int length = A.Length;
                int k;
                for (k = 0; k < length; k++)
                {
                    if (A[k] >= 0) break;
                }

                int m = 0; int i = k - 1; int j = k;



                int[] sortedSquares = new int[length];
                while (i >= 0 && j < length)
                {
                    if (A[i] * A[i] < A[j] * A[j])
                    {
                        sortedSquares[m] = A[i] * A[i];
                        i = i - 1;
                    }
                    else
                    {
                        sortedSquares[m] = A[j] * A[j];
                        j++;
                    }
                    m = m + 1;
                }

                while (i >= 0)
                {
                    sortedSquares[m++] = A[i] * A[i];
                    i--;
                }
                while (j < length)
                {
                    sortedSquares[m++] = A[j] * A[j];
                    j++;
                }


                return sortedSquares;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing SortedSquares()");
            }

            return new int[] { };
        }

        public static bool ValidPalindrome(string s)
        {
            try
            {
                // Write your code here
                int left = 0; int right = s.Length - 1;
                bool PalindromeCheck(string r)
                {
                    int length = r.Length;
                    for (int i = 0; i < length / 2; i++)
                    {
                        if (r[i] != r[length - i - 1])
                            return false;
                    }
                    return true;
                }


                while (left < right)
                {
                    if (s[left] == s[right])
                    {
                        left = left + 1; right = right - 1;
                    }

                    else
                    {
                        if (PalindromeCheck(s.Substring(left + 1, right - left)) || PalindromeCheck(s.Substring(left, right - left)))
                        {
                            return true;
                        }

                        else return false;
                    }
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing ValidPalindrome()");
            }

            return false;
        }
    }
}
    

