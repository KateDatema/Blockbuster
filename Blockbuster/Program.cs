using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GC Blockbuster!");

            bool goOn = true;
            while (goOn == true)
            {
                BlockBusterVideo bv = new BlockBusterVideo();

                Console.WriteLine("Please Select a Movie to check out and watch from the list");

                bv.PrintAllMovies();

                bv.Checkout();

                GetContinue();

            }


        }
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            //There are 3 cases we care about 
            //1) y - we want to continue 
            //2) n - we want to stop 
            //3) anything else - we want to try again

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                //Calling a method inside itself is called recursion
                //Think of this as just trying again 
                return GetContinue();
            }
        }
    }
}
