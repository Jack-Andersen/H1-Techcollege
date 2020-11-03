using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private static IEnumerable<bool> testArray;

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

            static int StackBoxes(int n)
            {

                double result = Math.Pow(n, 2);

                return (int)result;

            }



            //Convert Hours into Seconds 30

            //Write a function that converts hours into seconds.

            //Examples
            //howManySeconds(2) ➞ 7200

            //howManySeconds(10) ➞ 36000

            //howManySeconds(24) ➞ 86400
            //Notes
            //60 seconds in a minute, 60 minutes in an hour.
            //Don't forget to return your answer.

            static int HowManySecound(int hours)
            {
                return hours * 60 * 60;
            }



            //Is the Last Character an N? 31

            //Create a function that takes a string(a random name).If the last character of the name is an "n", return true, otherwise return false.

            //Examples
            //isLastCharacterN("Aiden") ➞ true

            //isLastCharacterN("Piet") ➞ false

            //isLastCharacterN("Bert") ➞ false

            //isLastCharacterN("Dean") ➞ true
            //Notes
            //The function must return a boolean value(i.e. true or false).

            static bool isLastCharaterN(string word)
            {

                if (word.EndsWith("n"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //How Many D's Are There? 32

            //Create a function that counts how many D's are in a sentence.

            //Examples
            //CountDs("My friend Dylan got distracted in school.") ➞ 4

            //CountDs("Debris was scattered all over the yard.") ➞ 3

            //CountDs("The rodents hibernated in their den.") ➞ 3
            //Notes
            //Your function must be case-insensitive.
            //Remember to return the result.
            //Check the Resources for help.

            static int CountDS(string str)
            {

                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {

                    if (str[i] == 'D' || str[i] == 'd') ++count;

                }

                return count;

            }



            //How Much is True? 33

            //Create a function which returns the number of true values there are in an array.

            //Examples
            //CountTrue([true, false, false, true, false]) ➞ 2

            //CountTrue([false, false, false, false]) ➞ 0

            //CountTrue([]) ➞ 0
            //Notes
            //Return 0 if given an empty array.
            //All array items are of the type bool(true or false).

            static int CountTrue(bool[] arr)
            {

                int counter = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == true) counter++;
                }
                return counter;

            }



            //Raucous Applause 34

            //fter an amazing performance, the crowd goes wild! People clap enthusiastically and most claps overlap with each other to create one homogeneous sound.

            //An overlapped clap is a clap which starts but doesn't finish, as in "ClaClap" (the first clap is cut short and there are overall 2 claps).

            //Given a string of what the overlapping claps sounded like, return how many claps were made in total.

            //Examples
            //CountClaps("ClaClaClaClap!") ➞ 4

            //CountClaps("ClClClaClaClaClap!") ➞ 6

            //CountClaps("CCClaClClap!Clap!ClClClap!") ➞ 9
            //Notes
            //Each clap starts with a capital "C".

            static int CountClaps(string txt)
            {
                int clapCounter = 0;
                for (int i = 0; i < txt.Length; i++)
                {
                    if (txt[i] == 'C')
                    {
                        clapCounter++;

                    }
                }

                return clapCounter;

            }



            //Shapes With N Sides 35

            //Create a function that takes a whole number as input and returns the shape with that number's amount of sides. Here are the expected outputs to get from these inputs.

            //Inputs Outputs
            //1   "circle"
            //2   "semi-circle"
            //3   "triangle"
            //4   "square"
            //5   "pentagon"
            //6   "hexagon"
            //7   "heptagon"
            //8   "octagon"
            //9   "nonagon"
            //10  "decagon"
            //Examples
            //NSidedShape(3) ➞ "triangle"

            //NSidedShape(1) ➞ "circle"

            //NSidedShape(9) ➞ "nonagon"
            //Notes
            //There won't be any tests with a number below 1 or greater than 10.
            //Return the output in lowercase.
            //The challenge is intended to be completed without conditionals(it would take too long)!

            static string NSidedShape(int n)
            {
                string[] shapes = {"circle", "semi-circle", "triangle", "square","pentagon",
                "hexagon",
                "heptagon",
                "octagon",
                "nonagon",
                "decagon"};

                return shapes[n - 1];

            }



            //Convert Hours and Minutes into Seconds 36

            //Write a function that takes two integers(hours, minutes), converts them to seconds, and adds them.

            //Examples
            //Convert(1, 3) ➞ 3780

            //Convert(2, 0) ➞ 7200

            //Convert(0, 0) ➞ 0
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            static int Convert(int hours, int minutes)
            {
               int h = hours * 3600;
               int m = minutes * 60;

               return h + m;
            }



            //String to Integer and Vice Versa 37

            //Write two functions:

            //toInt() : A function to convert a string to an integer.
            //toStr() : A function to convert an integer to a string.
            //Examples
            //toInt("77") ➞ 77

            //toInt("532") ➞ 532

            //toStr(77) ➞ "77"

            //toStr(532) ➞ "532"
            //Notes
            //Don't forget to return the result.
            //If you get stuck on a challenge, find help in the Resources tab.
            //If you're really stuck, unlock solutions in the Solutions tab.

            //public static int toInt(string str)
            //{
            //    return Convert.ToInt32(str);
            //}
            //public static string toStr(int num)
            //{
            //    return Convert.ToString(num);
            //}



            //No Conditionals? 38

            //Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.

            //Examples
            //Flip(1) ➞ 0

            //Flip(0) ➞ 1
            //Notes
            //Try completing this challenge without using any:

            //Conditionals
            //Ternary operators
            //Negations
            //Bit operators

            static int Flip(int y)
            {
                return 1 - y;
            }



            //Hashes and Pluses 39

            //Create a function that returns the number of hashes and pluses in a string.

            //Examples
            //HashPlusCount("###+") ➞ [3, 1]

            //HashPlusCount("##+++#") ➞ [3, 3]

            //HashPlusCount("#+++#+#++#") ➞ [4, 6]

            //HashPlusCount("") ➞ [0, 0]
            //Notes
            //Return[0, 0] for an empty string.
            //Return in the order of[hashes, pluses].

            static int[] HashPlusCount(string s)
            {
                int hash = 0;
                int plus = 0;

                char[] arr = s.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    if (arr[i] == '#')
                    {
                        hash++;
                    }
                    if (arr[i] == '+')
                    {
                        plus++;
                    }
                }
                int[] ans = { hash, plus };
                return ans;
            }



            //The Study of Wumbology 40

            //Create a function that flips M's to W's(all uppercase).

            //Examples
            //wumbo("I LOVE MAKING CHALLENGES") ➞ "I LOVE WAKING CHALLENGES"

            //wumbo("MEET ME IN WARSAW") ➞ "WEET WE IN WARSAW"

            //wumbo("WUMBOLOGY") ➞ "WUWBOLOGY"
            //Notes
            //N / A

            static string wumbo(string words)
            {
                return words.Replace("m", "w").ToUpper();
            }



            //Get the File Name 41

            //Create a function that returns the selected filename from a path.Include the extension in your answer.

            //Examples
            //GetFilename("C:/Projects/pil_tests/ascii/edabit.txt") ➞ "edabit.txt"

            //GetFilename("C:/Users/johnsmith/Music/Beethoven_5.mp3") ➞ "Beethoven_5.mp3"

            //GetFilename("ffprobe.exe") ➞ "ffprobe.exe"
            //Notes
            //Tests will include both absolute and relative paths.
            //For simplicity, all paths will include forward slashes.

            static string GetFilename(string path)
            {

                return path.Split('/').Last();

            }



            //Burrrrrrrp 42

            //Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.

            //Examples
            //LongBurp(3) ➞ "Burrrp"

            //LongBurp(5) ➞ "Burrrrrp"

            //LongBurp(9) ➞ "Burrrrrrrrrp"
            //Notes
            //Expect num to always be >= 1.
            //Remember to use a capital "B".
            //Don't forget to return the result.

            static string Longburp(int b)
            {

                string r = new string('r', b);
                return $"Bu{r}p";
            }



            //Reverse and Capitalize 43

            //Create a function that takes a string of lowercase characters and returns that string reversed and in upper case.

            //Examples
            //ReverseCapitalize("abc") ➞ "CBA"

            //ReverseCapitalize("hellothere") ➞ "EREHTOLLEH"

            //ReverseCapitalize("input") ➞ "TUPNI"

            static string ReverseCapitalze(string str)
            {

                return new string(str.ToUpper().Reverse().ToArray());

            }



            //Recursion to Repeat a String n Number of Times 44

            //Create a recursive function that takes two parameters and repeats the string n number of times.The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.

            //Examples
            //Repetition("ab", 3) ➞ "ababab"

            //Repetition("kiwi", 1) ➞ "kiwi"

            //Repetition("cherry", 2) ➞ "cherrycherry"
            //Notes
            //The second parameter of the function is positive integer.

            static string Repetition(string txt, int n)
            {
                string Txt = "";
                if (n > 0)
                {
                    Txt = txt + Repetition(txt, n - 1);
                }
                return Txt;
            }



            //Re - Form the Word 45

            //A word has been split into a left part and a right part.Re - form the word by adding both halves together, changing the first character to an uppercase letter.

            //Examples
            //GetWord("seas", "onal") ➞ "Seasonal"

            //GetWord("comp", "lete") ➞ "Complete"

            //GetWord("lang", "uage") ➞ "Language"
            //Notes
            //N / A

            static string GetWord(string left, string right)
            {
                string str = System.String.Concat(left, right);
                str = char.ToUpper(str[0]) + str.Substring(1);
                return str;
            }



            //Modifying the Last Character 46

            //Create a function which makes the last character of a string repeat n number of times.

            //Examples
            //ModifyLast("Hello", 3) ➞ "Hellooo"

            //ModifyLast("hey", 6) ➞ "heyyyyyy"

            //ModifyLast("excuse me what?", 5) ➞ "excuse me what?????"
            //Notes
            //Test will include numbers and punctuation.
            //Make sure the code is not case sensitive.

            static string ModifyLast(string str, int n)
            {

                return str + new string(str[str.Length - 1], n - 1);

            }



            //Date Format 47

            //Create a function that converts a date formatted as MM / DD / YYYY to YYYYDDMM.

            //Examples
            //FormatDate("11/12/2019") ➞ "20191211"

            //FormatDate("12/31/2019") ➞ "20193112"

            //FormatDate("01/15/2019") ➞ "20191501"
            //Notes
            //Return value should be a string.

            static string FormatDate(string date)
            {

            }

        }
    }
}
