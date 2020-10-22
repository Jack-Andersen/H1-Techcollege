using System;
using System.Collections.Generic;
using System.Text;

namespace New_Calculator.Class_s
{
    public static class Calculator_methods
    {
        public static int Add(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 + number2;
            return answer;
        }

        public static int Substraction(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 - number2;
            return answer;
        }

        public static int Divide(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 / number2;
            return answer;
        }

        public static int Multiply(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int answer = number1 * number2;
            return answer;
        }



    }
}
