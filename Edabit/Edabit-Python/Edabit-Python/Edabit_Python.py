
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
	 return max(nums) - min(nums)



#Indexing with Integer Division 42

#Given an index using INTEGER division and a list, return the value of the list with the given index.

#Examples
#value_at([1, 2, 3, 4, 5, 6], 10 // 2) ➞ 6

#value_at([1, 2, 3, 4, 5, 6], 8.0 // 2) ➞ 5

#value_at([1, 2, 3, 4], 6.535355314 // 2) ➞ 4
#Notes
#N/A

def value_at(lst, index):
	return lst[int(index)]



#Testing K^K == N? 43

#Write a function that returns True if k^k == n for input (n, k) and return False otherwise.

#Examples
#k_to_k(4, 2) ➞ True

#k_to_k(387420489, 9) ➞ True
## 9^9 == 387420489

#k_to_k(3124, 5) ➞ False

#k_to_k(17, 3) ➞ False
#Notes
#The ^ operator refers to exponentiation operation **, not the bitwise XOR operation.

def k_to_k(n, k):
	if (k ** k == n):
		return True
	else:
		return False



#Difference of Max and Min Numbers in List 44

#Create a function that takes a list and returns the difference between the biggest and smallest numbers.

#Examples
#difference_max_min([10, 4, 1, 4, -10, -50, 32, 21]) ➞ 82
## Smallest number is -50, biggest is 32.

#difference_max_min([44, 32, 86, 19]) ➞ 67
## Smallest number is 19, biggest is 86.
#Notes
#N/A

def difference_max_min(lst):
	return max(lst) - min(lst)



#s the String Odd or Even? 45

#Given a string, return True if its length is even or False if the length is odd.

#Examples
#odd_or_even("apples") ➞ True

#odd_or_even("pears") ➞ False

#odd_or_even("cherry") ➞ True
#Notes
#N/A

def odd_or_even(word):
	return len(word) % 2 == 0



#Compare Strings by Count of Characters 46

#Create a function that takes two strings as arguments and return either True or False depending on whether the total number of characters in the first string is equal to the total number of characters in the second string.

#Examples
#comp("AB", "CD") ➞ True

#comp("ABC", "DE") ➞ False

#comp("hello", "edabit") ➞ False
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def comp(txt1, txt2):
	return len(txt1) == len(txt2)



#Return the Last Element in a List 47

#Create a function that accepts a list and returns the last item in the list. The list can be either homogeneous or heterogeneous.

#Examples
#get_last_item([1, 2, 3]) ➞ 3

#get_last_item(["cat", "dog", "duck"]) ➞ "duck"

#get_last_item([True, False, True]) ➞ True

#get_last_item([7, "String", False]) ➞ False
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def get_last_item(lst):
	return lst[-1]



#Divides Evenly 48

#Given two integers, a and b, return True if a can be divided evenly by b. Return False otherwise.

#Examples
#divides_evenly(98, 7) ➞ True
## 98/7 = 14

#divides_evenly(85, 4) ➞ False
## 85/4 = 21.25
#Notes
#a will always be greater than or equal to b.

def divides_evenly(a, b):
	return a % b == 0



#On/Off Switches 49

#Create a function that returns how many possible outcomes can come from a certain number of switches (on / off). In other words, for a given number of switches, how many different combinations of on and off can we have?

#Examples
#pos_com(1) ➞ 2

#pos_com(3) ➞ 8

#pos_com(10) ➞ 1024
#Notes
#All numbers will be whole and positive.

def pos_com(num):
	return 2 ** num



#Miserable Parody of a Calculator 50

#Create a function that will handle simple math expressions. The input is an expression in the form of a string.

#Examples
#calculator("23+4") ➞ 27

#calculator("45-15") ➞ 30

#calculator("13+2-5*2") ➞ 5

#calculator("49/7*2-3") ➞ 11
#Notes
#There will be no brackets in the input line.
#No need to calculate mathematical functions (sin, cos, ln...).
#There are no gaps in the expression.

def calculator(txt):
	return eval(txt)



#Concatenating First and Last Character of a String 51

#Creates a function that takes a string and returns the concatenated first and last character.

#Examples
#first_last("ganesh") ➞ "gh"

#first_last("kali") ➞ "ki"

#first_last("shiva") ➞ "sa"

#first_last("vishnu") ➞ "vu"

#first_last("durga") ➞ "da"
#Notes
#There is no empty string.

def first_last(name):
	return name[0] + name[-1]



#Is the Number Even or Odd? 52

#Create a function that takes a number as an argument and returns "even" for even numbers and "odd" for odd numbers.

#Examples
#isEvenOrOdd(3) ➞ "odd"

#isEvenOrOdd(146) ➞ "even"

#isEvenOrOdd(19) ➞ "odd"
#Notes
#Dont forget to return the result.
#Input will always be a valid integer.
#Expect negative integers (whole numbers).
#Tests are case sensitive (return "even" or "odd" in lowercase).

def isEvenOrOdd(num):
	return ["even", "odd"][num % 2]



#Burrrrrrrp 53

#Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.

#Examples
#long_burp(3) ➞ "Burrrp"

#long_burp(5) ➞ "Burrrrrp"

#long_burp(9) ➞ "Burrrrrrrrrp"
#Notes
#Expect num to always be >= 1.
#Remember to use a capital "B".
#Don't forget to return the result.

def long_burp(num):
	return "Bu" + "r" * num + "p"



#Buggy Code (Part 2) 54

#Fix the code in the code tab to pass this challenge (only syntax errors). Look at the examples below to get an idea of what the function should do.

#Examples
#max_num(3, 7) ➞ 7

#max_num(-1, 0) ➞ 0

#max_num(1000, 400) ➞ 1000
#Notes
#READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
#Don't overthink this challenge; it's not supposed to be hard.

def max_num(n1, n2):
	if n1 < n2:
		return n2
	else:
		return n1



#Fix the Error: Check Whether a Given Number Is Odd 55

#Éowyn has written the function is_odd() to check if a given number is odd or not. Unfortunately, the function does not return the correct result for all the inputs. Help her fix the error.

#def is_odd(num):
#  return num % 1 == 1 or 2
#Examples
#is_odd(-5) ➞ True

#is_odd(25) ➞ True

#is_odd(0) ➞ False
#Notes
#All the inputs will only be integers.

def is_odd(num):
	return num % 2 != 0



#Is the Word Singular or Plural? 56

#Create a function that takes in a word and determines whether or not it is plural. A plural word is one that ends in "s".

#Examples
#is_plural("changes") ➞ True

#is_plural("change") ➞ False

#is_plural("dudes") ➞ True

#is_plural("magic") ➞ False
#Notes
#Don't forget to return the result.
#Remember that return True (boolean) is not the same as return "True" (string).
#This is an oversimplification of the English language. We are ignoring edge cases like "goose" and "geese", "fungus" and "fungi", etc.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def is_plural(word):
	return word[-1] == "s"



#Convert Number to String of Dashes 57

#Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens.

#Examples
#num_to_dashes(1) ➞ "-"

#num_to_dashes(5) ➞ "-----"

#num_to_dashes(3) ➞ "---"
#Notes
#You will be provided integers ranging from 1 to 60.
#Don't forget to return your result as a string.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def num_to_dashes(num):
	return "-" * num



#Char-to-ASCII 58

