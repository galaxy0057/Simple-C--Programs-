using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Assignment_11_Shamsuddin
    {
        class Program
        {
            static void Main(string[] args)
            {
                // initializer to initialize 
                // both the apartment and the rent arrays.
                int[] apartment = new int[] { 123, 204, 601, 609, 612 };
                int[] rent = new int[] { 500, 750, 495, 800, 940 };
                int apartmentNumber = 0;

                // Prompt the user for the apartment number.
                Console.WriteLine("Enter the apartment number: " );
                apartmentNumber = Convert.ToInt32(Console.ReadLine());


                // Call the function to get the rent.
                getRent(ref apartment, ref rent, apartmentNumber);

                // Prompt the user to press any key to continue.
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            // GetRent function that passes the apartment and rent array by reference and
            // the desired apartment number by value.
            private static void getRent(ref int[] apartment, ref int[] rent, int apartmentNumber)
            {

                // Loops through each value in the array to find the desired apartment.
                for (int i = 0; i < apartment.Length; i++)
                {
                    // Checks to see if the current apartment is the desired apartment.
                    if (apartment[i] == apartmentNumber)
                    {
                        // Prints the information when the desired apartment is found.
                        printit(apartment[i], rent[i]);
                        return;
                    }
                }

            }

            private static void printit(int apartment, int rent)
            {
                // Builds the string containing the information that will be 
                // displayed to the user using StringBuilder.
                StringBuilder SB = new StringBuilder();
                SB.Append("Rent for apartment #");
                SB.Append(apartment);
                SB.Append(" is $");
                SB.Append(rent);
                SB.Append(".");

                // Displays the string to the user.
                Console.WriteLine(SB.ToString());
            }
        }
    }
}


