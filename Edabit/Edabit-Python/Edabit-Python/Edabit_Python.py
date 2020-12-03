
#How Edabit Works 1

#This is an introduction to how challenges on Edabit work. In the Code tab above you'll see a starter function that looks like this:

#def hello():
#All you have to do is type return "hello edabit.com" on the second line and then click the Check button. If you did this correctly, the button will turn red and say SUBMIT FINAL. Click it and see what happens.

#Notes
#The returned string must be in all lowercase letters.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def hello():
	return "hello edabit.com"



#Convert Minutes into Seconds 2

#Write a function that takes an integer minutes and converts it to seconds.

#Examples
#convert(5) ➞ 300

#convert(3) ➞ 180

#convert(2) ➞ 120
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def convert(minutes):
	return minutes*60



#Area of a Triangle 3

#Write a function that takes the base and height of a triangle and return its area.

#Examples
#tri_area(3, 2) ➞ 3

#tri_area(7, 4) ➞ 14

#tri_area(10, 10) ➞ 50
#Notes
#The area of a triangle is: (base * height) / 2
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def tri_area(base, height):
	return base * height / 2



#Find the Perimeter of a Rectangle 4

#Create a function that takes length and width and finds the perimeter of a rectangle.

#Examples
#find_perimeter(6, 7) ➞ 26

#find_perimeter(20, 10) ➞ 60

#find_perimeter(2, 9) ➞ 22
#Notes
#Don't forget to return the result.
#If you're stuck, find help in the Resources tab.
#If you're really stuck, find solutions in the Solutions tab.

def find_parimeter(length, width):
	return 2 * (width+length)



#Convert Hours into Seconds 5

#Write a function that converts hours into seconds.

#Examples
#how_many_seconds(2) ➞ 7200

#how_many_seconds(10) ➞ 36000

#how_many_seconds(24) ➞ 86400
#Notes
#60 seconds in a minute, 60 minutes in an hour
#Don't forget to return your answer.

def how_many_seconds(hours):
	return hours * 60 * 60



#Buggy Code (Part 1) 6

#Fix the code in the code tab to pass this challenge (only syntax errors). Look at the examples below to get an idea of what the function should do.

#Examples
#cubes(3) ➞ 27

#cubes(5) ➞ 125

#cubes(10) ➞ 1000
#Notes
#READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
#Don't overthink this challenge; it's not supposed to be hard.

def cubes(a):
	return a ** 3



#Return the First Element in a List 7

#Create a function that takes a list and returns the first element.

#Examples
#get_first_value([1, 2, 3]) ➞ 1

#get_first_value([80, 5, 100]) ➞ 80

#get_first_value([-500, 0, 50]) ➞ -500
#Notes
#The first element in a list always has an index of 0.

def get_first_value(number_list):
	return number_list[0]



#Correct the Mistakes 8

#Fix the code in the code tab to pass this challenge (only syntax errors). Look at the examples below to get an idea of what the function should do.

#Examples
#squared(5) ➞ 25

#squared(9) ➞ 81

#squared(100) ➞ 10000
#Notes
#READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
#Don't overthink this challenge; it's not supposed to be hard.

def squaed(b):
	return b / b



#Convert Age to Days 9

#Create a function that takes the age and return the age in days.

#Examples
#calc_age(65) ➞ 23725

#calc_age(0) ➞ 0

#calc_age(20) ➞ 7300
#Notes
#Use 365 days as the length of a year for this challenge.
#Ignore leap years and days between last birthday and now.
#Expect only positive integer inputs.

def calc_age(age):
	return age * 365



#Convert Hours and Minutes into Seconds 10

#Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.

#Examples
#convert(1, 3) ➞ 3780

#convert(2, 0) ➞ 7200

#convert(0, 0) ➞ 0
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def convert(hours, minutes):
	hResult = hours * 60 * 60
	mResult = minutes * 60
	return hResult + mResult



#Power Calculator 11

#Create a function that takes voltage and current and returns the calculated power.

#Examples
#circuit_power(230, 10) ➞ 2300

#circuit_power(110, 3) ➞ 330

#circuit_power(480, 20) ➞ 9600
#Notes
#Requires basic calculation of electrical circuits (see Resources for info).

