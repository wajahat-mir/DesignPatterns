using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Process
{
    class InsertionProcess: IProcess
    {
        public void Init()
        {
            Console.WriteLine("Insert Initialization");
        }
        public void Start()
        {
            Console.WriteLine("Insertion has begun");
        }
        public void Shutdown()
        {
            Console.WriteLine("Insert Shutdown");
        }
    }
}
