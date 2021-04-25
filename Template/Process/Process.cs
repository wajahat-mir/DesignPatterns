using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Process
{
    abstract class Process
    {
        public void CreatePool()
        {
            throw new NotImplementedException();
        }
        public void CreateJob()
        {
            throw new NotImplementedException();
        }
        public void DisposePool()
        {
            throw new NotImplementedException();
        }
        public abstract void AddTasks(); 
    }
}
