﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Digital_Clock
{
    class ListBoxCountDown
    {

        List<Timerclasstest> list = new List<Timerclasstest>();

        public void ListboxItems()
        {
            InitializeComponent();
            list.Add(new Timerclasstest(0) { TimeNow = "00:00:00" });
            list.Add(new Timerclasstest(1) { TimeNow = "00:00:00" });
            list.Add(new Timerclasstest(2) { TimeNow = "00:00:00" });
            //AlarmBox.DataContext = list;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public class Timerclasstest : INotifyPropertyChanged
        {
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
                DispatcherTimer _timer = new DispatcherTimer();
                TimeSpan _time = new TimeSpan();
                _time = TimeSpan.FromSeconds(mincount);
                _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
                {
                    TimeNow = _time.ToString("c");
                    if (_time == TimeSpan.Zero) _timer.Stop();
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                }, Application.Current.Dispatcher);
                _timer.Start();
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
}
