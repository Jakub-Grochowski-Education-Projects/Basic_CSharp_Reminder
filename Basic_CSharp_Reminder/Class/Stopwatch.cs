using System;

namespace Basic_CSharp_Reminder.Class
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTIme;
        public Boolean _isStarted { get; set; }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = DateTime.Now; }
        }
    }
}