#Create a function that returns the ASCII value of the passed in character.

#Examples
#ctoa("A") ➞ 65

#ctoa("m") ➞ 109

#ctoa("[") ➞ 91

#ctoa("\") ➞ 92
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def ctoa(char):
	return ord(char)



#Solve the Equation 59
#Create a function that takes an equation (e.g. "1+1"), and returns the answer.

#Examples
#equation("1+1") ➞ 2

#equation("7*4-2") ➞ 26

#equation("1+1+1+1+1") ➞ 5
#Notes
#N/A

def equation(s):
	return eval(s)



#Fix the Error: Value vs. Reference Types 60

#Create a function that returns True if two lists contain identical values, and False otherwise.

#To solve this question, your friend writes the following code:

#def check_equals(lst1, lst2):
#    if lst1 is lst2:
#        return True
#    else:
#        return False
#But testing the code, you see that something is not quite right. Running the code yields the following results:

#check_equals([1, 2], [1, 3]) ➞ False
## Good so far...

#check_equals([1, 2], [1, 2]) ➞ False
## Yikes! What happened?
#Rewrite your friend's code so that it correctly checks if two lists are equal. The tests below should pass:

#Examples
#check_equals([1, 2], [1, 3]) ➞ False

#check_equals([1, 2], [1, 2]) ➞ True

#check_equals([4, 5, 6], [4, 5, 6]) ➞ True

#check_equals([4, 7, 6], [4, 5, 6]) ➞ False
#Notes
#Hint: This has to do with value vs. reference types.

def check_equals(lst1, lst2):
	if lst1 == lst2:
		return True
	else:
		return False



#Check if a List Contains a Given Number 61

#Write a function to check if a list contains a particular number.

#Examples
#check([1, 2, 3, 4, 5], 3) ➞ True

#check([1, 1, 2, 1, 1], 3) ➞ False

#check([5, 5, 5, 6], 5) ➞ True

#check([], 5) ➞ False
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def check(lst, el): 
	return el in lst



#Inches to Feet 62

#Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

#Examples
#inches_to_feet(324) ➞ 27

#inches_to_feet(12) ➞ 1

#inches_to_feet(36) ➞ 3
#Notes
#If inches are under 12, return 0.

def inches_to_feet(inches):
	if inches < 12:
		return 0
	return inches/12



#Flip the Boolean 63

#Due to a programming concept known as truthiness, certain values can be evaluated to (i.e. take the place of) booleans. For example, 1 (or any number other than 0) is often equivalent to True, and 0 is often equivalent to False.

#Create a function that returns the opposite of the given boolean, as a number.

#Examples
#flip_bool(True) ➞ 0

#flip_bool(False) ➞ 1

#flip_bool(1) ➞ 0

#flip_bool(0) ➞ 1
#Notes
#N/A

def flip_bool(b):
	if b == 1:
		return 0
	elif b == 0:
		return 1



#Minimal I: If Boolean Then Boolean 64

#In this series we're going to see common redundancies and superfluities that make our code unnecessarily complicated and less readable, and we're going to learn how to avoid them.

#In line with the spirit of the series, we can summarize the general rules of minimalist code in two simple principles:

#Keep your code clean and readable.
#While not violating the first principle: get rid of everything superfluous.
#In order to achieve this you should:

#Deepen your knowledge of logics.
#Deepen your understanding of the particular language you're coding with.
#I would also add: observe and learn from the pros. Make a habit of checking the Solutions tab after solving a challenge on Edabit. There is absolutely nothing wrong in assimilating features of someone else's coding style, especially if yours is not yet fully developed.

#Goal
#In the Code tab you will find a code that is missing a single character in order to pass the tests. However, YOUR GOAL is to submit a function as minimalist as possible. Use the tips in the Tips section down below.

#Write a function that returns True if the given integer is even, and False if it's odd.

#Tips
#Using an if statement in order to return boolean or to set a variable to a boolean is redundant.

#A function that returns True if a person's age is 18 or greater and False otherwise, could be written as:

#def legal_age(age):
#  if age >= 18:
#    return True
#  else:
#      return False
#Notice that age >= 18 will already give us a boolean (True or False). This means that the function can be written in a much simpler and cleaner way:

#def legal_age(age):
#  return age >= 18
#Notes
#This is an open series: there isn't a definite list of features for the challenges. Please, do not hesitate to leave your suggestions in the Comment tab.
#Readability is indeed a subjective concept. Let's discuss it! Feel free to leave your opinion in the Comments tab.

def is_even(n):
	return n % 2 == 0



#Tile Teamwork Tactics 65

#In a board game, a piece may advance 1-6 tiles forward depending on the number rolled on a six-sided dice. If you advance your piece onto the same tile as another player's piece, both of you earn a bonus.

#Given you and your friend's tile number, create a function that returns if it's possible to earn a bonus when you roll the dice.

#Examples
#possible_bonus(3, 7) ➞ True

#possible_bonus(1, 9) ➞ False

#possible_bonus(5, 3) ➞ False
#Notes
#You cannot move backward (which is why example #3 doesn't work).
#If you are already on the same tile, return False, as you would be advancing away.
#Expect only positive integer inputs.

def possible_bonus(a, b):
	return b-a in range(1, 7)



#Find the Bug: Returning the Container 66

#The packaging system is running wild! The candy is lying loose all over in the warehouse, the cereal is missing, and bread is stuffed in a bottle. What is going on here? The candy should be in plastic and the bread should be in a bag.

#The packaging machine is running the get_container() function to retrieve the container of a product. But something is not right...

#Examples
#get_container("Bread") ➞ "bag"

#get_container("Beer") ➞ "bottle"

#get_container("Candy") ➞ "plastic"

#get_container("Cheese") ➞ None
#Notes
#Think about what the object's packaging should be.

def get_container(product):
	matches = {
	"Bread" : "bag",
	"Milk" : "bottle",
	"Beer" : "bottle",
	"Eggs" : "carton",
	"Cereal" : "box",
	"Candy" : "plastic",
	"Cheese" : None
	}
	return matches[product]



#WordCharWord 67
#Create a function that will put the first argument, a character, between every word in the second argument, a string.

#Examples
#add("R", "python is fun") ➞ "pythonRisRfun"

#add("#", "hello world!") ➞ "hello#world!"

#add("#", " ") ➞ "#"
#Notes
#Make sure there are no spaces between words when returning the function.

def add(char, txt):
	return txt.replace(' ', char)



#s the Last Character an "N"? 68

#Create a function that takes a string (a random name). If the last character of the name is an "n", return True, otherwise return False.

#Examples
#is_last_character_n("Aiden") ➞ True

#is_last_character_n("Piet") ➞ False

#is_last_character_n("Bert") ➞ False

#is_last_character_n("Dean") ➞ True
#Notes
#The function must return a boolean value ( i.e. True or False).

def is_last_character_n(word):
	return word[-1] == "n"



#Find the Smallest and Biggest Numbers 69

#Create a function that accepts a list of numbers and return both the minimum and maximum numbers, in that order (as a list).

#Examples
#min_max([1, 2, 3, 4, 5]) ➞ [1, 5]

#min_max([2334454, 5]) ➞ [5, 2334454]

#min_max([1]) ➞ [1, 1]
#Notes
#All test lists will have at least one element and are valid.

def min_max(nums):
	return [min(nums), max(nums)]



#Word without First Character 70

