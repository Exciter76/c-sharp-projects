using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Bike_Rental_Application
{
    class Routines
    {
        

        /* 
         *  Method          : Exit
         *  
         *  Preconditions   : None
         *  
         *  Postconditions  : The Application is closed.
         *  
         *  Inputs          : None
         *  
         *  Output          : None
         */
        public static void Exit()
        {
            //Close the console application gracefully.
            Environment.Exit(0);
        }

        /*
         *  Function that prints the application title.
         *  
         *  Usage:
         *  
         *  Routines.screenTitle()
         *  
         *  This method prints the title of the application right aligned
         *  on the console(Centre of the Screen).
         *  
         */
        public static void screenTitle()
        {
            screenBuffer();
            Console.WriteLine(Program.sScreenTitle);

        }

        /*
         * Method that prints text to the console.
         * 
         * Usage:
         * 
         * Routines.screenPrint(value)
         * 
         * This method accepts a value as a string, formats the 
         * screen to the right align and prints the value of
         * the parameter.
         * 
         */
        public static void screenPrint(String value)
        {
            screenBuffer();
            Console.WriteLine(value);
        }
        
        /*
         * Function that right algins text.
         * 
         * Usage:
         * 
         * Routines.screenBuffer()
         * 
         * screen buffer right alings text by adding spaces
         * for padding. Call this before printing text
         * to the console.
         * 
         */
        public static void screenBuffer()
        {
            String sBlank = "";
            Console.Write(sBlank.PadLeft(30, ' '));
        }

        /*
         *  Method that pauses the screen. 
         *  
         *  Usage:
         *  
         *  Routines.pauseScreen()
         *  
         *  Use this function to pause the screen so as 
         *  the user can read the information on the 
         *  screen before execution exits a routine.
         */
        public static void pauseScreen(String value)
        {
            // Pause screen before program ends.
            Routines.screenBuffer();
            Console.Write(value);
            Console.ReadLine();

        }

        /*
         *  Clears the screen blank
         *  
         *  Usage : Routines.clearScreen()
         *  
         *  This routines clears down the screen. This is to
         *  help clear old text on the screen that is not 
         *  revelant.
         *  
         */
        public static void clearScreen()
        {
            Console.Clear();
        }

        /*
         * Book A Bike
         * 
         * Usage : Routines.bookBike()
         * 
         * Books an available bike from the dealer. Creates a booking
         * with a booking id.
         */
        public static void BookBike()
        {
            Routines.clearScreen();
            Routines.screenTitle();
            Routines.screenPrint("");

            try
            {
                Routines.screenPrint("Please note: book one bike per booking");
                Routines.screenPrint("");

                int nBikeNo = Validations.getInteger("Enter the bike number you want to book: ");
                int nRentDuration = Validations.getInteger("Enter the number of days you want to book: ");
                String dtStartDate = Validations.getString("Enter the date you want to collect the bike: ");

                double dAmount = Calculations.getBikePrice(nBikeNo, nRentDuration);

                Routines.screenPrint("The bike number " + nBikeNo + " for " + nRentDuration + " days will cost € " + Calculations.getVat(dAmount) + " including VAT @ 21%");

                //credit card details
                String sCreditCardNumber = Validations.getString("Please enter your credit card number :");
                String sCreditCardDate = Validations.getString("Enter your credit card expiry date :");
                String sCreditCardCVC = Validations.getString("Enter your credit card CVC number :");

                //Booking will be processed here and a booking id will be generated
                String sBookingID = "XC6YWDD";

                //Booking complete. Infrom the customer and print the details and booking number needed for collection.
                Routines.clearScreen();
                Routines.screenTitle();
                Routines.screenPrint("");

                Routines.screenPrint("Thank you for booking a bike from us");
                Routines.screenPrint("");
                Routines.screenPrint("Your booking details are as follows:");
                Routines.screenPrint("");

                Routines.screenPrint("Booking Number: " + sBookingID);
                Routines.screenPrint("");
                Routines.screenPrint("Collection date: " + dtStartDate);
                Routines.screenPrint("Rent for a number of " + nRentDuration + " days");
                Routines.screenPrint("If you wish to rent for longer, no problem! (Please note");
                Routines.screenPrint("that a longer duration than quoted will increase the rental ");
                Routines.screenPrint("rate of the bike.)");
                Routines.screenPrint("");
                Routines.screenPrint("Rate: " + Calculations.getVat(dAmount) + " including 21% VAT");

                Routines.screenPrint("");
                Routines.screenPrint("Please note the booking number so as you can collect the bike.");
                Routines.screenPrint("You will also need this booking number to return the bike.");

                Routines.screenPrint("");
                Routines.pauseScreen("Press [Return] key to return to the main menu");
            
            }catch(Exception error)
            {
                Console.WriteLine("Error Numer: 002" + error.Message);
            }
        }

        /*
         * view available bikes
         * 
         * Usage : Routines.viewAvailableBikes()
         * 
         * Display to the console an array of bikes that are available 
         * to rent.
         * 
         */
        public static void viewAvailableBikes()
        {
            Routines.clearScreen();
            Routines.screenTitle();
            Routines.screenPrint("");

            Routines.screenPrint("Here is a list of our exclusive bikes");
            Routines.screenPrint("");

            Routines.screenPrint("Bike no. 1 : Broadman Road Bike");
            Routines.screenPrint("Bike no. 2 : Careara Mountain Bike");
            Routines.screenPrint("Bike no. 3 : Careara Road Bike");
            Routines.screenPrint("");

            Routines.screenPrint("Take a note of the Bike number (Bike no.) and book that bike today!");
            Routines.screenPrint("");
            Routines.pauseScreen("Press [Return] key to return to the main menu");

        }

        /*
         * Return a Bike
         * 
         * Usage    : Routines.ReturnBike(String bookingID)
         * 
         * Make a bike available again in the collection and bill the 
         * customer for the booking
         */
        public static void ReturnBike(String BookingID)
        {
            Routines.clearScreen();
            Routines.screenTitle();
            Routines.screenPrint("");

            try
            {
                //Check to enusre the booking id is valid
                if (BookingID != "XC6YWDD")
                {
                    Routines.screenPrint("Invalid BookingId " + BookingID);

                }
                else
                {
                    Routines.screenPrint("Thank you for returning and hiring the bike from us");
                    Routines.screenPrint("We hope you will call again!");
                    Routines.screenPrint("");
                    Routines.screenPrint("You have been billed : €" + Calculations.getVat(Calculations.getBikePrice(1, 5)));
                    Routines.screenPrint("Through your credit card");
                    Routines.screenPrint("");
                    Routines.screenPrint("Thanks you. Call again!");
                }


                Routines.screenPrint("");
                Routines.pauseScreen("Press [Return] key to return to the main menu");
            
            }catch(Exception error)
            {
                Console.WriteLine("Error code: 0001 " + error.Message);
            }
        }
    }
}
