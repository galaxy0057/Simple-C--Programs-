using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class myPayfile
    {
        //declare the class variables

        private string last_name;
        private string first_name;
        private double gross_pay;

        //no argument constructor (not used)

        public myPayfile()
        {


        }

        //three-argument constructor to set the values input to the console

        public myPayfile(string fname, string lname, double pay)
        {

            last_name = lname;
            first_name = fname;
            gross_pay = pay;


        }

        //public class method to return the individual value

        public string getLast_Name(string fname, string lname, double pay)
        {

            return last_name;

        }

        //public class method to return the individual value

        public string getFirst_Name()
        {

            return first_name; 

        }

        //public class method to return the individual value

        public double getGross_Pay()
        {

            return gross_pay;

        }

        //public class method to recompute the pay value

        public void adjustPay()
        {

            gross_pay = gross_pay * 1.2;

            //adjust the pay by multiplying it by a factor of 1.2
        }
        static void Main(string[] args) //entry point for the program
        {
            Console.WriteLine("Enter the first name");  //read the input parameters
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name" );
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the raw pay {0} ");
            double pay = Convert.ToDouble(Console.ReadLine()); 
            myPayfile myPfile = new myPayfile(firstName, lastName, pay);//create method call for MyPay method
            myPfile.adjustPay();
            Console.WriteLine("The adjusted pay is $" + myPfile.gross_pay.ToString() + " for " + myPfile.first_name + " " + myPfile.last_name);
            Console.ReadLine();
        }


    }
}
