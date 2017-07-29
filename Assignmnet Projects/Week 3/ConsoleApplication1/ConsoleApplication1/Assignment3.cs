using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class ChangeMethod 
    {
        public int value1; 
        public int value2;
        public int vm1;
        public int vm2; 


       

        public ChangeMethod(int vm1, int vm2)
        {
            if (value1 > 5)
            {
                vm1 = value1;
                
            }

            if (value1 <= 5)
            {
                vm1 = value1 + vm2;
                
            }

            if (vm2 < 10)
            {
                vm2 = (vm2 * vm2) + 5;
                
            }

            if (vm2 >= 10)
            {
                vm2 = vm2;
                
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

            Console.WriteLine("The calculated value is " + (vm1*vm2) +
                ". Press any Key to continue");
            Console.ReadLine(); 
        }



    }

 
    class Assignment3
    {
        static void Main(string[] args)
        {

            int v1;
            int v2;

            Console.WriteLine("Enter an integer value: ");
            v1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter an integer value: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            ChangeMethod cMethod = new ChangeMethod(v1, v2);

            
            cMethod.Value1 = v1;
            cMethod.Value2 = v2;
            cMethod.printIt(); 
      




        }
    }
}