def circuit_power(voltage, current):
	return voltage * current



#String to Integer and Vice Versa 12

#Write two functions:

#to_int() : A function to convert a string to an integer.
#to_str() : A function to convert an integer to a string.
#Examples
#to_int("77") ➞ 77

#to_int("532") ➞ 532

#to_str(77) ➞ "77"

#to_str(532) ➞ "532"
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def to_int(txt):
	return int(txt)

def to_str(num):
	return str(num)



#Return the Sum of Two Numbers 13

#Create a function that takes two numbers as arguments and return their sum.

#Examples
#addition(3, 2) ➞ 5

#addition(-3, -6) ➞ -9

#addition(7, 3) ➞ 10
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def addition(a, b):
	return a + b



#Football Points 14

#Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.

#wins get 3 points
#draws get 1 point
#losses get 0 points
#Examples
#football_points(3, 4, 2) ➞ 13

#football_points(5, 0, 2) ➞ 15

#football_points(0, 0, 1) ➞ 0
#Notes
#Inputs will be numbers greater than or equal to 0.

def football_points(wins, draws, losses):
	return (wins * 3) + (draws * 1) + (losses * 0)



#Return the Next Number from the Integer Passed 15

#Create a function that takes a number as an argument, increments the number by +1 and returns the result.

#Examples
#addition(0) ➞ 1

#addition(9) ➞ 10

#addition(-3) ➞ -2
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def addition(num):
	return num + 1



#The Farm Problem 16

#In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:

#chickens = 2 legs
#cows = 4 legs
#pigs = 4 legs
#The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that returns the total number of legs of all the animals.

#Examples
#animals(2, 3, 5) ➞ 36

#animals(1, 2, 3) ➞ 22

#animals(5, 2, 8) ➞ 50
#Notes
#Don't forget to return the result.
#The order of animals passed is animals(chickens, cows, pigs).
#Remember that the farmer wants to know the total number of legs and not the total number of animals.

def animals(chickens, cows, pigs):
	return (chickens * 2) + (cows * 4) + (pigs * 4)



#Return a String as an Integer 17

#Create a function that takes a string and returns it as an integer.

#Examples
#string_int("6") ➞ 6

#string_int("1000") ➞ 1000

#string_int("12") ➞ 12
#Notes
#All numbers will be whole.
#All numbers will be positive.

def string_int(txt):
	return int(txt)



#Are the Numbers Equal? 18

#Create a function that returns True when num1 is equal to num2; otherwise return False.

#Examples
#is_same_num(4, 8) ➞ False

#is_same_num(2, 2) ➞  True

#is_same_num(2, "2") ➞ False
#Notes
#Don't forget to return the result.

def is_same_num(num1, num2):
	if (num1 == num2):
		return True
	else:
		return False



#Less Than 100? 19

#Given two numbers, return True if the sum of both numbers is less than 100. Otherwise return False.

#Examples
#less_than_100(22, 15) ➞ True
## 22 + 15 = 37

#less_than_100(83, 34) ➞ False
## 83 + 34 = 117

#less_than_100(3, 77) ➞ true
#Notes
#N/A

def less_than_100(a, b):
	return a + b < 100



#Is the Number Less than or Equal to Zero? 20

#Create a function that takes a number as its only argument and returns True if it's less than or equal to zero, otherwise return False.

#Examples
#less_than_or_equal_to_zero(5) ➞ False

#less_than_or_equal_to_zero(0) ➞ True

#less_than_or_equal_to_zero(-2) ➞ True
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def less_than_or_equal_to_zero(num):
	return num <= 0



#Proper Modulo Operator 21

#Create a function which returns the Modulo of the two given numbers.

#Examples
#mod(-13, 64) ➞ 51

#mod(50, 25) ➞ 0

#mod(-6, 3) ➞ 0
#Notes
#All test cases contain valid numbers.

def mod(m, n):
	return m % n



#Find the Smallest Number in a List 22

#Create a function that takes a list of numbers and returns the smallest number in the list.

#Examples
#find_smallest_num([34, 15, 88, 2]) ➞ 2

#find_smallest_num([34, -345, -1, 100]) ➞ -345

#find_smallest_num([-76, 1.345, 1, 0]) ➞ -76

