using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using One_2_Watch;
using System.Diagnostics;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Hangfire.Annotations;

namespace Digital_Clock
{
    public partial class Digital_Clock : Form
    {
        int hours;
        int minutes;
        int seconds;

        int hours2;
        int minutes2;
        int seconds2;

        bool bCurrent_Time = true;
        bool on1 = true;
        bool on2 = true;
        bool pressed = true;

        List<TimeSpan> showLap = new List<TimeSpan>();

        private int totalSeconds;
        private int totalSeconds2;
        private Stopwatch stopWatch;

        public Digital_Clock()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            StopurTime.Visible = false;
            Start_Stop_Countdown.Enabled = false;
            Countdown_Time.Visible = false;

            for (int i = 0; i < 60; i++)
            {

                this.SecondsBox.Items.Add(i.ToString());
                this.MinutesBox.Items.Add(i.ToString());
                this.HoursBox.Items.Add(i.ToString());

                this.SecondsBox.SelectedIndex = 0;
                this.MinutesBox.SelectedIndex = 0;
                this.HoursBox.SelectedIndex = 0;

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (items.Any(x => x.timeSpan == DateTime.Now.TimeOfDay))
                MessageBox.Show("Alarm Time");
            if (bCurrent_Time)
                Current_Time.Text = DateTime.Now.TimeOfDay.ToString("hh':'mm':'ss");

            Current_Date.Text = DateTime.Now.ToString("MM dd yyyy");
        }

        private void Start_StopBut_Click(object sender, EventArgs e)
        {

            stopWatch.Start();
            StopurTime.Visible = true;
            Current_Time.Visible = false;
            bCurrent_Time = false;


            if (on1)
            {

                stopWatch.Start();
                Start_StopBut.Text = "ON";
                on1 = false;
                Start_StopBut.BackColor = Color.LimeGreen;

            }
            else
            {

                stopWatch.Stop();
                Start_StopBut.Text = "OFF";
                on1 = true;
                Start_StopBut.BackColor = Color.Red;

            }

        }

        public void Start_Countdown_Click(object sender, EventArgs e)
        {

            Countdown_Time.Visible = true;
            CountdownTimer.Enabled = true;
            Start_Stop_Countdown.Enabled = true;

            minutes = int.Parse(this.MinutesBox.SelectedItem.ToString());
            seconds = int.Parse(this.SecondsBox.SelectedItem.ToString());
            hours = int.Parse(this.HoursBox.SelectedItem.ToString());

            totalSeconds = (hours * 3600) + minutes * 60 + seconds;

            Start_Stop_Countdown.Text = "ON";
            on2 = false;
            Start_Stop_Countdown.BackColor = Color.LimeGreen;

        }

        private void Start_Stop_Countdown_Click(object sender, EventArgs e)
        {

            if (on2)
            {

                Start_Stop_Countdown.Text = "ON";
                on2 = false;
                Start_Stop_Countdown.BackColor = Color.LimeGreen;
                CountdownTimer.Enabled = true;

            }
            else
            {

                Start_Stop_Countdown.Text = "OFF";
                on2 = true;
                Start_Stop_Countdown.BackColor = Color.Red;
                CountdownTimer.Enabled = false;

            }

        }

        private void StopurTimer_Tick(object sender, EventArgs e)
        {

            this.StopurTime.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);

        }

        public void Lab_Time_Click(object sender, EventArgs e)
        {

            if (pressed)
            {
                showLap.Add(TimeSpan.Parse(StopurTime.Text));
                OmGangBox.Items.Add(string.Format("{0} | {1} | {2}", showLap.Count, showLap.LastOrDefault().ToString("hh':'mm':'ss"), showLap.Count == 1 ? showLap.LastOrDefault().ToString("hh':'mm':'ss") : showLap.LastOrDefault().Subtract(showLap.ElementAt(showLap.Count - 2)).ToString("hh':'mm':'ss")));
            }

        }

