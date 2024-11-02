using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealExampleOfParams_In_C_
{
    public class Logger
    {
        /*
          Why params is Useful Here
          In this logging scenario, params makes the code more adaptable:
          You can log any number of details without creating separate overloads or explicitly defining an array.
          The logging method is clean and consistent across different calls.
          If no details are passed, the method still functions correctly, adding flexibility for simple log entries.
          This structure is particularly useful for applications requiring dynamic data logging, like error reporting, 
          transaction processing, or action tracing.
        */
        public void LogAction(string actionType, params string[] details)
        {
            Console.WriteLine($"Action Type:{actionType}");
            if (details.Length > 0){
                Console.WriteLine("Details:");
                foreach (var detail in details)
                {
                    Console.WriteLine($"-{detail}");
                }
            }
        }
    }
}