#find_smallest_num([0.4356, 0.8795, 0.5435, -0.9999]) ➞ -0.9999

#find_smallest_num([7, 7, 7]) ➞ 7
#Notes
#Test cases contain decimals.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def find_smallest_num(lst):
	return min(lst)



#Concatenating Two Integer Lists 23

#Create a function to concatenate two integer lists.

#Examples
#concat([1, 3, 5], [2, 6, 8]) ➞ [1, 3, 5, 2, 6, 8]

#concat([7, 8], [10, 9, 1, 1, 2]) ➞ [7, 8, 10, 9, 1, 1, 2]

#concat([4, 5, 1], [3, 3, 3, 3, 3]) ➞ [4, 5, 1, 3, 3, 3, 3, 3]
#Notes
#Don't forget to return the result.
#See Resources tab for more info.

def concat(lst1, lst2):
	return lst1 + lst2



#Maximum Edge of a Triangle 24

#Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.

#Examples
#next_edge(8, 10) ➞ 17

#next_edge(5, 7) ➞ 11

#next_edge(9, 2) ➞ 10
#Notes
#(side1 + side2) - 1 = maximum range of third edge.
#The side lengths of the triangle are positive integers.
#Don't forget to return the result.

def next_edge(side1, side2):
	return (side1 + side2) - 1



#Find the Largest Number in a List 25

#Create a function that takes a list of numbers. Return the largest number in the list.

#Examples
#findLargestNum([4, 5, 1, 3]) ➞ 5

#findLargestNum([300, 200, 600, 150]) ➞ 600

#findLargestNum([1000, 1001, 857, 1]) ➞ 1001
#Notes
#Expect either positive numbers or zero (there are no negative numbers).
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def findlargestNum(nums):
	return max(nums)



#Check if an Integer is Divisible By Five 26

#Create a function that returns True if an integer is evenly divisible by 5, and False otherwise.

#Examples
#divisible_by_five(5) ➞ True

#divisible_by_five(-55) ➞ True

#divisible_by_five(37) ➞ False
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def divisible_by_five(n):
	return n % 5 == 0



#Using the "and" Operator 27

#Python has a logical operator and. The and operator takes two boolean values, and returns True if both values are True.

#Consider a and b:

#a is checked if it is True or False.
#If a is False, False is returned.
#b is checked if it is True or False.
#If b is False, False is returned.
#Otherwise, True is returned (as both a and b are therefore True ).
#The and operator will only return True for True and True.

#Make a function using the and operator.

#Examples
#And(True, False) ➞ False

#And(True, True) ➞ True

#And(False, True) ➞ False

#And(False, False) ➞ False
#Notes
#N/A

def And(a, b):
	if (a == True and b == True):
		return True
	else:
		return False



#Return the Remainder from Two Numbers 28

#There is a single operator in Python, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.

#Examples
#remainder(1, 3) ➞ 1

#remainder(3, 4) ➞ 3

#remainder(5, 5) ➞ 0

#remainder(7, 2) ➞ 1
#Notes
#The tests only use positive integers.
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.

def remainder(x, y):
	return x % y 



#Get the Sum of All List Elements 29

#Create a function that takes a list and returns the sum of all numbers in the list.

#Examples
#get_sum_of_elements([2, 7, 4]) ➞ 13

#get_sum_of_elements([45, 3, 0]) ➞ 48

#get_sum_of_elements([-2, 84, 23]) ➞ 105
#Notes
#N/A

def get_sum_of_elements(lst):
	return sum(lst)



#Frames Per Second 30

#Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.

#Examples
#frames(1, 1) ➞ 60

#frames(10, 1) ➞ 600

#frames(10, 25) ➞ 15000
#Notes
#FPS stands for "frames per second" and it's the number of frames a computer screen shows every second.

def frames(minutes, fps):
	return (minutes * 60) * fps



#To the Power of _____ 31

#Create a function that takes a base number and an exponent number and returns the calculation.

#Examples
#calculate_exponent(5, 5) ➞ 3125

#calculate_exponent(10, 10) ➞ 10000000000

#calculate_exponent(3, 3) ➞ 27
#Notes
#All test inputs will be positive integers.
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def calculate_exponent(num, exp):
	return num ** exp