#Create a function that takes a word and returns the new word without including the first character.

#Examples
#new_word("apple") ➞ "pple"

#new_word("cherry") ➞ "herry"

#new_word("plum") ➞ "lum"
#Notes
#The input is always a valid word.

def new_word(word):
	return word.replace(word[0], ' ')



#Burglary Series (14): Adjectives Total 71

#You call your spouse in anger and a "little" argument takes place. Count the total amount of adjectives used. Given an object with a list of adjectives, return the total amount of adjectives used.

#Examples
#total_amount_adjectives({ "a": "moron" }) ➞ 1

#total_amount_adjectives({ "a": "idiot", "b": "idiot", "c": "idiot" }) ➞ 3

#total_amount_adjectives({ "a": "moron", "b": "scumbag", "c": "moron", d: "dirtbag" }) ➞ 4
#Notes
#The list will never be empty (no empty object).

def total_amount_adjectives(obj):
	count = 0
	for element in obj.values():
		count += 1
	return count



#Return Sole Element in a Set 72

#Given a set containing one element, return the element.

#Examples
#element_from_set({"edabit"}) ➞ "edabit"

#element_from_set({True}) ➞ True

#element_from_set({11037}) ➞ 11037
#Notes
#Lists, dictionaries, and other sets won't be elements because sets won't accept any mutable data types as elements.

def element_from_set(s):
	return s.pop()



#Half, Quarter and Eighth 73

#Create a function that takes a number and return a list of three numbers: half of the number, quarter of the number and an eighth of the number.

#Examples
#half_quarter_eighth(6) ➞ [3, 1.5, 0.75]

#half_quarter_eighth(22) ➞ [11, 5.5, 2.75]

#half_quarter_eighth(25) ➞ [12.5, 6.25, 3.125]
#Notes
#The order of the list is: half, quarter, eighth.

def half_quarter_eighth(n):
	a = n / 2
	b = a / 2
	c = b / 2
	return [a, b, c]



#Stack the Boxes 74

#Here's an image of four models. Some of the cubes are hidden behind other cubes. Model one consists of one cube. Model two consists of four cubes, and so on...

#Stack the Boxes

#Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.

#Examples
#stack_boxes(1) ➞ 1

#stack_boxes(2) ➞ 4

#stack_boxes(0) ➞ 0
#Notes
#Step n is a positive integer.

def stack_boxes(n):
	return n ** 2



#Return the First and Last Elements in a List 75

#Create a function that takes a list of elements and return the first and last elements as a new list.

#Examples
#first_last([5, 10, 15, 20, 25]) ➞ [5, 25]

#first_last(["edabit", 13, None, False, True]) ➞ ["edabit", True]

#first_last([None, 4, "6", "hello", None]) ➞ [None, None]
#Notes
#Test input will always contain a minimum of two elements within the list.
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def first_last(lst):
	return [lst[0], lst[- 1]]



#Triangle and Parallelogram Area Finder 76

#Write a function that accepts base (decimal), height (decimal) and shape ("triangle", "parallelogram") as input and calculates the area of that shape.

#Examples
#area_shape(2, 3, "triangle") ➞ 3

#area_shape(8, 6, "parallelogram") ➞ 48

#area_shape(2.9, 1.3, "parallelogram") ➞ 3.77
#Notes
#Area of a triangle is 0.5 * b * h
#Area of a parallelogram is b * h
#Assume triangle and parallelogram are the only inputs for shape.

def area_shape(base, height, shape):
	if (shape == "triangle"):
		return 0.5 * base * height
	else:
		return base * height



#Recreating the abs() Function 77

#The abs() function returns the absolute value of a number. This means it returns a number's positive value. You can think of it as the distance away from zero.

#Create a function that recreates this functionality.

#Examples
#absolute(-5) ➞ 5

#absolute(-3.14) ➞ 3.14

#absolute(250) ➞ 250
#Notes
#Tests will only include valid numbers.
#Note that positive numbers will stay positive!
#Don't use the abs() function (it will defeat the purpose of the challenge).

def absolute(n):
	if n >= 0:
		return n
	else:
		return n*(-1)



#City School Creating IDS 78

#Many IDS (for emails or Google ID) are created using the person's name.

#Create a function that will return a four-character ID using the person's first name and last name. The first character will be the first letter of the first name but in lowercase. The next three characters will be the first three characters of the last name, but the first letter will be capitalized and the other two will be in lower case.

#Examples
#create_id("mary", "lamb") ➞ "mLam"

#create_id("John", "SMITH") ➞ "jSmi"

#create_id("mary", "smith") ➞ "mSmi"
#Notes
#There is always one character in the first name and at least three in the last name.

def create_id(firstname, lastname):
	return firstname[0].lower() + lastname[:3].capitalize()



#Number of Stickers 79

#Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.

#Pictures of Rubik's Cubes

#The Rubik's cube of side length 1 has 6 stickers.
#The Rubik's cube of side length 2 has 24 stickers.
#The Rubik's cube of side length 3 has 54 stickers.
#Examples
#how_many_stickers(1) ➞ 6

#how_many_stickers(2) ➞ 24

#how_many_stickers(3) ➞ 54
#Notes
#Keep in mind there are six faces to keep track of.
#Expect only positive whole numbers.

def how_many_stickers(n):
	return 6 * n ** 2



#Edaaaaabit 80

#Write a function that takes an integer and returns a string with the given number of "a"s in Edabit.

#Examples
#how_many_times(5) ➞ "Edaaaaabit"

#how_many_times(0) ➞ "Edbit"

#how_many_times(12) ➞ "Edaaaaaaaaaaaabit"
#Notes
#The string must start with "Ed" and end with "bit".
#You'll only be given integers as test input.

def how_many_times(num):
	return "Ed" + num * "a" + "bit"



#No Conditionals? 81

#Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.

#Examples
#flip(1) ➞ 0

#flip(0) ➞ 1
#Notes
#Try completing this challenge without using any:

#Conditionals
#Ternary operators
#Negations
#Bit operators

def flip(y):
	return 1 - y



#Smash Factor 82

#Smash factor is a term in golf that relates to the amount of energy transferred from the club head to the golf ball. The formula for calculating smash factor is ball speed divided by club speed.

#Create a function that takes ball speed bs and club speed cs as arguments and returns the smash factor to the nearest hundredth.

#Examples
#smash_factor(139.4, 93.8) ➞ 1.49

#smash_factor(181.2, 124.5) ➞ 1.46

#smash_factor(154.7, 104.3) ➞ 1.48
#Notes
#Remember to round to the nearest hundredth.
#All values will be valid (so no dividing by zero).

def smash_factor(bs, cs):
	return round(bs / cs, 2))



#Check String for Spaces 83

#Create a function that returns True if a string contains any spaces.

#Examples
#has_spaces("hello") ➞ False

#has_spaces("hello, world") ➞ True

#has_spaces(" ") ➞ True

#has_spaces("") ➞ False

#has_spaces(",./!@#") ➞ False
#Notes
#An empty string does not contain any spaces.
#Try doing this without RegEx.

def has_spaces(txt):
	if (' ' in txt):
		return True
	else:
		return False



#Drinks Allowed? 84

#A bartender is writing a simple program to determine whether he should serve drinks to someone. He only serves drinks to people 18 and older and when he's not on break.

#Given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.

#Examples
#should_serve_drinks(17, True) ➞ False

