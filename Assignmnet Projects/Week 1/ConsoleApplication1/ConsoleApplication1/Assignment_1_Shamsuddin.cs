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
           int input1 ;
           int input2 ;
           int input3 ;
           int average;
           int remainder; 

        
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer score " + input1);

            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer score " + input2);
            
            input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer score " + input3);
      

            average = (input1 + input2 + input3)/3;
            remainder = (input1 + input2 + input3)%3;
            Console.WriteLine("The average of " +input1+","+input2+","+input3+" is " +average+ " with remainder of "+ remainder);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
