using System;
using System.Linq;

// Jack

/*
 * This project is a collection of exersises that will teach students how to write clean and DRY code.
 * These exersises are stutable for beginer to experienced programmers.
 */
namespace CleanCodeExersises
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /*
         * Magic Number exercise
         */
        public bool IsLegalDrikingAgeDirty(int age)
        {
            if (age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to Magic Number exercise
         * Use consts to describe the numbers you are using to your programs.
         */
        public bool IsLegalDrikingAgeClean(int age)
        {
            // throw new NotImplementedException();
            //Write your solution here

            const int IslegalDrinkingage = 21;
            return age > IslegalDrinkingage;     

        }
        /*
         * Be positive exersise
         */
        public bool IsLoggedInDirty(bool isNotloggedIn)
        {
            if (!isNotloggedIn == true)
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Failed to logged in.");
                return false;
            }
        }
        /*
         * Solution to Be positive exersise
         */
        public bool IsLoggedInClean(bool isloggedIn)
        {
            //throw new NotImplementedException();
            //Write your solution here

            if (isloggedIn)
            {
                System.Console.WriteLine("Succesfully logged in.");
                return true;
            }

                System.Console.WriteLine("Failed to logged in.");
                return false;

        }
        /*
         * Intermediate exercise
         * What is the question answering?
         */
        public bool eligibleDirty(Employee employee)
        {
            if (employee.Age > 55
                && employee.YearsEmployed > 10
                && employee.IsRetired == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Solution to ohm Intermediate exercise
         * An intermediate Variable says a lot more them a long expression
         */
        public bool eligibleClean(Employee employee)
        {
            //throw new NotImplementedException();
            //Write your solution here

            const int RetiredAge = 55;
            const int Employed = 10;
            bool IsEligiblePerson = employee.Age > RetiredAge
                && employee.YearsEmployed > Employed
                && employee.IsRetired;

            return (IsEligiblePerson);

        }
        
        /*
         * Ternary exersise
         */
        public double GetPriceDirty(bool isPreordered)
        {
            if (isPreordered == true)
            {
                return 200.00;
            } else
            {
                return 350.00;
            }
        }
        /*
         * Solution to Ternary exersise
         * Use a oneline Ternary.
         */
        public double GetPriceClean(bool ispereordered)
        {
            //throw new NotImplementedException();
            //Write your solution here

            const int prise1 = 200;
            const int prise2 = 350;

            return (ispereordered ? prise1 : prise2);

        }
        /*
         * Strong type exersise - not done
         */

    }
}


