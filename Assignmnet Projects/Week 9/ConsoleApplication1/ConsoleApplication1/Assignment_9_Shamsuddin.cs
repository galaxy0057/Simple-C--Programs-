using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_9
{
    class Program
    {
        double pricePoint;   ///assign the global variables
        double multiplier;


        static void changePrices(double[]item_price, double pricePoint, double multiplier) //price changer method
        {
            Console.WriteLine("Enter the price cutoff point (eg $15.00) $");
            pricePoint = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the percentage price change (eg 0.25)");
            multiplier = Convert.ToDouble(Console.ReadLine());


            for (int x = 0; x < item_price.Length; x++) //loop to cycle through element indexes and change values as appropriated by logic
            {
                if (item_price[x] < pricePoint)
                {
                   item_price[x] = item_price[x] + item_price[x]*multiplier;
                }
            }

            

        }


            static void printit(string[] item_name, double[] item_price) //print method will print twice once before and after user input
        {
            for (int x = 0; x < item_price.Length; x++)
            {
                Console.WriteLine("The price for item " + (item_name[x]) + "is " + item_price[x]);
            }
        }


        static void Main(string[] args) //entry point for method 
        {
            double pricePoint = 0; //define variables again for object reference for pass-by reference 
            double multiplier = 0;

            //two arrays
            double[] item_price = new double[] { 15.50, 50.99, 25.00, 115.49, 75.25 }; //double intilializer array
            string[] item_name = new string[] { "Widget", "Thingy", "Ratchet", "Clanger", "Fracker" }; //string initializer array


            Console.WriteLine();
            printit(item_name, item_price); //first printit to display initializer arrays 
            Console.WriteLine();


            changePrices(item_price, pricePoint, multiplier); //method to call for user input and check/change prices 
            Console.WriteLine();
            printit(item_name, item_price); //display the modified prices. 

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }


        


        


    }
}