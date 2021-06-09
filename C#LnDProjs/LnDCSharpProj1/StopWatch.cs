using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class StopWatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _stopTime { get; set; }
        private bool _currentlyRunning { get; set; }
        private TimeSpan _duration { get; set; }

        public void Start()
        {
            if (!_currentlyRunning)
            {
                _currentlyRunning = true;
                _startTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch running. Hit stop before hitting start again.");
            }
            
        }

        public void Stop()
        {
            if (_currentlyRunning)
            {
                _currentlyRunning = false;
                _stopTime = DateTime.Now;
            }
            //var interval = Interval();
            //Console.WriteLine("\r\n Duration was: {0}", interval.ToString());
            Console.WriteLine("\r\n Duration was: {0}", Interval());
        }

        public TimeSpan Interval()
        {
            _duration = _stopTime - _startTime;
            return _duration;
        }

        public void Runner(int keyValue)
        {
            switch (keyValue)
            {
                case 1:
                    try
                    {
                        Start();
                        break;
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Stopwatch running. Hit stop before hitting start again.");
                        break;
                    }

                case 2:
                    Stop();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
