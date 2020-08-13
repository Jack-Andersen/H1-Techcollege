using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Describe an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            //Write your solution here

            int tmp;

            tmp = x;
            x = y;
            y = tmp;

        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * 2.Describe an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (y, z, x).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int a, ref int b, ref int c)
        {
            //Write your solution here

            int tmp;

            tmp = a;
            a = c;
            c = b;
            b = tmp;
            


        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Describe an algorithm for determining whether a string of n characters is a palindrome.
         */
        public static bool IsPalindrome(string s)
        {
            //throw new NotImplementedException();
            //Write your solution here

            string first = s.Substring(0, s.Length - 1);
            char[] arr = s.ToCharArray();

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length - 1);

            return first.Equals(second);

        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            //throw new NotImplementedException();
            //Write your solution here

            for (int i = 0; i < intergerArray.Length; i++)
            {
                if (searchFor == intergerArray[i])
                {
                    return i +1;
                }
            }

            return -1;

        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11 
         * Do this by completing the unit test for 4B
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            //throw new NotImplementedException();
            //Write your solution here
            int start = arrayStart;
            int end = arrayEnd; 
            int mid = 0;
            int count = 0;

            while(searchFor != integerArray[mid])
            {
                count++;
                mid = (start + end) / 2;
                if (searchFor < integerArray[mid])
                    end = mid - 1;
                if (searchFor > integerArray[mid])
                    start = mid + 1;
            }

            return count;

        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            //throw new NotImplementedException();
            //Write your solution here

            int postion = 0;

            for (int i = 0; i < sortedList.Count()-1; i++)
            {
                if (insert > sortedList[i])
                {
                    postion = i;
                }
            }

            sortedList.Insert(postion+1, insert);

            return postion+1;

        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            //throw new NotImplementedException();
            //Write your solution here

            int[] arr = Enumerable.Range(num, length).ToArray();
            //int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = num * (i + 1);
            }

            return arr;

        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            //throw new NotImplementedException();
            //Write your solution here

            int number = 0;
            int startnumber = 0;
            int count = 0;

            while (number < max)
            {
                number = (int)Math.Pow(startnumber++, power);
                if (number >= min && number <= max)
                    count++;
            }

            return count;

        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            //throw new NotImplementedException();
            //Write your solution here

            long result = 1;

            while (n >= 1)
            {
                result = result * n;
                n = n - 1;
            }

            return result;

        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         */
        public static string IncrementString(string txt)
        {
            //throw new NotImplementedException();
            //Write your solution here

            int number = 0;
            string newtxt = "";

            string[] newData = new string[txt.Length];
            string digits = new string(txt.Where(char.IsDigit).ToArray());
            string letters = new string(txt.Where(char.IsLetter).ToArray());

            if (digits.Length > 0)
            {
                number = int.Parse(digits);
                if(number.ToString().Length != txt.Length)
                {
                    number++;
                    while ((letters + (number).ToString()).Length < txt.Length)
                    {
                        letters = letters + "0";
                    }
                    newtxt = letters + (number).ToString();
                }
            }
            else
            {

                digits = "1";
                newtxt = letters + digits;

            }

            return newtxt;

        }
    }
}