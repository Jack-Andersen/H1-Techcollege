using System;

namespace Digital_Clock
{
    public class TimeAndName
    {
        private string v1 { get; set; }
        public TimeSpan timeSpan { get; set; }
        private string v2 { get; set; }

        public TimeAndName(string v1, TimeSpan timeSpan, string v2)
        {
            this.v1 = v1;
            this.timeSpan = timeSpan;
            this.v2 = v2;
        }

        public string TimeString { get; internal set; }
    }
}