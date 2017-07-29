using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Assignment_5_Shamsuddin
    {
        static void Main(string[] args)
        {
            //I will use counter-controled for loops as I find it to be most appropriate for this case
                                                            
           //First nested loop structure for triangle 1
                                                            
            for (int r = 1; r < 11; r = r + 1)             //First for loop to create the 10 rows, r is initialized at 1 because first output is 2 
            {
                for (int c = 1; c <= r; c = c + 1)          //Second nested for loop to create columns with star
                {
                Console.Write("*");
                    if (c == r)                     //if statement to append the number at the end of the star character line 
                    {
                    Console.Write(c * 2);   //the appended number is number of starts multipled by 2
                    } 
  
                }    
                     Console.WriteLine();   //to go to next line after all column positions have been filled with a star 
                     
             }

            Console.WriteLine();          //for space between two structures                               
            
            
            //Second nested loop structure for inverted triangle 2

            for (int rI = 10; rI >= 1; rI = rI - 1)           //First for loop to create the 10 rows, reverse logic of first loop structure above 
            {
                for (int cI = 1; cI <= rI; cI = cI + 1)       //Second for loop for columns with stars   
                {
                    Console.Write("*");

                    if (cI == rI)                               //if statement to append the number at the end of the star character line
                    {
                        Console.Write(cI * 2);
                    }


                }
                Console.WriteLine();


            }


                Console.ReadLine(); //to keep output window open after loop execution 
              
            }




        }
    }

