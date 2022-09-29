using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
// TODO: Create a class called MiscPart that conforms to IParts
// TODO: Implement the interface and creatively let the user know when a part is being built and when that part is done
namespace Interfaces_Exercise_01
{
    public class MiscPart : IParts
    {
        public IParts BuildPart()
        {
            Console.WriteLine();
            Console.WriteLine("Time to build a misc part.");
            Thread.Sleep(1000);
            Console.WriteLine("Ding! Part complete.");
            return new MiscPart();  
        }
    }
}
