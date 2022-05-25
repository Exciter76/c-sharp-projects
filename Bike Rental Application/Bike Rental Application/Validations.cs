using System;
using System.Collections.Generic;
using System.Text;

namespace Bike_Rental_Application
{
    class Validations
    {
        /*
            Function to return a valid integer.

            Usage:

            x = getInteger(“Enter a number”);

            The parameter passed into the function is the screen prompt.

            This function returns a valid integer to the variable assignment 
            statement that called the function

         */
        public static int getInteger(string screenPrompt)
        {
            bool validInteger = false;
            int Number;

            string enteredValue = "";

            while (validInteger == false)
            {
                Routines.screenBuffer();
                Console.Write(screenPrompt);
                enteredValue = Console.ReadLine();
                if (int.TryParse(enteredValue, out Number))
                {
                    validInteger = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            int valueRequired = Convert.ToInt32(enteredValue);
            return valueRequired;
        }

        /*
           Function to return a valid string.

           Usage:

           x = getString(“Enter a Value”);

           The parameter passed into the function is the screen prompt.

           This function returns a valid string to the variable assignment 
           statement that called the function

        */
        public static string getString(string screenPrompt)
        {
            bool validString = false;

            string enteredValue = "";

            while (validString == false)
            {
                Routines.screenBuffer();
                Console.Write(screenPrompt);
                enteredValue = Console.ReadLine();
                if (enteredValue != "")
                {
                    validString = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                }
            }
            return enteredValue;
        }



    }
}
