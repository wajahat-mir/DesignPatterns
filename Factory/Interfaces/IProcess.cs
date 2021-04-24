using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    interface IProcess
    {
        public void Init();
        public void Start();
        public void Shutdown();

    }
}
