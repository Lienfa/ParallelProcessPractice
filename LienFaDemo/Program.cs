using System;
using ParallelProcessPractice.Core;

namespace LienFaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskRunnerBase run = new LienFaTaskRunner();
            run.ExecuteTasks(100);
        }
    }
}
