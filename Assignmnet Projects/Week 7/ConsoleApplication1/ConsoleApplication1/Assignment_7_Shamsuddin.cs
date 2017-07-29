using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Assignment_7_Shamsuddin
    {
        static int getRandomNumber() //random number generator method 
        {
            Random rGenerator = new Random();
            return rGenerator.Next(1, 101);  //will generate random numbers from 1 to 100. 

        }

        public static void calculate(double total, ref double average, double divider) // non-overload calculate method, calculates average of 20 random numbers using by ref average (locally)
        {

            average = total / divider;   //computation of average
        }

        public static void calculate(double userInput, ref double total) //overload calculat method, calculates total of 5 user input double values 
        {

            total = total + userInput; //computation of total 
        }


        static void Main(string[] args) //the entry point for the program 
        {
            int numberRandom; //declaration of 4 variables for the program
            double average = 0;
            double total = 0;
            double entryInput = 0;


            for (int i = 0; i < 20; i = i + 1) //loop to generate 20 random numbers and call getRandom method
            {

                numberRandom = getRandomNumber();
                total = total + numberRandom;

            }

            calculate(total, ref average, 20); //calling non-overload calculate method
            {
                Console.WriteLine("The average of the 20 numbers is " + average);
                Console.WriteLine();
            }

            total = 0;

            for (int i = 0; i < 5; i = i + 1) //loop to ask user entry of 5 double values 
            {
                Console.WriteLine("Please enter a double value ");
                entryInput = Convert.ToDouble(Console.ReadLine());
               
                
                
                calculate(entryInput, ref total); //calling overload calculate method
                {
                    
                }
                
            }

            Console.WriteLine("The total is " + total); //displaying output
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
