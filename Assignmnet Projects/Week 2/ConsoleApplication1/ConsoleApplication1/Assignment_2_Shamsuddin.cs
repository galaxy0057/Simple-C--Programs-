using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Average
    {
        private int score1; 
        private int score2; 
        private int score3;




    public Average(int value1, int value2, int value3)
    {
            score1 = value1;
            score2 = value2;
            score3 = value3;

    }

    public int Score1
    {
        get
        {
            return score1;

        }
        set
        {

            score1 = value; 
        }

    }
    public int Score2
    {
        get
        {
            return score2;

        }
        set
        {

            score2 = value;
        }

    }

    public int Score3
    {
        get
        {
            return score3;

        }
        set
        {

            score3 = value;
        }

    }

    int average;
    int remainder;


    public void ComputeAverage()
    {
        average = (score1 + score2 + score3) / 3;
        remainder = (score1 + score2 + score3) % 3;
    }

    public void DisplayAverage()
    {
        Console.WriteLine(" The average of " + score1 + ", " + score2 + ", " + score3 + " is " + average+" and the remainder is "+ remainder+". Press any key to continue.");

    }


    }




    class AverageTest
    {
        static void Main(string[] args)
        {


            int v1=0;
            int v2=0;
            int v3=0; // these are local variables I declared because I dont have a empty constructor
            
            Average avg = new Average(v1, v2, v3);
            avg.Score1 = 4;
            avg.Score2 = 5;
            avg.Score3 = 6;
            avg.ComputeAverage();
            avg.DisplayAverage();

            Console.ReadLine(); 
      
        }
    }
}
