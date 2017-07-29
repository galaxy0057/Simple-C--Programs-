using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Asignment_4_Shamsuddin
    {
        static void Main(string[] args)
        {
            //Declaration and initialization of employee variables, hourly pay rate, hours worked and pay

            double emp1HR = 0; //Employee - hourly rate, hours worked and pay
            double emp1HW = 0;  //variables need to be double because of overtime calculation
            double emp1Pay = 0; //decimal variables for monetary values


            int count = 1; //variable to control the sentinel and keep employee count to three

            //Start of sentinel while loop

            while (count <= 3) //setinel will run until counter value hits 3
            {

                Console.WriteLine("Enter hourly rate: ");    //prompting for user input
                emp1HR = Convert.ToDouble(Console.ReadLine()); //reading user input 

                Console.WriteLine("Enter hours worked: ");
                emp1HW = Convert.ToInt32(Console.ReadLine()); 

                //Start of if else conditional statements to compute pay 

                if (emp1HW <= 40) //regular time pay calculation
                {
                    emp1Pay = emp1HR * emp1HW;
                    Console.WriteLine("Pay for employee is: "+ emp1Pay); // display pay 
                }

                else if (emp1HW > 40) //overtime pay calculation
                {
                    emp1Pay = ((emp1HW - 40)*(emp1HR* 1.5)) + (40* emp1HR);
                    Console.WriteLine("Pay for employee is: " + emp1Pay);
                }

                count = count + 1; //adding iteration to sentinel control variable

            }// end of while loop

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine(); // to keep console window open








        }
    }
}