#should_serve_drinks(19, False) ➞ True

#should_serve_drinks(30, True) ➞ False
#Notes
#Return True or False.
#Some countries have a slightly higher drinking age, but for the purposes of this challenge, it will be 18.

def should_serve_drinks(age, on_break):
	return age >= 18 and on_break == False



#Evaluate an Equation 85

#Create a function that evaluates an equation.

#Examples
#eq("1+2") ➞ 3

#eq("6/(9-7)") ➞ 3

#eq("3+2-4") ➞ 1
#Notes
#Don't print, return a value.
#Return the value, not the equation.
#The method used to solve this challenge should not be used in practice. However, it's important to be aware of how this functionality works and why it should not be used. Check the Resources for more information.

def eq(evaluate):
	return eval(evaluate)



#AND, OR and NOT 86

#You will need to write three unfinished logic gates. Continue to write the three logic gates: AND, OR, and NOT.

#Examples
#AND(1, 1) ➞ 1
#AND(0, 0) ➞ 0

#OR(1, 0) ➞ 1
#OR(1, 1) ➞ 1

#NOT(0) ➞ 1
#NOT(1) ➞ 0
#Notes
#Check the Resourses tab for some help.

def NOT(num):
	return int(not num)

def AND(num,num2):
	return int(num and num2)

def OR(num,num2):
	return int(num or num2)



#The 3 Programmers Problem 87

#You hired three programmers and you (hopefully) pay them. Create a function that takes three numbers (the hourly wages of each programmer) and returns the difference between the highest-paid programmer and the lowest-paid.

#Examples
#programmers(147, 33, 526) ➞ 493

#programmers(33, 72, 74) ➞ 41

#programmers(1, 5, 9) ➞ 8
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def programmers(one, two, three):
	return max(one, two, three)  - min(one, two, three)



#Fix the Errors / Comparing Arrays 88

#Programmer Pete is trying to create a function that returns True if two lists share the same length and have identical numerical values at every index, otherwise, it will return False.

#However, the solution his function gives is in an unexpected format. Can you fix Pete's function so that it behaves as seen in the examples below?

#Examples
#check_equals([1, 2], [1, 3]) ➞ False

#check_equals([1, 2], [1, 2]) ➞ True

#check_equals([4, 5, 6], [4, 5, 6]) ➞ True

#check_equals([4, 7, 6], [4, 5, 6]) ➞ False

#check_equals([1, 12], [11, 2]) ➞ False
#Notes
#Check the Resources tab for more info.

def check_equals(lst1, lst2):
	if (lst1[::] == lst2[::]):
		return True
	else:
		return False



#Slice of Pie 89

#Create a function that determines whether or not it's possible to split a pie fairly given these three parameters:

#Total number of slices.
#Number of recipients.
#How many slices each person gets.
#The function will be in this form:

#equal_slices(total slices, no. recipients, slices each)
#Examples
#equal_slices(11, 5, 2) ➞ True
## 5 people x 2 slices each = 10 slices < 11 slices 

#equal_slices(11, 5, 3) ➞ False
## 5 people x 3 slices each = 15 slices > 11 slices

#equal_slices(8, 3, 2) ➞ True

#equal_slices(8, 3, 3) ➞ False

#equal_slices(24, 12, 2) ➞ True
#Notes
#Return (trivially) True if there are zero people.
#It's fine not to use the entire pie.
#All test parameters are integers.
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def equal_slices(total, people, each):
	return total >= people * each



#How Many D's Are There? 90

#Create a function that counts how many D's are in a sentence.

#Examples
#count_d("My friend Dylan got distracted in school.") ➞ 4

#count_d("Debris was scattered all over the yard.") ➞ 3

#count_d("The rodents hibernated in their den.") ➞ 3
#Notes
#Your function must be case-insensitive.
#Remember to return the result.
#Check the Resources for help.

def count_d(sentence):
	return sentence.lower().count("d")



#Broken Bridge 91

#Create a function which validates whether a bridge is safe to walk on (i.e. has no gaps in it to fall through).

#Examples
#is_safe_bridge("####") ➞ True

#is_safe_bridge("## ####") ➞ False

#is_safe_bridge("#") ➞ True
#Notes
#You can expect the bridge's ends connecting it to its surrounding.

def is_safe_bridge(s):
	if (" " in s):
		return False
	else:
		return True



#Raucous Applause 92
#After an amazing performance, the crowd goes wild! People clap enthusiastically and most claps overlap with each other to create one homogeneous sound.

#An overlapped clap is a clap which starts but doesn't finish, as in "ClaClap" (the first clap is cut short and there are overall 2 claps).

#Given a string of what the overlapping claps sounded like, return how many claps were made in total.

#Examples
#count_claps("ClaClaClaClap!") ➞ 4

#count_claps("ClClClaClaClaClap!") ➞ 6

#count_claps("CCClaClClap!Clap!ClClClap!") ➞ 9
#Notes
#Each clap starts with a capital "C".

def count_claps(txt):
	return txt.count("C")



#Cube the Square Root 93

#Create a function that takes a number as an argument and returns the square root of that number cubed.

#Examples
#cube_squareroot(81) ➞ 729

#cube_squareroot(1646089) ➞ 2111932187

#cube_squareroot(695556) ➞ 580093704
#Notes
#All numbers will evenly square root, so don't worry about decimal numbers.

def cube_squareroot(num):
	return num ** (3/2)



#Minimal II: Boolean Redundancy 94

#Check the principles of minimalist code in the intro to the first challenge.

#In the Code tab you will find a code that is missing a single character in order to pass the tests. However, your goal is to submit a function as minimalist as possible. Use the tips in the tips section down below.

#Write a function that returns the string "even" if the given integer is even, and the string "odd" if it's odd.

#Tips
#Converting a boolean, or something that will ultimately be interpreted as a boolean, into a boolean is redundant.

#For example, the code:

#boolean = bool(x < 4)
#return boolean == True
#Is equivalent to simply:

#return x < 4
#A comparison with <, <=, ==, !=, >=, > will always result in a boolean, therefore using the function bool() is totally unnecessary.
#boolean == True is redundant, as it will always return boolean.
#To obtain the opposite of boolean we could use boolean == False. However, a much cleaner way of doing this is simply not boolean.
#While preserving readability, avoid declaring unnecessary variables.
#Notes
#This is an open series: there isn't a definite list of features for the challenges. Please, do not hesitate to leave your suggestions in Comments.
#Readability is indeed a subjective concept. Let's discuss it! Feel free to leave your opinion in Comments.
#You can find all the exercises in this series over here.

def parity(n):
	if (n % 2):
		return "odd"
	return "even"



#Make My Way Home 95

#You will be given a list, showing how far James travels away from his home for each day. He may choose to travel towards or away from his house, so negative values are to be expected.

#Create a function which calculates how far James must walk to get back home.

#Examples
#distance_home([2, 4, 2, 5]) ➞ 13

#distance_home([-1, -4, -3, -2]) ➞ 10

#distance_home([3, 4, -5, -2]) ➞ 0
#Notes
#Assume James only travels in a straight line.
#Distance is always a positive number.

def distance_home(lst):
	return abs(sum(lst))



#Convert Kilometers to Miles 96

#In this challenge, you have to implement a function that returns the given distance kilometers converted into miles. You have to round the result up to the fifth decimal digit.

