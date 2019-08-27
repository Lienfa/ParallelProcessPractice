using System.Collections.Generic;
using System.Linq;
using ParallelProcessPractice.Core;

namespace LienFaDemo
{
    public class LienFaTaskRunner : TaskRunnerBase
    {
        public override void Run(IEnumerable<MyTask> tasks)
        {
            tasks.AsParallel().ForAll(task =>
            {
                task.DoStepN(1);
                task.DoStepN(2);
                task.DoStepN(3);
            });
        }
    }
}
