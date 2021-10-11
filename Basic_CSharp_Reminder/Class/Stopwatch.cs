using System;

namespace Basic_CSharp_Reminder.Class
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        public Boolean IsStarted { get; set; }

        //public DateTime StartTime
        //{
        //    get { return _startTime; }
        //    set { _startTime = DateTime.Now; }
        //}

        //public DateTime EndTime
        //{
        //    get { return _endTime; }
        //    set { _endTime = DateTime.Now; }
        //}
        
        public void Start()
        {
            if (IsStarted)
            {
                Console.WriteLine("At first stop current session!!");
                throw new InvalidOperationException();
            }
            else
            {
                _startTime = DateTime.Now;
                IsStarted = true;
            }
        }
        public void Stop()
        {
            _endTime = DateTime.Now;
            TimeSpan timeSpan = _endTime - _startTime;
            Console.WriteLine("Result time: "+timeSpan);
            IsStarted = false;
        }

    }
}
