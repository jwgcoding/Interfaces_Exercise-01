using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Xsl;
using Interfaces_Exercise_01;

namespace Interfaces_Exercise_01
{
    public class Utility
    {
        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Greet()
        {
            Console.WriteLine("Welcome to Parts Factory!");
            Console.WriteLine("For a bike part, type: bike");
            Console.WriteLine("For a car part, type: car");
            Console.WriteLine("For a truck part, type: truck");
            Console.WriteLine("For a plan part, type: plane");
            AddSpace();
        }

        public static IParts GetPart()
        {
            Console.WriteLine("Which part would you like to create?");
            Console.WriteLine();

            var partType = Console.ReadLine();
            IParts part = partType switch
            {
                "bike" => new BikePart(),
                "car" => new CarPart(),
                "truck" => new TruckPart(),
                "plane" => new PlanePart(),
                _ => new MiscPart(),
            };
            return part;

        }
        public static string Continue()
        {
            AddSpace();
            Console.WriteLine("Would you like to continue?");
            Console.WriteLine("Type y for yes and n for no.");
            AddSpace();
            var continuing = Console.ReadLine();
            AddSpace();
            return continuing.ToLower();
        }
    }
}