#Name Greeting! 32

#Create a function that takes a name and returns a greeting in the form of a string.

#Examples
#hello_name("Gerald") ➞ "Hello Gerald!"

#hello_name("Tiffany") ➞ "Hello Tiffany!"

#hello_name("Ed") ➞ "Hello Ed!"
#Notes
#The input is always a name (as string).
#Don't forget the exclamation mark!
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def hello_name(name):
	return "Hello" + " " + str(name) + "!"



#Multiple of 100 33

#Create a function that takes an integer and return True if it's divisible by 100, otherwise return False.

#Examples
#divisible(1) ➞ False

#divisible(1000) ➞ True

#divisible(100) ➞ True
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def divisible(num):
	if num%100 == 0:
		return True
	else:
		return False



#Return Something to Me! 34

#Write a function that returns the string "something" joined with a space " " and the given argument a.

#Examples
#give_me_something("is better than nothing") ➞ "something is better than nothing"

#give_me_something("Bob Jane") ➞ "something Bob Jane"

#give_me_something("something") ➞ "something something"

def give_me_something(a):
	return "something" + " " + a



#Recursion to Repeat a String n Number of Times 35

#Create a recursive function that takes two parameters and repeats the string n number of times. The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.

#Examples
#repetition("ab", 3) ➞ "ababab"

#repetition("kiwi", 1) ➞ "kiwi"

#repetition("cherry", 2) ➞ "cherrycherry"
#Notes
#The second parameter of the function is positive integer.

def repetition(txt, n):
	return txt*n



#Profitable Gamble 36

#Create a function that takes three arguments prob, prize, pay and returns True if prob * prize > pay; otherwise return False.

#To illustrate:

#profitable_gamble(0.2, 50, 9)
#should yield True, since the net profit is 1 (0.2 * 50 - 9), and 1 > 0.

#Examples
#profitable_gamble(0.2, 50, 9) ➞ True

#profitable_gamble(0.9, 1, 2) ➞ False

#profitable_gamble(0.9, 3, 2) ➞ True
#Notes
#A profitable gamble is a game that yields a positive net profit, where net profit is calculated in the following manner: net_outcome = probability_of_winning * prize - cost_of_playing.

def profitable_gamble(prob, prize, pay):
	return prob * prize > pay



#Pair Management 37

#Given two arguments, return a list which contains these two arguments.

#Examples
#make_pair(1, 2) ➞ [1, 2]

#make_pair(51, 21) ➞ [51, 21]

#make_pair(512124, 215) ➞ [512124, 215]
#Notes
#N/A

def make_pair(num1, num2):
	return [num1, num2]



#Is the String Empty? 38

#Create a function that returns True if a string is empty and False otherwise.

#Examples
#is_empty("") ➞ True

#is_empty(" ") ➞ False

#is_empty("a") ➞ False
#Notes
#A string containing only whitespaces " " does not count as empty.
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def is_empty(s):
	if (s == ""):
		return True
	else:
		return False



#Concatenate First and Last Name into One String 39

#Given two strings, first_name and last_name, return a single string in the format "last, first".

#Examples
#concat_name("First", "Last") ➞ "Last, First"

#concat_name("John", "Doe") ➞ "Doe, John"

#concat_name("Mary", "Jane") ➞ "Jane, Mary"
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def concat_name(first_name, last_name):
	return last_name + ', ' + first_name



#Sum of List Less Than 100 List Remix 40

#Given a list of numbers, return True if the sum of the values in the list is less than 100; otherwise return False.

#Examples
#list_less_than_100([5, 57]) ➞ True

#list_less_than_100([77, 30]) ➞ False

#list_less_than_100([0]) ➞ True
#Notes
#N/A

def list_less_than_100(lst):
	return sum(lst) < 100



#Maximum Difference 41

#Given a list of integers, return the difference between the largest and smallest integers in the list.

#Examples
#difference([10, 15, 20, 2, 10, 6]) ➞ 18
## 20 - 2 = 18

#difference([-3, 4, -9, -1, -2, 15]) ➞ 24
## 15 - (-9) = 24

#difference([4, 17, 12, 2, 10, 2]) ➞ 15
#Notes
#N/A

def difference(nums):
