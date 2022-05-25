using System;
using System.Diagnostics;

namespace Bike_Rental_Application
{
    class Program
    {
        public static String sScreenTitle = "Bike Rental Application";      //The screen title is global so as it can be consistent throughout

        static void Main(string[] args)
        {
            int nOption = 0;
            const int OPTION_EXIT = 4;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Main Application
            while (nOption != OPTION_EXIT)
            {
                //print the title of the application
                Routines.screenTitle();
                Routines.screenPrint(" ");

                //Menu options
                Routines.screenPrint("1. Book a bike");
                Routines.screenPrint("2. Return a bike");
                Routines.screenPrint("3. Look at available bikes");
                Routines.screenPrint("4. Quit");
                Routines.screenPrint(" ");

                //Read the user option and ensure that its a valid number
                int userOption = Validations.getInteger("Please select an option: ");

                //clear down the screen option for new screen
                Routines.clearScreen();

                //Evaluate the users option and render accordingly
                switch(userOption)
                {
                    case 1:
                        Routines.screenTitle();
                        //int bikeID = Validations.getInteger("Select a bike number: ");
                        Routines.BookBike();
                        Routines.clearScreen();
                        break;
                    case 2:
                        String BookingId = Validations.getString("Enter in a Booking Code: ");
                        Routines.ReturnBike(BookingId);
                        Routines.clearScreen();
                        break;
                    case 3:
                        Routines.viewAvailableBikes();
                        Routines.clearScreen();
                        break;
                    case 4:
                        Routines.pauseScreen("Press [Enter] key to continue");
                        nOption = OPTION_EXIT;
                        break;
                }
                
            };

            //close the Application
            Routines.Exit();


        }
    }
}
