using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isLooping = true;

            while (isLooping)

            {

                Regex theNamePattern = new Regex(@"^[A-Z].{1,29}$");
                Regex theEmailPattern = new Regex(@"^([a-zA-Z0-9]).{4,29}@([a-zA-Z0-9]){5,10}.([a-zA-Z0-9]){2,3}$");
                Regex thePhonePattern = new Regex(@"^\d{3}-\d{3}-\d{4}$");
                Regex theDatePattern = new Regex(@"^\d{2}/\d{2}/\d{4}$");

                Console.WriteLine("Please Enter a Valid Name:");
                string userInput = Console.ReadLine();

               

                if (theNamePattern.IsMatch(userInput))

                {
                    Console.WriteLine("This is a valid name!");

                }

                 if (!theNamePattern.IsMatch(userInput))

                {
                    Console.WriteLine("Sorry, name is not valid!");

                }



                Console.WriteLine("Please enter a valid email:");
                string userInput2 = Console.ReadLine();

                if (theEmailPattern.IsMatch(userInput2))
                {
                    Console.WriteLine("Email is Valid!");
                }

                if (!theEmailPattern.IsMatch(userInput2))
                {
                    Console.WriteLine("Sorry, email is not valid!");
                }

                Console.WriteLine("Please enter a valid phone number:");
                string userInput3 = Console.ReadLine();

                if (thePhonePattern.IsMatch(userInput3))
                {
                    Console.WriteLine("Phone number is valid!");
                }

                if (!thePhonePattern.IsMatch(userInput3))
                {
                    Console.WriteLine("Sorry, phone number is not valid!");
                }

                Console.WriteLine("Please enter a valid date:");
                string userInput4 = Console.ReadLine();

                if (theDatePattern.IsMatch(userInput4))
                {
                    Console.WriteLine("Date is valid!");
                }

                if (!theDatePattern.IsMatch(userInput4))
                {
                    Console.WriteLine("Sorry, date is not valid!");
                }
                else
                {
                    isLooping = false;
                }

                Console.ReadLine();
            }

        
        }
    }
}
