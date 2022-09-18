using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FibonacciWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CPUSimulateController : ControllerBase
    {
        private readonly ILogger<CPUSimulateController> _logger;

        public CPUSimulateController(ILogger<CPUSimulateController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetFibonacci/{target}")]
        //public List<int> Get(int target)
        //{
        //    List<int> sequence = new List<int> { };
        //    Fib(target, sequence);

        //    int percentage = 60;

        //    if (percentage < 0 || percentage > 100)
        //    {
        //        throw new ArgumentException("percentage");
        //    }
        //    Stopwatch watch = new Stopwatch();
        //    watch.Start();

        //    while (true)
        //    {
        //        // Make the loop go on for "percentage" milliseconds then sleep the 
        //        // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
        //        if (watch.ElapsedMilliseconds > percentage)
        //        {
        //            Thread.Sleep(100 - percentage);
        //            watch.Reset();
        //            watch.Start();
        //            break;
        //        }
        //    }

        //    return sequence;
        //}

        [HttpGet(Name = "Simulate/{percentage}")]
        public void Simulate(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentException("percentage");
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the 
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - percentage);
                    watch.Reset();
                    watch.Start();
                }
            }
        }

        //private static void Fib(int n, List<int> sequence)
        //{
        //    sequence.Add(0);
        //    sequence.Add(1);

        //    for (int i = 2; i < n; ++i) 
        //    {
        //        sequence.Add(
        //            sequence[sequence.Count - 1] +
        //            sequence[sequence.Count - 2]);
        //    }
        //}
    }
}
