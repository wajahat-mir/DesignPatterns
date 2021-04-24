using Factory.Factories;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = new ProcessFactory();

            var process = factory.Create("INSERT");
        }
    }
}
