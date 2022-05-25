using System;
using System.Collections.Generic;
using System.Text;

namespace Bike_Rental_Application
{
    class Calculations
    {
        /*
         *  Query the price of a bike over a duration.
         *  
         *  Usage:
         *  
         *  double cost = Calculations.getBikePrice(bikeNo, duration)
         *  
         *  This method calculates the price of a choosen bike 
         *  by the number of rental days.
         */
        public static double getBikePrice(int bikeNo, int duration)
        {
            return duration * 20.50;
        }

        /*
         *  Calculate and return the total cost including VAT.
         *  
         *  Usage:
         *  
         *  totalCost = Calculations.getVat(cost)
         *  
         *  This method takes a value that is before vat and
         *  returns the total amount including VAT at 21%.
         */
        public static double getVat(double Cost)
        {
            return Math.Round(Cost + (Cost * 0.21),2);
        }
    }
}
