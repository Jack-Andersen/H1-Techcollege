using System;

namespace LearningOverriding
{
    public class BaseClass
    {
        public virtual int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    class ChildClass : BaseClass
    {
        public override int Add(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First value : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First value : ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            return (num1 + num2);
        }
    }
}