using System;
using TECHCOOL;
using System.Collections.Generic;

namespace Webshop_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLet.ConnectSqlServer("Webshop", @"JACK-ANDERSEN-J");

            ShowBasket();

        }

        static void ShowBasket()
        {
            string[][] result = SQLet.GetArray("SELECT * FROM Basket");
            foreach (var row in result)
            {
                foreach (var field in row)
                {
                    Console.Write(field + "\t");
                }

                Console.WriteLine();

            }
        }

    }
}
