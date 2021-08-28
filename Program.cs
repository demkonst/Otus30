using System;
using Otus30.Models;

namespace Otus30
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test1();
            Test2();
        }

        private static void Test1()
        {
            var p1 = new Placement(1.01);
            var p2 = (Placement)p1.Clone();

            Console.WriteLine(p1.Area.Equals(p2.Area)
                ? "Placement ICloneable test passed"
                : "Placement ICloneable test failed");
        }

        private static void Test2()
        {
            var h1 = new House(154.7, 3, 290);
            var h2 = h1.MyClone();

            Console.WriteLine(h1.Area.Equals(h1.Area) &&
                              h1.RoomCount.Equals(h2.RoomCount) &&
                              h1.BackyardArea.Equals(h2.BackyardArea)
                ? "House IMyCloneable test passed"
                : "House IMyCloneable test failed");
        }
    }
}