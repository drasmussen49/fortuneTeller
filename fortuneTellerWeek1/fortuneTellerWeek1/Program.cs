using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTellerWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Initiated... Follow instructions to receieve your fortune.");

            ////// Pt 1 - Demographics
            string fName;
            string lName;
            string favColor;
            string vacHome;
            string carModel;

            int age;
            int bMonth;
            int sibs;
            int dough;
            int retireYears;

            // Ask for first and last name
            Console.WriteLine("What is your first name?");
            fName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            lName = Console.ReadLine();
            Console.WriteLine();

            // Ask for age
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Ask birth month as int
            Console.WriteLine("Provide your birth month in date format (##)");
            bMonth = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Ask for ROYGBI(indigo)V fav color; if w/ "help" (quotes in console)
            // set car model

            Console.WriteLine("What is your favorite color of ROYGBIV? - If you do not know ROYGBIV, type \"Help\"");
            favColor = Console.ReadLine();
            carModel = "";
            favColor = favColor.ToLower();
            switch (favColor)
            {

                case "\"help\"":
                    Console.WriteLine("ROYGBIV: Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.WriteLine("Please enter your favorite color:");
                    favColor = Console.ReadLine();
                    favColor = favColor.ToLower();
                    break;
                default:
                    break;
            }
            switch (favColor)
            {
                case "red":
                    favColor = "red";
                    carModel = "space shuttle";
                    break;
                case "orange":
                    favColor = "orange";
                    carModel = "prius";
                    break;
                case "yellow":
                    favColor = "yellow";
                    carModel = "subaru";
                    break;
                case "green":
                    favColor = "green";
                    carModel = "teleportation gun";
                    break;
                case "blue":
                    favColor = "blue";
                    carModel = "viper";
                    break;
                case "indigo":
                    favColor = "indigo";
                    carModel = "beatle";
                    break;
                case "violet":
                    favColor = "violet";
                    carModel = "pod racer";
                    break;

                default:
                    Console.WriteLine("Your response is invalid. Favorite color not recorded.");
                    carModel = "camero";
                    break;
            }


            // How many siblings?
            Console.WriteLine("How many siblings do you have?");
            sibs = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\r\n\r");


            // fortunte generation
            Console.WriteLine("Your fortune is generating...");
            Console.WriteLine("...");

            // even or odd
            if (2 % age == 0)
            {
                retireYears = 2;
            }
            else
            {
                retireYears = 19;
            }

            //

            if (sibs == 0)
            {
                vacHome = "Italy";
            }
            else if (sibs == 1)
            {
                vacHome = "Japan";
            }
            else if (sibs == 2)
            {
                vacHome = "Mother Russia";
            }
            else if (sibs == 3)
            {
                vacHome = "Lake Erie";
            }

            else if (sibs > 3)
            {
                vacHome = "Pompeii, circa 79BC";
            }

            else
            {
                vacHome = "Antarctica";
            }

            Console.WriteLine("\n\r\n\r");

            // how much cashMoney
            if (bMonth > 0 && bMonth <= 4)
            {
                dough = 2500;
                Console.WriteLine();
            }

            else if (bMonth > 4 && bMonth <= 8)
            {
                dough = 25000;
                Console.WriteLine();
            }

            else if (bMonth < 8 && bMonth <= 12)
            {
                dough = 49;
                Console.WriteLine();
            }
            else
            {
                dough = 0;
                Console.WriteLine();
            }

            // Print output

            Console.WriteLine("Your fortune is as follows: ");
            Console.WriteLine(fName + " " + lName + " will retire in " + retireYears + " years with " + dough + " in the bank, a vacation home in " + vacHome + " and a " + carModel + " to get around.");
            Console.WriteLine("\n\r\n\r");





        }
    }
}
