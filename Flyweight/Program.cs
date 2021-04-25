using Flyweight.Factories;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var LocationId = 1;
            LocationFactory locationFactory = new LocationFactory();
            var location = locationFactory.getLocation(LocationId);
            ReviewModel review = new ReviewModel(location);
        }
    }
}
