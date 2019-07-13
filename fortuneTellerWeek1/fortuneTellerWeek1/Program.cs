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
            // console app to generate a silly fortune from some demographic info.
            // use color to determine a car model
            // use even or odd age to determine retirement age
            // number of siblings for vacation home location
            // birthMonth as integer for retirement payout per month

            Console.WriteLine("Program Initiated... Follow instructions to receieve your fortune.");

            ////// Pt 1 - Demographics / variable initialize


            // Ask for first and last name
            string firstName;
            string lastName;
            string fullName;
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your full name?");
            fullName = firstName + " " + lastName;
            Console.WriteLine("Is " + fullName + " your full name?");
            Console.ReadLine();


            // Ask for age
            int? age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            // Ask birth month as int
            int birthMonth;
            Console.WriteLine("What is your birth month, as a number 1 through 12?");
            birthMonth = Convert.ToInt32(Console.ReadLine());

            // Ask for ROYGBI(indigo)V fav color; if w/ "help" (quotes in console)
            // set car model

            Console.WriteLine("What is your favorite color of ROYGBIV? - If you do not know ROYGBIV, type \"Help\"");
            // use a switch statement for this
            string carModel;
            string colorChoice = Console.ReadLine().ToLower();

            switch (colorChoice)
            {
                case "help":
                    Console.WriteLine("ROYGBIV is Red, Orange, Yellow, Green, Blue, Indigo or Violet");
                    Console.WriteLine("What is your favorite color of ROYGBIV?");
                    colorChoice = Console.ReadLine().ToLower();
                    break;
                default:
                    break;
            }
            switch (colorChoice)
            {
                case "red":
                    carModel = "Miata";
                    break;
                case "green":
                    carModel = "Corvette";
                    break;
                case "blue":
                    carModel = "BRZ";
                    break;

                default:
                    carModel = "Corolla";
                    break;
            }

            // How many siblings?



            // fortune generation
            Console.WriteLine("Your fortune is generating...");
            Console.WriteLine("...");

            // use if-statements for these questions
            // even or odd age

            // number of siblings


            // how much cashMoney


            // Print output

            Console.WriteLine("Your fortune is as follows: ");
            Console.ReadLine();
        }
    }
}