#Examples
#km_to_miles(2) ➞ 1.24274

#km_to_miles(6) ➞ 3.72823

#km_to_miles(8) ➞ 4.97097
#Notes
#1 kilometer = 0.621371 miles.

def km_to_miles(km):
	return round(km*0.621371,5)



#Kinetic Energy 97

#Kinetic energy can be calculated with the following formula:

#KE = 1/2mv²

#m is mass in kg
#v is velocity in m/s
#KE is kinetic energy in J
#Return the Kinetic Energy in Joules, given the mass and velocity. For the purposes of this challenge, round answers to the nearest integer.

#Examples
#calc_kinetic_energy(60, 3) ➞ 270

#calc_kinetic_energy(45, 10) ➞ 2250

#calc_kinetic_energy(63.5, 7.35) ➞ 1715
#Notes
#Expect only positive numbers for inputs.

def calc_kinetic_energy(m, v):
	return round(0.5 * m * v ** 2)



#Slightly Superior 98

#You will be given two extremely similar lists, but exactly one of the items in a list will be valued slightly higher than its counterpart (which means that evaluating the value > the other value will return True).

#Create a function that returns whether the first list is slightly superior to the second list.

#Worked Example
#is_first_superior([1, 2, 4], [1, 2, 3]) ➞ True
## The pair of items at each index are compared in turn.
## 1 from the first list is the same as 1 from the second list.
## 2 is the same as 2.
## However, 4 is greater than 3, so list one is superior.
#Examples
#is_first_superior(["a", "d", "c"], ["a", "b", "c"]) ➞ True

#is_first_superior(["zebra", "ostrich", "whale"], ["ant", "ostrich", "whale"]) ➞ True

#is_first_superior([1, 2, 3, 4], [1, 2, 4, 4]) ➞ False

#is_first_superior([True, 10, "zebra"], [True, 10, "zebra"]) ➞ False
#Notes
#All values and their counterparts will always be the same data type.
#The lists will only be different by one element.
#If the two lists are the same, return False.

def is_first_superior(lst1, lst2):
	return lst1 > ls2



#Convert Yen to USD 99

#Create a function that can turn Yen (Japanese dollar) to USD (American dollar).

#Examples
#yen_to_usd(1) ➞ 0.01

#yen_to_usd(500) ➞ 4.65

#yen_to_usd(649) ➞ 6.04
#Notes
#Each Yen to USD conversion is Yen / 107.5
#Round the result to two decimal places.

def yen_to_usd(yen):
	return round(yen / 107.5, 2)



#Check if All Values Are True 100

#Create a function that returns True if all parameters are truthy, and False otherwise.

#Examples
#all_truthy(True, True, True) ➞ True

#all_truthy(True, False, True) ➞ False

#all_truthy(5, 4, 3, 2, 1, 0) ➞ False
#Notes
#Truthy values include non-empty sequences, numbers (except 0 in every numeric type), and basically every value that is not falsy.
#You can check if an item is truthy by using an if statement on that item.
#You will always be supplied with at least one parameter.

def all_truthy(*args):
	return all(args)



#Amazing Edabit! 101

#Create a function that takes a string and changes the word amazing to not amazing. Return the string without any change if the word edabit is part of the string.

#Examples
#amazing_edabit("edabit is amazing.") ➞ "edabit is amazing."

#amazing_edabit("Mubashir is amazing.") ➞ "Mubashir is not amazing."

#amazing_edabit("Infinity is amazing.") ➞ "Infinity is not amazing."
#Notes
#Edabit is amazing :)

def amazing_edabit(s):
	if "edabit" in s:
		return s
	else:
		return s.replace("amazing", "not amazing")



#Destructuring Lists III 102

#You can assign variables from lists with destructuring like this:

#arr = ["eyes", "nose", "lips", "ears"]
#eyes, nose, lips, ears = arr
#If you don't need every list index stored in a named variable, you can use _ as a throwaway variable.

#arr = ["eyes", "nose", "lips", "ears"]
#_ , nose, _, _ = arr
#this assigns the value in arr[1] to the variable nose. The values in each other index will be assigned to the variable _ in order, overwriting each previous value. nose now holds the string "nose", and _ now holds the string "ears".

#Use destructuring assignment on the given list to assign the string "lips" to the variable provided. Do not use list indexing, or assigning variable names to any of the other strings.

#Notes
#Check the Resources tab for more examples.

# DO NOT change arr
# DO NOT USE lips = arr[2]
# "eyes", "nose", and "ears" should not be assigned to anything

arr = ["eyes", "nose", "lips", "ears"]
_, _, lips, _ = arr



#Using Ternary Operators 103

#The ternary operator (sometimes called Conditional Expressions) in python is an alternative to the if... else... statement.

#It is written in the format:

#result_if_true if condition else result_if_false
#Ternary operators are often more compact than multi-line if statements, and are useful for simple conditional tests.

#For example:

#is_nice = True

## Using ternary operator.
#state = "nice" if is_nice else "not nice"

## Equivalent code using multi-line if statements.
#if is_nice:
#    state = "nice"
#else:
#    state = "not nice"
#Write a function that uses the ternary operator to return "yeah" if b is True, and "nope" otherwise.

#Examples
#yeah_nope(True) ➞ "yeah"

#yeah_nope(False) ➞ "nope"
#Notes
#N/A

def yeah_nope(b)
	return ["nope", "yeah"][b]



#Format I: Template String 104

#For each challenge of this series you do not need to submit a function. Instead, you need to submit a template string that can be formatted in order to get a certain outcome.

#Write a template string according to the following example:

#Example
#a = "John"
#b = "Joe"
#c = "Jack"
#template = "yourtemplatestringhere"
#template.format(a, b, c) ➞ "Their names were: John, Joe and Jack."
#Tips
#A template string is a string that uses curly braces {} as a placeholder that can then be formatted:

#"hello, my name is {}".format("John") ➞ "hello, my name is John."
#Do not put any value inside {}.

#Notes
#Submit a string, not a function.
#Do not change the name of the variable template.
#You can find all the exercises in this series over here.

template = "Their names were: {}, {} and {}."



#Case Insensitive Comparison 105

#Write a function that validates whether two strings are identical. Make it case insensitive.

#Examples
#match("hello", "hELLo") ➞ True

#match("motive", "emotive") ➞ False

#match("venom", "VENOM") ➞ True

#match("mask", "mAskinG") ➞ False
#Notes
#N/A

def match(s1, s2):
	return s1.lower() == s2.lower()



#Return Last Item 106

#Create a function that returns the last value of the last item in a list or string.

#Examples
#last_ind([0, 4, 19, 34, 50, -9, 2]) ➞ 2

#last_ind("The quick brown fox jumped over the lazy dog") ➞ "g"

#last_ind([]) ➞ None
#Notes
#Lists/strings will be of varying size.
#Return None if list/string is empty.

def last_ind(lst):
	if len(lst)>1:
		return lst[-1]
	else:
		return None



#Random Integer Generator 107
#The challange is simple. Return a random integer N such that a <= N <= b.

#Examples
#random_int(5, 9) ➞ 7

#random_int(5, 9) ➞ 9

#random_int(5, 9) ➞ 5
#Notes
#Don't forget to return the result.
#Return value must be an integer.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

import random

def random_int(a, b):
	return random.randint(a, b)



#Does the Dictionary Contain a Given Key? 108

