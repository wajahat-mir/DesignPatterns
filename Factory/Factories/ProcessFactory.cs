using Factory.Interfaces;
using Factory.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    class ProcessFactory
    {
        public IProcess Create(string process)
        {
            IProcess currentProcess;

            switch (process.ToUpper())
            {
                case "INSERT":
                    currentProcess = new InsertionProcess();
                    break;
                case "MERGE":
                    currentProcess = new MergeProcess();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return currentProcess;
        }
    }
}
