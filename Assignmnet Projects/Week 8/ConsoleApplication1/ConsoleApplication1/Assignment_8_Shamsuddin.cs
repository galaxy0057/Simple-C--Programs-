using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sp1 = new int[10]; //create integer array with length 10
            Random numberRandom = new Random(); //create a random number generator 

            for(int counter = 0; counter < sp1.Length; counter = counter + 1) //first loop to initialize values of the elements of array sp1 
            {
              sp1[counter] = numberRandom.Next(1,1000); //goes through each of the 10 indexes of sp1 and generates a random number (from 1 to 1000) store in that index
            }

            for (int write = 0; write < 10; write = write + 1) //second loop to go through each index position of sp1 and print the value
            {

                Console.WriteLine("The array value is {0} ", sp1[write]); //prints the value of sp1 for indexes 0-10
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();




        }
    }
}
