using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IBatchService
    {
        public void AddTask();
        public void SetTimeout();
        public void StartJob();
        public void CreatePool();
    }
}
