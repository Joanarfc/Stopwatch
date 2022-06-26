using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _startTime;
        private bool _isRunning;


        public TimeSpan Duration
        {
            get
            {
                _duration = DateTime.Now - _startTime;
                return _duration;
            }
        }

        public void Start()
        {

            if (_isRunning)
                throw new InvalidOperationException("Cannot start. Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch is running");
        }

        public void Stop()
        {

            if (!_isRunning)
                throw new InvalidOperationException("Cannot start. Stopwatch is already stopped.");


                _isRunning = false;
                Console.WriteLine("Total duration: {0}", Duration);
                Console.WriteLine("Stopwatch is stopped.");
        }

        public void Clear()
        {
            _isRunning = false;
            _duration = new TimeSpan(0, 0, 0, 0);
            Console.WriteLine("Stopwatch is cleared. Press 1 to Start.");
            Console.WriteLine("Total duration: {0}", _duration);
        }
    }
}
