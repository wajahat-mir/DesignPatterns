using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Services
{
    class BatchService
    {
        public void Run(int numOfTasks, int numOfNodes, string jobName)
        {
            var pool = new PoolService();
            pool.Create(numOfNodes);

            var task = new TaskService();
            for (int i = 0; i < numOfTasks; i++)
                task.Add();

            var job = new JobService();
            job.Start(jobName);
        }
    }
}
