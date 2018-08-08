using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace AwesomeService.Core
{
    public class AppRunner
    {
        private Timer _timer;

        public AppRunner()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => Console.WriteLine("Service running");
        }

        public bool IsRunning => _timer.Enabled;

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
