using System;

namespace Exercise1
{
    public class Stopwatch
    {
        private DateTime _startDateTime;
        private TimeSpan _timeSpan;
        private bool _startedTime = true;

        public void Start()
        {
            if (_startedTime)
            {
                _startDateTime = DateTime.Now;
                _startedTime = false;
                Console.WriteLine(_startDateTime);
            }
            else
            {
                //throw new System.InvalidOperationException("Stopwatch is already started.");
                Console.WriteLine("Stopwatch is already started.");
            }
        }

        public void Stop()
        {
            if (_startedTime)
            {
                //throw new System.InvalidOperationException("Stopwatch must be started first.");
                Console.WriteLine("Stopwatch must be started first.");
            }
            else
            {
                _timeSpan = DateTime.Now - _startDateTime;
                _startedTime = true;
                Console.WriteLine(_timeSpan);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            while (true)
            {
                Console.Write("Enter start/stop/end: ");
                var val = Console.ReadLine();

                if (val.ToLower() == "start")
                {
                    stopWatch.Start();
                }
                else if (val.ToLower() == "stop")
                {
                    stopWatch.Stop();
                }
                else if (val.ToLower() == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Commad");
                }
            }
        }
    }
}
