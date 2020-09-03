using System;

namespace ConsoleApp1
{
    class Stopwatch
    {
        DateTime? _startedAt;
        DateTime? _stoppedAt;

        public double Elapsed => (_stoppedAt - _startedAt).Value.TotalMilliseconds;

        internal void Start()
        {
            _startedAt = _stoppedAt = DateTime.Now;
        }

        internal void Stop()
        {
            _stoppedAt = DateTime.Now;
        }
    }
}
