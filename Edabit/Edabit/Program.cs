using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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



            //Return a String as an Integer 14

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



            //Find the Perimeter of a Rectangle 15

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



            //Reverse an Array 16

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



            //Add, Subtract, Multiply or Divide ? 17

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



            //Is the String Odd or Even? 18

            //Given a string, return true if its length is even or false if the length is odd.

            //Examples
            //oddOrEven("apples") ➞ true

            //oddOrEven("pears") ➞ false

            //oddOrEven("cherry") ➞ true
            //Notes
            //N / A

            static string OddOrEven(string word)
            {

                    return (word.Length % 2 == 0).ToString();

            }



            //Both Zero, Negative or Positive 19

            //Write a function that returns true if both numbers are:

            //Smaller than 0, OR...
            //Greater than 0, OR...
            //Exactly 0
            //Otherwise, return false.

            //Examples
            //Both(6, 2) ➞ true

            //Both(0, 0) ➞ true

            //Both(-1, 2) ➞ false

            //Both(0, 2) ➞ false
            //Notes
            //Inputs will always be two numbers.

            static bool Both(int n1, int n2)
            {
                if ((n1 + n2 == 0) || (n1 > 0 && n2 > 0) || n1 < 0 && n2 < 0)
                {
                    return true;
                }
                else
                    return false;
            }



            //Recursion: Length of a String 20

            //Write a function that returns the length of a string.Make your function recursive.

            //Examples
            //Length("apple") ➞ 5

            //Length("make") ➞ 4

            //Length("a") ➞ 1

            //Length("") ➞ 0
            //Notes
            //Check the Resources tab for info on recursion.

            static int Length(string str) => str.Length;



            //Name Greeting! 21

            //Create a function that takes a name and returns a greeting in the form of a string.

            //Examples
            //HelloName("Gerald") ➞ "Hello Gerald!"

            //HelloName("Tiffany") ➞ "Hello Tiffany!"

            //HelloName("Ed") ➞ "Hello Ed!"
            //Notes
            //The input is always a name(as string).
            //Don't forget the exclamation mark!
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static string HelloName(string name)
            {
                return "Hello " + name + "!";
            }



            //Are the Numbers Equal? 22

            //Create a function that takes two integers and checks if they are equal.

            //Examples
            //IsEqual(5, 6) ➞ false

            //IsEqual(1, 1) ➞ true

            //IsEqual(36, 35) ➞ false
            //Notes
            //N / A

            static bool IsEqual(int num1, int num2)
            {
                if (num1.Equals(num2))
                {
                    return true;
                }
                else
                    return false;
            }



            //Char - to - ASCII 23

            //Create a function that returns the ASCII value of the passed in character.

            //Examples
            //CharToASCII('S') ➞ 83

            //CharToASCII('m') ➞ 109

            //CharToASCII('1') ➞ 49

            //CharToASCII('a') ➞ 97
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int CharToASCII(char ch)
            {

                int i = ch;
                return i;

            }



            //Drinks Allowed? 24

            //A bartender is writing a simple program to determine whether he should serve drinks to someone.He only serves drinks to people 18 and older and when he's not on break.

            //Given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.

            //Examples
            //ShouldServeDrinks(17, true) ➞ false

            //ShouldServeDrinks(19, false) ➞ true

            //ShouldServeDrinks(30, true) ➞ false
            //Notes
            //Return true or false.
            //Some countries have a slightly higher drinking age, but for the purposes of this challenge, it will be 18.

            static bool ShouldServeDrinks(int age, bool on_break)
            {
                if (age >= 18 && !on_break)
                {
                    return true;
                }
                else
                    return false;
            }


            
            //Lowercase, Uppercase or Mixed ? 25

            //Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.

            //Examples
            //GetCase("whisper...") ➞ "lower"

            //GetCase("SHOUT!") ➞ "upper"

            //GetCase("Indoor Voice") ➞ "mixed"
            //Notes
            //Ignore punctuation, spaces and numbers.

            static string GetCase(string str)
            {

                if (str == str.ToLower())
                {
                    return "lower";
                }

                else if (str == str.ToUpper())
                {
                    return "upper";
                }

                else
                    return "mixed";
            }


            
            //Concatenating First and Last Character of a String 26

            //Creates a function that takes a string and returns the concatenated first and last character.

            //Examples
            //FirstLast("forza") ➞ "fa"

            //FirstLast("kali") ➞ "ki"

            //FirstLast("always") ➞ "as"

            //FirstLast("love") ➞ "le"

            //FirstLast("edabit") ➞ "et"
            //Notes
            //There is no empty string.

            static string FirstLast(string str)
            {
                {
                    string s = string.Empty;
                    s += str[0];
                    s += str[str.Length - 1];
                    return s;
                }
            }



            //On / Off Switches 27

            //Create a function that returns how many possible outcomes can come from a certain number of switches(on / off). In other words, for a given number of switches, how many different combinations of on and off can we have ?

            //Examples
            //PosCom(1) ➞ 2


            //PosCom(3) ➞ 8


            //PosCom(10) ➞ 1024
            //Notes
            //All numbers will be whole and positive.

            static int PosCom(int n)
            {
                double result = Math.Pow(2, n);

                return (int)result;
            }



            //Smash Factor 28

            //Smash factor is a term in golf that relates to the amount of energy transferred from the club head to the golf ball.The formula for calculating smash factor is ball speed divided by club speed.


            //Create a function that takes ball speed bs and club speed cs as arguments and returns the smash factor to the nearest hundredth.


            //Examples
            //SmashFactor(139.4, 93.8) ➞ 1.49


            //SmashFactor(181.2, 124.5) ➞ 1.46


            //SmashFactor(154.7, 104.3) ➞ 1.48
            //Notes
            //Remember to round to the nearest hundredth.
            //All values will be valid(so no dividing by zero).

            static double SmashFactor(double a, double b)
            {

                return Math.Round(a / b, 2);

            }



            //Stack the Boxes 29

            //Here's an image of four models. Some of the cubes are hidden behind other cubes. Model one consists of one cube. Model two consists of four cubes, and so on...

            //Stack the Boxes

            //Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.

            //Examples
            //StackBoxes(1) ➞ 1

            //StackBoxes(2) ➞ 4

            //StackBoxes(0) ➞ 0
            //Notes
            //Step n is a positive integer.

            static int StackBoxes(int n);



        }
    }
}