#Write a function that returns True if a dictionary contains the specified key, and False otherwise.

#Examples
#has_key({ "a": 44, "b": 45, "c": 46 }, "d") ➞ False

#has_key({ "craves": True, "midnight": True, "snack": True }, "morning") ➞ False

#has_key({ "pot": 1, "tot": 2, "not": 3 }, "not") ➞ True
#Notes
#N/A

def has_key(dictinoary, key):
	return key in dict.keys(dictinoary)



#Similar Bread 109

#Given two lists, which represent two sandwiches, return whether both sandwiches use the same type of bread. The bread will always be found at the start and end of the list.

#Examples
#has_same_bread(
#  ["white bread", "lettuce", "white bread"],
#  ["white bread", "tomato", "white bread"]
#) ➞ True

#has_same_bread(
#  ["brown bread", "chicken", "brown bread"],
#  ["white bread", "chicken", "white bread"]
#) ➞ False

#has_same_bread(
#  ["toast", "cheese", "toast"],
#  ["brown bread", "cheese", "toast"]
#) ➞ False
#Notes
#The lists will always be three elements long.
#The first piece of bread on one sandwich must be the same as the first piece of bread on the other sandwich. The same goes for the last piece of bread.

def has_same_bread(lst1, lst2):
	return lst1[0] == lst2[0] and lst1[-1] == lst2[-1]



#Sandwich Fillings 110

#Given a sandwich (as a list), return a list of fillings inside the sandwich. This involves ignoring the first and last elements.

#Examples
#get_fillings(["bread", "ham", "cheese", "ham", "bread"]) ➞ ["ham", "cheese", "ham"]

#get_fillings(["bread", "sausage", "tomato", "bread"]) ➞ ["sausage", "tomato"]

#get_fillings(["bread", "lettuce", "bacon", "tomato", "bread"]) ➞ ["lettuce", "bacon", "tomato"]
#Notes
#The first and last elements will always be "bread".

def get_fillings(sandwich):
	sandwich.remove("bread")
	sandwich.remove("bread")
	return sandwich



#Is the Dictionary Empty? 111

#Write a function that returns True if a dictionary is empty, and False otherwise.

#Examples
#is_empty({}) ➞ True

#is_empty({ "a": 1 }) ➞ False
#Notes
#N/A

def is_empty(dictionary):
	if not dictionary:
		return True
	else:
		return False



#Among Us Imposter Formula 112

#Create a function that calculates the chance of being an imposter. The formula for the chances of being an imposter is 100 × (i / p) where i is the imposter count and p is the player count. Make sure to round the value to the nearest integer and return the value as a percentage.

#Examples
#imposter_formula(1, 10) ➞ "10%"

#imposter_formula(2, 5) ➞ "40%"

#imposter_formula(1, 8) ➞ "13%"
#Notes
#The player limit is 10 and the imposter count can only go up to 3.

def imposter_formula(i, p):
	return str(round(100 * (i / p))) + "%"



#Find the Amount of Potatoes 113

#Create a function to return the amount of potatoes there are in a string.

#Examples
#potatoes("potato") ➞ 1

#potatoes("potatopotato") ➞ 2

#potatoes("potatoapple") ➞ 1
#Notes
#N/A

def potatoes(potato):
	return potato.count("potato")



#Count Instances of a Character in a String 114

#Create a function that takes two strings as arguments and returns the number of times the first string (the single character) is found in the second string.

#Examples
#char_count("a", "edabit") ➞ 1

#char_count("c", "Chamber of secrets") ➞ 1

#char_count("b", "big fat bubble") ➞ 4
#Notes
#Your output must be case-sensitive (see second example).

def char_count(txt1, txt2):
	return txt2.count(txt1)



#The Study of Wumbology 115

#Create a function that flips M's to W's (all uppercase).

#Examples
#wumbo("I LOVE MAKING CHALLENGES") ➞ "I LOVE WAKING CHALLENGES"

#wumbo("MEET ME IN WARSAW") ➞ "WEET WE IN WARSAW"

#wumbo("WUMBOLOGY") ➞ "WUWBOLOGY"
#Notes
#N/A

def wumbo(words):
	return words.replace("M", "W")



#Fraction Greater Than One 116

#Given a fraction as a string, return whether or not it is greater than 1 when evaluated.

#Examples
#greater_than_one("1/2") ➞ False

#greater_than_one("7/4") ➞ True

#greater_than_one("10/10") ➞ False
#Notes
#Fractions must be strictly greater than 1 (see example #3).

def greater_than_one(frac):
	return eval(frac) > 1



#Find the Total Number of Digits the Given Number Has 117

#Create a function that takes a number as an argument and returns the amount of digits it has.

#Examples
#find_digit_amount(123) ➞ 3

#find_digit_amount(56) ➞ 2

#find_digit_amount(7154) ➞ 4

#find_digit_amount(61217311514) ➞ 11

#find_digit_amount(0) ➞ 1
#Notes
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def find_digit_amount(num):
	return len(num).count



#C String to C++ String (in Python) 118

#This is a list of single characters with an unwanted character at the end:

#["H", "e", "l", "l", "o", "!", "\0"]
#You could also just type "Hello!" when initializing a variable, creating the string "Hello!"

#Create a function that will return a string by combining the given character list, not including the unwanted final character.

#Examples
#cpp_txt(["H", "i", "!", "\0"]) ➞ "Hi!"

#cpp_txt(["H", "e", "l", "l", "o", "!", "\0"]) ➞ "Hello!"

#cpp_txt(["J", "A", "V", "a", "\0"]) ➞ "JAVa"
#Notes
#This is a translation of a C++ challenge and is trivial in Python, but perhaps it will be helpful to someone out there. (No challenge is trivial until you know how to solve it :)

def cpp_txt(lst):
	return "".join(lst[:-1])



#Count Syllables 119

#Create a function that counts the number of syllables a word has. Each syllable is separated with a dash -.

#Examples
#number_syllables("buf-fet") ➞ 2

#number_syllables("beau-ti-ful") ➞ 3

#number_syllables("mon-u-men-tal") ➞ 4

#number_syllables("on-o-mat-o-poe-ia") ➞ 6
#Notes
#Don't forget to return the result.
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def number_syllables(word):
	return word.count("-") + 1



#50-30-20 Strategy 120

#The 50-30-20 strategy is a simple way to budget, which involves spending 50% of after-tax income on needs, 30% after tax income on wants, and 20% after-tax income on savings or paying off debt.

#Given the after-tax income as ati, what you are supposed to do is to make a function that will return a dictionary that shows how much a person needs to spend on needs, wants, and savings.

#Examples
#fifty_thirty_twenty(10000) ➞ { "Needs": 5000, "Wants": 3000, "Savings": 2000 }

#fifty_thirty_twenty(50000) ➞ { "Needs": 25000, "Wants": 15000, "Savings": 10000 }

#fifty_thirty_twenty(13450) ➞ { "Needs": 6725, "Wants": 4035, "Savings": 2690 }
#Notes
#Check the Resources tab if you want to learn more about the 50-30-20 budget strategy.

def fifty_thirty_twenty(ati):
	return {"Needs": ati * 50 / 100, "Wants": ati * 30 / 100, "Savings": ati * 20 / 100}



#Check if One Array can be Nested in Another 121

#Create a function that returns True if the first list can be nested inside the second.

