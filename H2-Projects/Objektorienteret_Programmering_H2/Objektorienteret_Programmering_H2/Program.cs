using LearningOverloading;
using LearningOverriding;
using System;

namespace Objektorienteret_Programmering_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading
            Overloading objProgram = new Overloading();
            Console.WriteLine("Add with two int parameter :" + objProgram.Add(5, 10));
            Console.WriteLine("Add with three int parameter :" + objProgram.Add(100, 4, 2));
            Console.WriteLine("Add with two float parameter :" + objProgram.Add(7f, 77f));
            Console.WriteLine("Add with two string parameter :" + objProgram.Add("hello", "world"));
            Console.ReadLine();

            //Overriding
            BaseClass baseClassObj;
            baseClassObj = new BaseClass();
            Console.WriteLine("Base class method Add :" + baseClassObj.Add(-7, 10));
            baseClassObj = new ChildClass();
            Console.WriteLine("Child class method Add :" + baseClassObj.Add(-4, 22));
            Console.ReadLine();

        }
    }
}
