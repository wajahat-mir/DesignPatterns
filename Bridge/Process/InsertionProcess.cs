using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Process
{
    class InsertionProcess
    {
        private readonly IBatchService _batchService;

        public InsertionProcess(IBatchService batchService)
        {
            _batchService = batchService;
        }

        public void Init()
        {
            _batchService.CreatePool();
            _batchService.SetTimeout();
        }

        public void Build(int numOfTasks)
        {
            for (int i = 0; i < numOfTasks; i++)
                _batchService.AddTask();
        }

        public void Start()
        {
            _batchService.StartJob();
        }
    }
}