        public void CountdownTimer_Tick(object sender, EventArgs e)
        {

            if (totalSeconds > 0)
            {
                totalSeconds--;
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds / 60) % 60;
                int seconds = (totalSeconds % 60);
                TimeSpan T = new TimeSpan(hours, minutes, seconds);
                Countdown_Time.Text = T.ToString();

            }
            else
            {

                for (int i = 1; i < 2; i++)
                {
                    Console.Beep();
                }

                CountdownTimer.Stop();
                DialogResult result = (MessageBox.Show(" Put on snooze + 5 min ", " Time * up ", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                switch (result)
                {
                    case DialogResult.Yes:

                        totalSeconds = 5 * 60;
                        CountdownTimer.Start();
                        MessageBox.Show(" Added 5 mins ");
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            //ny kode
            TimeSpan t = new TimeSpan(Convert.ToInt32(HoursBox.SelectedItem), Convert.ToInt32(MinutesBox.SelectedItem), 0);
            items.Add(new TimeAndName("", t, ""));

            AlarmBox.Items.Add(items.LastOrDefault().timeSpan.ToString("hh':'mm"));
            //AlarmBox.Items.Add(new Timerclasstest(0) { TimeNow = string.Format("{0:00}:{1:00}:{2:00}", HoursBox.SelectedItem.ToString(), MinutesBox.SelectedItem.ToString(), SecondsBox.SelectedItem.ToString() ) }.TimeNow);

            AlarmTimer.Enabled = true;

            minutes2 = int.Parse(this.MinutesBox.SelectedItem.ToString());
            seconds2 = int.Parse(this.SecondsBox.SelectedItem.ToString());
            hours2 = int.Parse(this.HoursBox.SelectedItem.ToString());

            totalSeconds2 = (hours2 * 3600) + minutes2 * 60 + seconds2;

        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {

            if (totalSeconds2 > 0)
            {
                TimeMethod();
                //LoadItems();
                totalSeconds2--;
                int hours2 = totalSeconds2 / 3600;
                int minutes2 = (totalSeconds2 / 60) % 60;
                int seconds2 = (totalSeconds2 % 60);
                TimeSpan y = new TimeSpan(hours2, minutes2, seconds2);
                AlarmBox.Text = y.ToString();
                //AlarmBox.BeginUpdate();
                //AlarmBox.Items.Add(" " + y.ToString());
                //AlarmBox.EndUpdate();

            }
            else
            {

                for (int i = 1; i < 2; i++)
                {
                    Console.Beep();
                }

                AlarmTimer.Stop();
                DialogResult result = (MessageBox.Show(" Put on snooze + 5 min ", " Time * up ", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                switch (result)
                {
                    case DialogResult.Yes:

                        totalSeconds2 = 5 * 60;
                        AlarmTimer.Start();
                        MessageBox.Show(" Added 5 mins ");
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        public List<TimeAndName> items = new List<TimeAndName>();


        DispatcherTimer timer = new DispatcherTimer();

        public void TimeMethod()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 0);
            timer.Tick += myTimer_tick;
            timer.Start();
        }
        public void LoadItems()
        {
            items.Add(new TimeAndName("first item", new TimeSpan(0, 0, 1, 0), ""));
        }
        private void myTimer_tick(object sender, object e)
        {
            foreach (var timeAndName in items)
            {
                var now = DateTime.Parse(AlarmBox.Text.ToString());
                //var deadline = DateTime.Parse(timeAndName.timeSpan.ToString());
                //TimeSpan dif = now - deadline;
                //timeAndName.TimeString = dif.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ResetBut_Click(object sender, EventArgs e)
        {

            bCurrent_Time = true;
            Start_StopBut.Text = "Start/Stop";
            Start_StopBut.BackColor = default(Color);
            Start_StopBut.UseVisualStyleBackColor = true;
            Start_Stop_Countdown.Text = "Start/Stop";
            Start_Stop_Countdown.BackColor = default(Color);
            Start_Stop_Countdown.UseVisualStyleBackColor = true;
            Current_Time.Visible = true;
            StopurTime.Visible = false;
            on1 = true;
            on2 = true;
            stopWatch.Reset();
            Start_Stop_Countdown.Enabled = false;
            CountdownTimer.Stop();
            Countdown_Time.ResetText();
            Countdown_Time.Visible = false;
            OmGangBox.Items.Clear();
            AlarmTimer.Stop();
            AlarmBox.Items.Clear();

        }
    }
}
