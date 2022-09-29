using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
// TODO: Create a class called BikePart that conforms to IParts
// TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done
namespace Interfaces_Exercise_01
{
    public class BikePart : IParts
    {
        public IParts BuildPart()
        {
            Console.WriteLine();
            Console.WriteLine("Building new bike part");
            Thread.Sleep(1000);
            Console.WriteLine("Ding!Your bike part is done");
            return new BikePart();
        }
    }
}
