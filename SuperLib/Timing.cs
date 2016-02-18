using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SuperLib
{
    public static class Timing
    {
        [DllImport("kernel32.dll")]
        private static extern bool QueryPerformanceCounter(ref long x);

        [DllImport("kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(ref long x);

        public static Result<T> Time<T>(Func<T> action)
        {
            long startingTime = 0;
            long endingTime = 0;
            long frequency = 0;

            if (QueryPerformanceFrequency(ref frequency) == false) // Throw exception if the computer does not understand the query performence counter
            {
                throw new Win32Exception();
            }

            Process proc = Process.GetCurrentProcess(); // Get current proces
            proc.ProcessorAffinity = (IntPtr) 1;        // Disable switching between processors
            proc.PriorityClass = ProcessPriorityClass.High;

            foreach (ProcessThread pt in proc.Threads) // For each thread under the current process
            {
                pt.IdealProcessor = 0;              // Set the ideal processor to the 1st one
            }

            lock (action)
            {
                QueryPerformanceCounter(ref startingTime);
                var result = action.Invoke();
                QueryPerformanceCounter(ref endingTime);

                return new Result<T>
                {
                    Time = (endingTime - startingTime) / (double)frequency,
                    ReturnValue = result
                };
            }
        }
    }

    public class Result<T>
    {
        public T ReturnValue { get; set; }
        public double Time { get; set; }
    }

    public class NoResult
    {
    }
}