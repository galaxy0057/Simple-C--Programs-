using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class ChangeMethod
    {
        private int value1;
        private int value2;
        private int pm; // value holder variables for the printIt method multiplication
        private int pm1;




        public ChangeMethod(int vm1, int vm2)
        {
            value1 = vm1;
            value2 = vm2;


            if (vm1 > 5)
            {
                pm = value1;

            }

            if (vm1 <= 5)
            {
                pm = value1 + value1;

            }

            if (vm2 < 10)
            {
                pm1 = (value2 * value2) + 5;

            }

            if (vm2 >= 10)
            {
                pm1 = value2;

            }

        }

        public int Value1
        {
            get
            {

                return value1;
            }

            set
            {
                value1 = value;
            }

        }

        public int Value2
        {
            get
            {

                return value2;
            }

            set
            {
                value2 = value;
            }

        }

        public void printIt()
        {

            Console.WriteLine("The calculated value is " + (pm * pm1) +
                ". Press any Key to continue...");
            Console.ReadLine();
        }



    }


    class Assignment3
    {
        static void Main(string[] args)
        {

            int v1 = 0;
            int v2 = 0;
            //Console.WriteLine("enter an integer value: ");
            //v1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter an integer value: ");
            //v2 = Convert.ToInt32(Console.ReadLine());

            ChangeMethod cMethod = new ChangeMethod(v1, v2);
            
            Console.WriteLine("enter an integer value: ");
            cMethod.Value1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter an integer value: ");
            cMethod.Value2 = Convert.ToInt32(Console.ReadLine());
             cMethod.printIt();
        }
    }
}
