using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Process
{
    class MergeProcess : IProcess
    {
        public void Init()
        {
            Console.WriteLine("Merge Initialization");
        }
        public void Start()
        {
            Console.WriteLine("Merge has begun");
        }
        public void Shutdown()
        {
            Console.WriteLine("Merge Shutdown");
        }
    }
}