#list1 can be nested inside list2 if:

#list1's min is greater than list2's min.
#list1's max is less than list2's max.
#Examples
#can_nest([1, 2, 3, 4], [0, 6]) ➞ True

#can_nest([3, 1], [4, 0]) ➞ True

#can_nest([9, 9, 8], [8, 9]) ➞ False

#can_nest([1, 2, 3, 4], [2, 3]) ➞ False
#Notes
#Note the strict inequality (see example #3).

def can_nest(list1, list2):
	return min(list1) > min(list2) and max(list1) < max(list2)



#Convert All List Items to String 122

#Create a function that takes a list of integers and strings. Convert integers to strings and return the new list.

#Examples
#parse_list([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]

#parse_list(["abc", 123, "def", 456]) ➞ ["abc", "123", "def", "456"]

#parse_list([1, 2, 3, 17, 24, 3, "a", "123b"]) ➞ ["1", "2", "3", "17", "24", "3", "a", "123b"]

#parse_list([]) ➞ []
#Notes
#N/A

def parse_list(lst):
	return list(map(str, lst))



#Buggy Code 123

#The challenge is to try and fix this buggy code, given the inputs True and False. See the examples below for the expected output.

#Examples
#has_bugs(True) ➞ "sad days"

#has_bugs(False) ➞ "it's a good day"
#Notes
#Don't overthink this challenge (look at the syntax and correct it).

def has_bugs(buggy_code):
	if (buggy_code == True):
		return "sad days"
	elif (buggy_code == False):
		return "it's a good day"



#Upvotes vs Downvotes 124

#Given a dictionary containing counts of both upvotes and downvotes, return what vote count should be displayed. This is calculated by subtracting the number of downvotes from upvotes.

#Examples
#get_vote_count({ "upvotes": 13, "downvotes": 0 }) ➞ 13

#get_vote_count({ "upvotes": 2, "downvotes": 33 }) ➞ -31

#get_vote_count({ "upvotes": 132, "downvotes": 132 }) ➞ 0
#Notes
#You can expect only positive integers for vote counts.

def get_vote_count(votes):
	return votes['upvotes'] - votes['downvotes']



#Is the Water Boiling? 125

#Create a function that determines if the temp of the water is considered boiling or not. temp will be measured in fahrenheit and celsius.

#Examples
#is_boiling("212F") ➞ True

#is_boiling("100C") ➞ True

#is_boiling("0F") ➞ False
#Notes
#The boiling point of water is 212F in fahrenheit and 100C in celsius.

def is_boiling(temp):
	return temp>="212F" or temp>="100C"



#Nothing is Nothing? 126

#Given any number of parameters (which is signified using *args syntax), return True if none of the variables are falsy/empty.

#Examples
#nothing_is_nothing(0, False, [], {}) ➞ False

#nothing_is_nothing(33, "Hello", (True, True, 3)) ➞ True

#nothing_is_nothing(True, None) ➞ False
#Notes
#*args allows a function to take any number of parameters.
#Falsy refers to values which evaluate to False in a boolean context. This includes (but is not limited to) variables such as 0, False, None, empty sets, lists and tuples.

def nothing_is_nothing(*args):
	return all(args)



#The Modulus Operator Function 127

#Create a function that will work as the modulus operator % without using the modulus operator. The modulus operator is a way to determine the remainder of a division operation. Instead of returning the result of the division, the modulo operation returns the whole number remainder.

#Examples
#mod(5,  2) ➞ 1

#mod(218, 5) ➞ 3

#mod(6, 3) ➞ 0
#Notes
#Don't use the % operator to return the results.

def mod(a, b):
	return a - a // b * b



#Sort Numbers in Ascending Order 128

#Create a function that takes a list of numbers and returns a new list, sorted in ascending order (smallest to biggest).

#Sort numbers list in ascending order.
#If the function's argument is None or an empty list, return an empty list.
#Return a new array of sorted numbers.
#Examples
#sort_nums_ascending([1, 2, 10, 50, 5]) ➞ [1, 2, 5, 10, 50]

#sort_nums_ascending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

#sort_nums_ascending([]) ➞ []
#Notes
#Test input can be positive or negative.

def sort_nums_ascending(lst):
	if (lst == ""):
		return []
	else:
		return sorted(lst)



#Assign Person to Occupation 129

#You have two lists. One shows the names of the people, while the other shows their occupation. Your task is to make a dictionary displaying each person to their respective occupations.

#Person	Job
#Annie	Teacher
#Steven	Engineer
#Lisa	Doctor
#Osman	Cashier
#Notes

def assign_person_to_job(pl, jl):
	return dict(zip(pl, jl))



#Minimal IV: if-elif-else Inferno 130
#Check the principles of minimalist code in the intro to the first challenge.

#In the Code tab you will find a code that is missing a single character in order to pass the tests. However, your goal is to submit a function as minimalist as possible. Use the tips in the tips section below.

#Write a function that returns the boolean True if the given number is zero, the string "positive" if the number is greater than zero or the string "negative" if it's smaller than zero.

#Tips
#Executing a return will effectively end your function.

#For example, the code:

#def compare_to_100(x):
#    if x > 100:
#        return "greater"
#    elif x < 100:
#        return "smaller"
#    else:
#        return "equal"
#Can be simplified to:

#def compare_to_100(x):
#    if x > 100:
#        return "greater"
#    if x < 100:
#        return "smaller"
#    return "equal"
#If x is greater than 100, Python will not execute the code past the first return.
#If x is smaller than 100, Python will not execute the code inside the first if statement or past the second return.
#If x is equal to 100, Python will not execute the code inside the two if statements.
#This can only be used if you have a return inside your if statement.
#Bonus
#Further simplification of the code above:

#def compare_to_100(x):
#    return "greater" if x > 100 else "smaller" if x < 100 else "equal"
#Notes
#This is an open series: there isn't a definite list of features for the challenges. Please, do not hesitate to leave your suggestions in the Comments.
#Readability is indeed a subjective concept. Let's discuss it! Feel free to leave your opinion in the Comments.

def equilibrium(x):
	return "positive" if x > 0 else "negative" if x < 0 else True



#Find the Second Largest Number 131

#Create a function that takes a list of numbers and returns the second largest number.

#Examples
#second_largest([10, 40, 30, 20, 50]) ➞ 40

#second_largest([25, 143, 89, 13, 105]) ➞ 105

#second_largest([54, 23, 11, 17, 10]) ➞ 23
#Notes
#N/A

def second_largest(lst):
	newLst = sorted(lst)
	return newLst[-2]



#Find the Index 132

#Create a function that takes a list and a string as arguments and return the index of the string.

#Examples
#find_index(["hi", "edabit", "fgh", "abc"], "fgh") ➞ 2

#find_index(["Red", "blue", "Blue", "Green"], "blue") ➞ 1

#find_index(["a", "g", "y", "d"], "d") ➞ 3

#find_index(["Pineapple", "Orange", "Grape", "Apple"], "Pineapple") ➞ 0
#Notes
#Don't forget to return the result.
#If you are stuck, find help in the Resources tab.
#The variable for list is lst, not 1st.

def find_index(lst, txt):
	return lst.index(txt)



#Re-Form the Word 133

#A word has been split into a left part and a right part. Re-form the word by adding both halves together, changing the first character to an uppercase letter.

#Examples
#get_word("seas", "onal") ➞ "Seasonal"

