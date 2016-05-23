using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By Cherr Batac and James Yahnke
namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set for loop 1 to 100
            for(int index=1; index<=100; index++)
            {
                //Flag to deterimine to print iteration number to the string
                //Set to true, but if we print set to false so we won't print number
                bool PrintNumber = true;

                //Test for index mod 3, if so print out Cameron's name
                if(index % 3 == 0)
                {
                    Console.Write("Cameron");
                    //Supress the line print out
                    PrintNumber = false;
                }
                //Test for index mod 5, and if true print out Sean's name
                if(index % 5 == 0)
                {
                    Console.Write("Sean");
                    //Suppress the line print out
                    PrintNumber = false;
                }
                //If we make it here, print out the line number since neither string was printed out
                if(PrintNumber)
                    Console.Write("{0}",index);
                    Console.WriteLine();
            }
            //Keeps the window open
            Console.ReadLine();
        }//end of static
    }//end of class
}
