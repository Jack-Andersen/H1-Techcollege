using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Schema;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return Something to Me! 1

            // Write a function that returns the string "something" joined with a space " " and the given argument a.

            //Examples
            //GiveMeSomething("is better than nothing") ➞ "something is better than nothing"

            //GiveMeSomething("Bob Jane") ➞ "something Bob Jane"

            //GiveMeSomething("something") ➞ "something something"

            static string GiveMeSomething(string a)
            {
                return "something " + a;
            }




            //Using the "&&" Operator 2

            //C# has a logical operator &&. The && operator takes two boolean values, and returns true if both values are true.

            //Consider a && b:

            //a is checked if it is true or false.
            //If a is false, false is returned.
            //b is checked if it is true or false.
            //If b is false, false is returned.
            //Otherwise, true is returned(as both a and b are therefore true ).
            //The && operator will only return true for true && true.

            //Make a function using the && operator.

            static bool And(bool x, bool y)
            {
                if (x == true && y == true)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }



            //A Circle and Two Squares 3

            //Imagine a circle and two squares: a smaller and a bigger one. For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
            //Create a function, that takes an integer(radius of the circle) and returns the difference of the areas of the two squares.

            //            Examples
            //square_areas_difference(5) ➞ 50

            //square_areas_difference(6) ➞ 72

            //square_areas_difference(7) ➞ 98

            static int square_areas_difference(int radius)
            {

                return 2 * radius * radius;

            }



            // Football 4

            // Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.

            //wins get 3 points
            //draws get 1 point
            //losses get 0 points
            //Examples
            //FootballPoints(3, 4, 2) ➞ 13

            //FootballPoints(5, 0, 2) ➞ 15

            //FootballPoints(0, 0, 1) ➞ 0

            static int footballPoints(int wins, int draws, int losses)
            {
                int w = wins * 3;
                int d = draws * 1;
                int l = losses * 0;

                return w + d + l;
            }



            //Inches to Feet 5
            //Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

            //Examples
            //inchesToFeet(324) ➞ 27

            //inchesToFeet(12) ➞ 1

            //inchesToFeet(36) ➞ 3
            //Notes
            //If inches are under 12, return 0.

            static int inchesToFeet(int inches)
            {

                int result = 0;

                if (inches == 12)
                {
                    return 1;
                }

                result = inches / 12;

                if (result < 12)
                {
                    return 0;
                }
                else
                {
                    return result;
                }
            }



            //Convert All Array Objects to String 6

            //Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.

            //Examples
            //ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]
            //Notes
            //If you get stuck on a challenge, find help in the Resources tab.

            static string[] ParseArray(object[] arr)
            {
                string arr2 = Array.ConvertAll(arr, x => x).ToString();

                return new[] { arr2 };
            }



            //Maximum Edge of a Triangle 7

            //Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.

            //Examples
            //NextEdge(8, 10) ➞ 17

            //NextEdge(5, 7) ➞ 11

            //NextEdge(9, 2) ➞ 10
            //Notes
            //(side1 + side2) - 1 = maximum range of third edge.
            //The side lengths of the triangle are positive integers.
            //Don't forget to return the result.

            static int NextEdge(int side1, int side2)
            {
                return side1 + side2 - 1;
            }



            //Return the First Element in an Array 8

            //Create a function that takes an array and returns the first element.

            //Examples
            //GetFirstValue([5, 6, 7]) ➞ 5

            //GetFirstValue(["Semiramis", "Gaia", "Hypatia"]) ➞ "Semiramis"

            //GetFirstValue([true, false, true]) ➞ true
            //Notes
            //The first element in an array always has an index of 0.

            static object GetFirstValue(object[] arr)
            {
                return arr[0];
            }



            //Free Coffee Cups 9

            //For each of the 6 coffee cups I buy, I get a 7th cup free.In total, I get 7 cups.Create a function that takes n cups bought and return the total number of cups I would get.

            //Examples
            //TotalCups(6) ➞ 7

            //TotalCups(12) ➞ 14

            //TotalCups(213) ➞ 248
            //Notes
            //Number of cups I bought +number of cups I got for free.
            //Only valid inputs will be given.

            static int TotalCups(int n)
            {

                return n / 6 + n;

            }



            //Frames Per Second 10

            //Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.

            //Examples
            //Frames(1, 1) ➞ 60

            //Frames(10, 1) ➞ 600

            //Frames(10, 25) ➞ 15000
            //Notes
            //FPS stands for "frames per second" and it's the number of frames a computer screen shows every second.

            static int Frames(int minutes, int fps)
            {
                int Result = minutes * fps;

                return Result;

            }



            //Correct the Mistakes 11

            //Fix the code in the code tab to pass this challenge(only syntax errors).Look at the examples below to get an idea of what the function should do.


            //Examples 13
            //Squa        red(5) ➞ 25

            //Squared(9) ➞ 81 
            //Squared(100) ➞ 10000
            //Notes
            //READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
            //Don't overthink this challenge; it's not supposed to be hard.

            static int squaed(int a, int b)
            {
                int result = a * b;

                return result;
            }



            //Broken Bridge 12

            //Create a function which validates whether a bridge is safe to walk on(i.e.has no gaps in it to fall through).

            //Examples
            //IsSafeBridge("####") ➞ true

            //IsSafeBridge("## ####") ➞ false

            //IsSafeBridge("#") ➞ true
            //Notes
            //You can expect the bridge's ends connecting it to its surrounding.

            static bool IsSafeBridge(string str)
            {
                {

                    return !(str.Contains(" "));

                }
            }



            //Are the Numbers Equal? 13

            //Create a function that returns true when num1 is equal to num2; otherwise return false.

            //Examples
            //IsSameNum(4, 8) ➞ false

            //IsSameNum(2, 2) ➞  true

            //IsSameNum(0, 6) ➞ false
            //Notes
            //Don't forget to return the result.

            static bool IsSameNum(int num1, int num2)
            {
                if (num1.Equals(num2))
                {
                    return true;
                }
                else
                    return false;
            }



            //Return a String as an Integer

            //Create a function that takes a string and returns it as an integer.

            //Examples
            //StringInt("6") ➞ 6

            //StringInt("1000") ➞ 1000

            //StringInt("12") ➞ 12
            //Notes
            //All numbers will be whole.
            //All numbers will be positive.

            static int StringInt(string txt)
            {
                return int.Parse(txt);
            }



            //Find the Perimeter of a Rectangle

            //Create a function that takes length and width and finds the perimeter of a rectangle.

            //Examples
            //FindPerimeter(6, 7) ➞ 26

            //FindPerimeter(20, 10) ➞ 60

            //FindPerimeter(2, 9) ➞ 22
            //Notes
            //Don't forget to return the result.
            //If you're stuck, find help in the Resources tab.
            //If you're really stuck, find solutions in the Solutions tab.

            static int FindPerimenter(int lenght, int width)
            {
                return (lenght + width) * 2;

            }



            //Reverse an Array

            //Write a function to reverse an array.

            //Examples
            //Reverse(new int[] { 1, 2, 3, 4 }) ➞ { 4, 3, 2, 1}

            //Reverse(new int[] { 9, 9, 2, 3, 4 }) ➞ { 4, 3, 2, 9, 9}

            //Reverse(new int[] { }) ➞ { }
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int[] Reverse(int[] arr)
            {

                return arr.Reverse().ToArray();

            }



            //Add, Subtract, Multiply or Divide ?

            //Write a function that takes two numbers and returns if they should be added, subtracted, multiplied or divided to get 24.If none of the operations can give 24, return "none".

            //Examples
            //Operation(15, 9) ➞ "added"

            //Operation(26, 2) ➞ "subtracted"

            //Operation(11, 11) ➞ "none"
            //Notes
            //Only integers are used as test input.
            //Numbers should be added, subtracted, divided or multiplied in the order they appear in the parameters.
            //The function should return either "added", "subtracted", "divided", "multiplied" or "none".

            static string Operation(int num1, int num2)
            {
                if (num1 + num2 == 24)
                {
                    return "added";
                }
                else if(num1 - num2 == 24)
                {
                    return "subtracted";
                }
                else if(num1 * num2 == 24)
                {
                    return "multiplied";
                }
                else if(num1 / num2 == 24)
                {
                    return "divided";
                }
                else
                {
                    return "none";
                }
            }



            //Is the String Odd or Even?

            //Given a string, return true if its length is even or false if the length is odd.

            //Examples
            //oddOrEven("apples") ➞ true

            //oddOrEven("pears") ➞ false

            //oddOrEven("cherry") ➞ true
            //Notes
            //N / A

            static string OddOrEven(string word)
            {
                
            }

        }
    }
}
