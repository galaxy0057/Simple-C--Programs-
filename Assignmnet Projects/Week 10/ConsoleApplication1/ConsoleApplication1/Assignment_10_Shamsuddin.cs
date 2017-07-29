using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Assignment_10_Shamsuddin
    {

        public string[] WordNum = { "Widget 15.50", "Thingy 90.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" }; //master array from which to be parsed declared as global variable
        public string[] stringParsed = new string[5]; //declared as global variable new parsed string of characters
        public double[] numParsed = new double[5]; //declared as globabl variable new parsed string of double 

        static void StringParser(string[] WordNum, string[] stringParsed, double[] numParsed) //Parser method
        {

                for (int i = 0; i < 5; i++) //for loop to interate through master array and assign elements to secondary arrays
                {
                    stringParsed[i] = WordNum[i].Substring(0, 7); //parses strings from master array with index position starting at 0 and parsing the next 7 characters

                    numParsed[i] = Convert.ToDouble(WordNum[i].Substring(7,5));  //parses double values from master array with index position starting at 7 and the next 5 digits 
                }


        }
        
        
        
        
        
        static void Main(string[] args) //entry point for program 
        {

        string[] WordNum = { "Widget 15.50", "Thingy 90.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" }; // reintitializing global variables for object reference 
        string[] stringParsed = new string[5];
        double[] numParsed = new double[5];

        StringParser(WordNum, stringParsed, numParsed); //method call to StringParser with by reference values

        for (int i = 0; i < 5; i++) //loop to write values of secondary strings 
        {

            Console.WriteLine(stringParsed[i]+ " $"+ numParsed[i]);
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

        }
    }
 }

