using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
                    return(true); 
                }
                else 
                {
                    return  (false); 
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



            //Return the First Element in an Array 6

            //Create a function that takes an array and returns the first element.

            //Examples
            //GetFirstValue([5, 6, 7]) ➞ 5

            //GetFirstValue(["Semiramis", "Gaia", "Hypatia"]) ➞ "Semiramis"

            //GetFirstValue([true, false, true]) ➞ true
            //Notes
            //The first element in an array always has an index of 0.

            static object GetFirstValue(object[] arr)
            {

                

            }
        }
    }
}
