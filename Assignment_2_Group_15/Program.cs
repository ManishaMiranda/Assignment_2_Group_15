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

            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "cba";
            Console.WriteLine("Time taken to type with one finger = {0}\n", CalculateTime(keyboard, word));

            int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };
            int[,] flipAndInvertedImage = FlipAndInvertImage(image);
            Console.WriteLine("The resulting flipped and inverted image is:\n");
            Display2DArray(flipAndInvertedImage);
            Console.Write("\n");

            int[,] intervals = { { 0, 30 }, { 5, 10 }, { 15, 20 } };
            int minMeetingRooms = MinMeetingRooms(intervals);
            Console.WriteLine("Minimum meeting rooms needed = {0}\n", minMeetingRooms);

            int[] arr = { -4, -1, 0, 3, 10 };
            int[] sortedSquares = SortedSquares(arr);
            Console.WriteLine("Squares of the array in sorted order is:");
            DisplayArray(sortedSquares);
            Console.Write("\n");

            string s = "abca";
            if (ValidPalindrome(s))
            {
                Console.WriteLine("The given string \"{0}\" can be made PALINDROME", s);
            }
            else
            {
                Console.WriteLine("The given string \"{0}\" CANNOT be made PALINDROME", s);
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
                // Write your code here
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
            }
            catch
            {
                Console.WriteLine("Exception occured while computing ValidPalindrome()");
            }

            return false;
        }
    }
}
    

