using System;
using System.Collections.Generic;
using System.Threading;
using System.Web;
using Interfaces_Exercise_01;

namespace Interfaces_Exericse_01_Answers
{
    class Program
    {
        // TODO: Create an Interface called IParts
        // TODO: Create a BuildPart() stubbed out method that has a return type of IParts       
        public static void BuildPart()
        {

        }
        // BONUS
        // TODO: Create methods to abstract away most of the code from your Main() method
        // TODO: Create a Utility class to encapsulate those methods into 1 location
        // TODO: Create a folder to hold all of your Part Classes in 1 location

        static void Main(string[] args)
        {
            // TODO: Create an IParts List called partsList that will hold all of the parts we want to create
            var partsList = new List<IParts>();

            // TODO: Create a do-while loop that only ends when the user types "no" (or 'n')
            // TODO: Greet the user and ask them which part they would like to create


            // TODO: Call that parts BuildPart() method


            // TODO: Add the part to the partsList


            // TODO: Ask them if they would like to continue or exit the program
            Utility.Greet();

            do
            {
                var part = Utility.GetPart();
                part.BuildPart();
                partsList.Add(part);
                var continuing = Utility.Continue();
                if (continuing == "n" || continuing == "no")
                {
                    break;
                }

            } while (true);


            Console.WriteLine("Parts List:");
            int counter = 0;
            foreach (var part in partsList)
            {
                Console.WriteLine($"Part #{counter}: {part.GetType().Name}");
                counter++;

                // TODO: Print out all the parts in the parts list to the console

            }
        }
    }
}