#get_word("comp", "lete") ➞ "Complete"

#get_word("lang", "uage") ➞ "Language"
#Notes
#N/A

#def get_word(left, right):
#	return left.capitalize() + right



#Keyboard Mistakes 134

#Character recognition software often makes mistakes when documents (especially old ones written with a typewriter) are digitized.

#Your task is to correct the errors in the digitized text. You only have to handle the following mistakes:

#A is misinterpreted as 4
#S is misinterpreted as 5
#O is misinterpreted as 0
#I is misinterpreted as 1
#The test cases contain numbers only by mistake.

#Examples
#keyboard_mistakes("MUB45H1R") ➞ "MUBASHIR"

#keyboard_mistakes("DUBL1N") ➞ "DUBLIN"

#keyboard_mistakes("51NG4P0RE") ➞ "SINGAPORE"
#Notes
#N/A

def keyboard_mistakes(txt):
	txt = txt.replace("4", "A")
	txt = txt.replace("5", "S")
	txt = txt.replace("0", "O")
	txt = txt.replace("1", "I")
	return txt



#Find the Bomb 135

#Create a function that finds the word "bomb" in the given string. If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".

#Examples
#bomb("There is a bomb.") ➞ "Duck!!!"

#bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"

#bomb("This goes boom!!!") ➞ "There is no bomb, relax."
#Notes
#"bomb" may appear in different cases (i.e. uppercase, lowercase, mixed).

def bomb(txt):
	return "Duck!!!" if "bomb" in txt.lower() else "There is no bomb, relax."



#Find None in a List 136

#Create a function to find None in a list of numbers. The return value should be the index where None is found. If None is not found in the list, then return -1.

#Examples
#find_none([1, 2, None]) ➞ 2

#find_none([None, 1, 2, 3, 4]) ➞ 0

#find_none([0, 1, 2, 3, 4]) ➞ -1
#Notes
#N/A

def find_None(lst):
	return lst.index(None) if None in lst else -1



#Format II: Argument Indices 137

#For each challenge of this series you do not need to submit a function. Instead, you need to submit a template string that can be formatted in order to get a certain outcome.

#Write a template string according to the following example:

#Example
#a = "John"
#b = "Joe"
#template = "yourtemplatestringhere"

#template.format(a, b) ➞ "Joe hit John and then John hit Joe."
#Tips
#Writing a number n inside a place holder will tell .format() to fill in with the nth argument. For example:

#"{0} said: Hi, I'm {0}.".format("Monica") ➞ "Monica said: Hi, I'm Monica."
#Notes
#Submit a string, not a function.
#Do not change the name of the variable template.

template = "{1} hit {0} and then {0} hit {1}."



#Equality Check 138

#In this challenge, you must verify the equality of two different values given the parameters a and b.

#Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

#Numbers
#Strings
#Booleans (False or True)
#Special values: None
#What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

#Implement a function that returns True if the parameters are equal, and False if they are not.

#Examples
#check_equality(1, true) ➞ False
## A number and a boolean: the value and type are different.

#check_equality(0, "0") ➞ False
## A number and a string: the type is different.

#check_equality(1,  1) ➞ True
## A number and a number: the type and value are equal.
#Notes
#If you get stuck on a challenge, find help in the Resources tab.
#If you're really stuck, unlock solutions in the Solutions tab.

def check_equality(a, b):
	return type(a) == type(b) and a ==b



#Count the Syllables 139

#Create a function that returns the number of syllables in a simple string. The string is made up of short repeated words like "Lalalalalalala" (which would have 7 syllables).

#Examples
#count_syllables("Hehehehehehe") ➞ 6

#count_syllables("bobobobobobobobo") ➞ 8

#count_syllables("NANANA") ➞ 3
#Notes
#For simplicity, please note that each syllable will consist of two letters only.
#Your code should accept strings of any case (upper, lower and mixed case).

def count_syllables(txt):
	return len(txt)//2



#Check if the Same Case 140

#Create a function that returns True if an input string contains only uppercase or only lowercase letters.

#Examples
#same_case("hello") ➞ True

#same_case("HELLO") ➞ True

#same_case("Hello") ➞ False

#same_case("ketcHUp") ➞ False
#Notes
#N/A

def same_case(txt):
	if (txt.islower() or txt.isupper()):
		return True
	else:
		return False



#Length and Element of Range 141

#Create a function that takes a range object r, index i, and returns a list where the first element is the number of elements in the range object, and the second element is the element of the range object at the given index.

#Examples
#length_element(range(2, 4), 0) ➞ [2, 2]

#length_element(range(12, 15, 2), 1) ➞ [2, 14]

#length_element(range(40, 50, 3), 2) ➞ [4, 46]
#Notes
#No need to check for IndexError.

def length_element(r,i):
    return [len(r), r[i]]



#The Full Length of a Google
#Google's logo can be stretched depending on how many pages it lets you skip forward to.

#Image of Goooooooooogle

#Let's say we wanted to change the number of pages that Google could skip to. Create a function where given a number of pages n, return the word "Google" but with the correct number of "o"s.

#Examples
#googlify(10) ➞ "Goooooooooogle"

#googlify(23) ➞ "Gooooooooooooooooooooooogle"

#googlify(2) ➞ "Google"

#googlify(-2) ➞ "invalid"
#Notes
#If n is equal to or less than 1, return invalid.

def googlify(n):
	return 'G{}gle'.format('o' * n) if n > 1 else 'invalid'



#Word Numbers! 142

#Create a function that returns a number, based on the string provided. Here is a list of all digits (if you are non english speaker):

#String	Number
#"one"	1
#"two"	2
#"three"	3
#"four"	4
#"five"	5
#"six"	6
#"seven"	7
#"eight"	8
#"nine"	9
#"zero"	0
#Examples
#word("one") ➞ 1

#word("two") ➞ 2

#word("nine") ➞ 9
#Notes
#All numbers will be 1 digit and they will always exist, also all numbers will be in ℕ ℕo(don't have decimal places, and they are positive, including 0).

def word(s):
	dict = {"one": 1,
	"two": 2,
	"three": 3,
	"four": 4,
	"five": 5,
	"six": 6,
	"seven": 7,
	"eight": 8,
	"nine": 9,
	"zero": 0}
	
	return dict.get(s)



#Video Streaming Plans 143
#Given a class for a BasicPlan, write the classes for StandardPlan and PremiumPlan which have class attributes of the following:

#BasicPlan	StandardPlan	Premium Plan
#✓	✓	✓	can_stream
#✓	✓	✓	can_download
#✓	✓	✓	has_SD
#✓	✓	has_HD
#✓	has_UHD
#1	2	4	num_of_devices
#$8.99	$12.99	$15.99	price
#Examples
#BasicPlan.has_SD ➞ True

#PremiumPlan.has_SD ➞ True

#BasicPlan.has_UHD ➞ False

#BasicPlan.price ➞ "$8.99"

#PremiumPlan.num_of_devices ➞ 4
#Notes
#Try using Inheritance to complete the challenge! If you're unsure what that means, try checking out the Python class tutorials in the Resources tab.

class BasicPlan:
	can_stream = True
	can_download = True
	num_of_devices = 1
	has_SD = True
	has_HD = False
	has_UHD = False
	price = '$8.99'
	
# Write the classes for StandardPlan and PremiumPlan here!