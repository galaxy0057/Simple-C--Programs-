using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{

    public class HypotenuseProgram
    {
        private double a;  //defining triangle side variables
        private double b;
        private double c; 


        public HypotenuseProgram(double at, double bt) //creating the public method 
        {
            a = at; //setting the attributes
            b = bt;

           

        }

        public double A //get set to obtain method value from input
        {
            get
            {
                return a;
            }
            set
            {
                a = value; 
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        

        public void HypotenuseDisplay()   //method for when sides not equal to zero
        {
            c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            
            Console.WriteLine("The hypotenuse is " + c + ".");
            Console.WriteLine();
        }

        public void HypotenuseDisplayZero()     //methods for when sides equal to zero
        {
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenuse is " + c + ".");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine(); 
        }

    }


    class Assignment_6_Shamsuddin
    {
        static void Main(string[] args)
        {
            double A = 0; //for do-while loop conditon
            double B = 0;
           
            do
            {
                double Am = 0;
                double Bm = 0;
                HypotenuseProgram hMethod = new HypotenuseProgram(Am, Bm); //calling Hypotenuse program and passing inputs

                Console.WriteLine("enter length of first side: "); //asking for user input
                Am = Convert.ToDouble(Console.ReadLine()); //converting string to value
                hMethod.A = Am; //setting value in method

                Console.WriteLine("enter length of second side: ");
                Bm = Convert.ToDouble(Console.ReadLine());
                hMethod.B = Bm;
                
                
                A = Am; // for do while condition exit parameters
                B = Bm;
                if (A == 0 && B == 0)   //if else to decide which dispaly method to execute based on user input
                {
                    hMethod.HypotenuseDisplayZero();
                }
                else
                {
                    hMethod.HypotenuseDisplay();
                }
                

            } while (A > 0 && B > 0);



        }
    }
}
