//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Threading;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Digital_Clock
{
    public class Timerclasstest : INotifyPropertyChanged
    {
        TimeSpan _time ;
        DispatcherTimer _timer ;
        public void OnPropertyChanged(string name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Timerclasstest(double mincount)
        {
            _time = new TimeSpan();
            _timer = new DispatcherTimer();
            _time = TimeSpan.FromSeconds(mincount);
            _timer = new DispatcherTimer();
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            TimeNow = _time.ToString("c");
            if (_time == TimeSpan.Zero) _timer.Stop();
            _time = _time.Add(TimeSpan.FromSeconds(-1));
        }

        private string _TimeNow;
        public string TimeNow
        {
            get
            {
                return _TimeNow;
            }
            set
            {
                _TimeNow = value;
                OnPropertyChanged("TimeNow");
            }
        }
    }
}
