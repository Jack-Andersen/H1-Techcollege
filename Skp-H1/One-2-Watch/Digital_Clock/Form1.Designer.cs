namespace Digital_Clock
{
    partial class Digital_Clock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Current_Time = new System.Windows.Forms.Label();
            this.CurrentTimer = new System.Windows.Forms.Timer(this.components);
            this.Current_Date = new System.Windows.Forms.Label();
            this.ResetBut = new System.Windows.Forms.Button();
            this.Start_StopBut = new System.Windows.Forms.Button();
            this.Stopur = new System.Windows.Forms.Label();
            this.StopurTimer = new System.Windows.Forms.Timer(this.components);
            this.StopurTime = new System.Windows.Forms.Label();
            this.SecondsBox = new System.Windows.Forms.ComboBox();
            this.MinutesBox = new System.Windows.Forms.ComboBox();
            this.Seconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.HoursBox = new System.Windows.Forms.ComboBox();
            this.Minutes = new System.Windows.Forms.Label();
            this.Start_Stop_Countdown = new System.Windows.Forms.Button();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.Start_Countdown = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Label();
            this.Lab_Time = new System.Windows.Forms.Button();
            this.OmGangBox = new System.Windows.Forms.ListBox();
            this.Countdown_Time = new System.Windows.Forms.Label();
            this.AlarmBox = new System.Windows.Forms.ListBox();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Current_Time
            // 
            this.Current_Time.AutoSize = true;
            this.Current_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Time.Location = new System.Drawing.Point(75, 60);
            this.Current_Time.Name = "Current_Time";
            this.Current_Time.Size = new System.Drawing.Size(262, 69);
            this.Current_Time.TabIndex = 0;
            this.Current_Time.Text = "00:00:00";
            // 
            // CurrentTimer
            // 
            this.CurrentTimer.Enabled = true;
            this.CurrentTimer.Interval = 1000;
            this.CurrentTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Current_Date
            // 
            this.Current_Date.AutoSize = true;
            this.Current_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Date.Location = new System.Drawing.Point(34, 129);
            this.Current_Date.Name = "Current_Date";
            this.Current_Date.Size = new System.Drawing.Size(348, 69);
            this.Current_Date.TabIndex = 1;
            this.Current_Date.Text = "MM dd yyyy";
            // 
            // ResetBut
            // 
            this.ResetBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBut.Location = new System.Drawing.Point(111, 550);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(174, 47);
            this.ResetBut.TabIndex = 2;
            this.ResetBut.Text = "Reset";
            this.ResetBut.UseVisualStyleBackColor = true;
            this.ResetBut.Click += new System.EventHandler(this.ResetBut_Click);
            // 
            // Start_StopBut
            // 
            this.Start_StopBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_StopBut.Location = new System.Drawing.Point(111, 329);
            this.Start_StopBut.Name = "Start_StopBut";
            this.Start_StopBut.Size = new System.Drawing.Size(174, 47);
            this.Start_StopBut.TabIndex = 3;
            this.Start_StopBut.Text = "Start/Stop";
            this.Start_StopBut.UseVisualStyleBackColor = true;
            this.Start_StopBut.Click += new System.EventHandler(this.Start_StopBut_Click);
            // 
            // Stopur
            // 
            this.Stopur.AutoSize = true;
            this.Stopur.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopur.Location = new System.Drawing.Point(131, 263);
            this.Stopur.Name = "Stopur";
            this.Stopur.Size = new System.Drawing.Size(138, 46);
            this.Stopur.TabIndex = 5;
            this.Stopur.Text = "Stopur";
            // 
            // StopurTimer
            // 
            this.StopurTimer.Enabled = true;
            this.StopurTimer.Tick += new System.EventHandler(this.StopurTimer_Tick);
            // 
            // StopurTime
            // 
            this.StopurTime.AutoSize = true;
            this.StopurTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopurTime.Location = new System.Drawing.Point(75, 60);
            this.StopurTime.Name = "StopurTime";
            this.StopurTime.Size = new System.Drawing.Size(262, 69);
            this.StopurTime.TabIndex = 6;
            this.StopurTime.Text = "00:00:00";
            // 
            // SecondsBox
            // 
            this.SecondsBox.FormattingEnabled = true;
            this.SecondsBox.Location = new System.Drawing.Point(448, 285);
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(174, 24);
            this.SecondsBox.TabIndex = 7;
            // 
            // MinutesBox
            // 
            this.MinutesBox.FormattingEnabled = true;
            this.MinutesBox.Location = new System.Drawing.Point(452, 426);
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(174, 24);
            this.MinutesBox.TabIndex = 8;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.Location = new System.Drawing.Point(444, 208);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(188, 46);
            this.Seconds.TabIndex = 9;
            this.Seconds.Text = "Seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 10;
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(444, 477);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(138, 46);
            this.Hours.TabIndex = 11;
            this.Hours.Text = "Hours:";
            // 
            // HoursBox
            // 
            this.HoursBox.FormattingEnabled = true;
            this.HoursBox.Location = new System.Drawing.Point(452, 565);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(174, 24);
            this.HoursBox.TabIndex = 12;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.Location = new System.Drawing.Point(444, 341);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(170, 46);
            this.Minutes.TabIndex = 13;
            this.Minutes.Text = "Minutes:";
            // 
            // Start_Stop_Countdown
            // 
            this.Start_Stop_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Stop_Countdown.Location = new System.Drawing.Point(452, 137);
            this.Start_Stop_Countdown.Name = "Start_Stop_Countdown";
            this.Start_Stop_Countdown.Size = new System.Drawing.Size(174, 47);
            this.Start_Stop_Countdown.TabIndex = 15;
            this.Start_Stop_Countdown.Text = "ON";
            this.Start_Stop_Countdown.UseVisualStyleBackColor = true;
            this.Start_Stop_Countdown.Click += new System.EventHandler(this.Start_Stop_Countdown_Click);
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // Start_Countdown
            // 
            this.Start_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Countdown.Location = new System.Drawing.Point(452, 85);
            this.Start_Countdown.Name = "Start_Countdown";
            this.Start_Countdown.Size = new System.Drawing.Size(174, 46);
            this.Start_Countdown.TabIndex = 17;
            this.Start_Countdown.Text = "Start";
            this.Start_Countdown.UseVisualStyleBackColor = true;
            this.Start_Countdown.Click += new System.EventHandler(this.Start_Countdown_Click);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.Location = new System.Drawing.Point(429, 24);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(223, 46);
            this.Countdown.TabIndex = 18;
            this.Countdown.Text = "Countdown";
            // 
            // Lab_Time
            // 
            this.Lab_Time.Location = new System.Drawing.Point(14, 414);
            this.Lab_Time.Name = "Lab_Time";
            this.Lab_Time.Size = new System.Drawing.Size(91, 47);
            this.Lab_Time.TabIndex = 20;
            this.Lab_Time.Text = "Lab/Time";
            this.Lab_Time.UseVisualStyleBackColor = true;
            this.Lab_Time.Click += new System.EventHandler(this.Lab_Time_Click);
            // 
            // OmGangBox
            // 
            this.OmGangBox.FormattingEnabled = true;
            this.OmGangBox.ItemHeight = 16;
            this.OmGangBox.Location = new System.Drawing.Point(111, 377);
            this.OmGangBox.Name = "OmGangBox";
            this.OmGangBox.Size = new System.Drawing.Size(174, 164);
            this.OmGangBox.TabIndex = 21;
            // 
            // Countdown_Time
            // 
            this.Countdown_Time.AutoSize = true;
            this.Countdown_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown_Time.Location = new System.Drawing.Point(75, 60);
            this.Countdown_Time.Name = "Countdown_Time";
            this.Countdown_Time.Size = new System.Drawing.Size(262, 69);
            this.Countdown_Time.TabIndex = 22;
            this.Countdown_Time.Text = "00:00:00";
            // 
            // AlarmBox
            // 
            this.AlarmBox.FormattingEnabled = true;
            this.AlarmBox.ItemHeight = 16;
            this.AlarmBox.Location = new System.Drawing.Point(685, 92);
            this.AlarmBox.Name = "AlarmBox";
            this.AlarmBox.Size = new System.Drawing.Size(222, 500);
            this.AlarmBox.TabIndex = 23;
            // 
            // SetAlarm
            // 
            this.SetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarm.Location = new System.Drawing.Point(725, 44);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(143, 42);
            this.SetAlarm.TabIndex = 24;
            this.SetAlarm.Text = "SetAlarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // Digital_Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.AlarmBox);
            this.Controls.Add(this.Countdown_Time);
            this.Controls.Add(this.OmGangBox);
            this.Controls.Add(this.Lab_Time);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.Start_Countdown);
            this.Controls.Add(this.Start_Stop_Countdown);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.HoursBox);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.MinutesBox);
            this.Controls.Add(this.SecondsBox);
            this.Controls.Add(this.StopurTime);
            this.Controls.Add(this.Stopur);
            this.Controls.Add(this.Start_StopBut);
            this.Controls.Add(this.ResetBut);
            this.Controls.Add(this.Current_Date);
            this.Controls.Add(this.Current_Time);
            this.Name = "Digital_Clock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Current_Time;
        private System.Windows.Forms.Timer CurrentTimer;
        private System.Windows.Forms.Label Current_Date;
        private System.Windows.Forms.Button ResetBut;
        private System.Windows.Forms.Button Start_StopBut;
        private System.Windows.Forms.Label Stopur;
        private System.Windows.Forms.Timer StopurTimer;
        private System.Windows.Forms.Label StopurTime;
        private System.Windows.Forms.ComboBox SecondsBox;
        private System.Windows.Forms.ComboBox MinutesBox;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.ComboBox HoursBox;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Button Start_Stop_Countdown;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Button Start_Countdown;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button Lab_Time;
        private System.Windows.Forms.ListBox OmGangBox;
        private System.Windows.Forms.Label Countdown_Time;
        private System.Windows.Forms.ListBox AlarmBox;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.Timer AlarmTimer;
    }
}

