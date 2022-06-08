using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime StartTime { get; set; }

        public TimeSpan Duration
        {
            get
            {
                _duration = DateTime.Now - StartTime;
                return _duration;
            }
        }
        private bool isRunning = false;

        public void Start()
        {

            if (!isRunning)
            {
                StartTime = DateTime.Now;
                isRunning = true;
                Console.WriteLine("Stopwatch is running");

            }
            else
            {
                throw new InvalidOperationException("Cannot start. Stopwatch is already running.");
            }
        }

        public void Stop()
        {

            if (isRunning == true)
            {
                isRunning = false;
                Console.WriteLine("Total duration: {0}", Duration);
                Console.WriteLine("Stopwatch is stopped.");
            }
            else
            {
                throw new InvalidOperationException("Cannot start. Stopwatch is already stopped.");
            }
        }

        public void Clear()
        {
            isRunning = false;
            _duration = new TimeSpan(0, 0, 0, 0);
            Console.WriteLine("Stopwatch is cleared. Press 1 to Start.");
            Console.WriteLine("Total duration: {0}", _duration);
        }
    }
}
