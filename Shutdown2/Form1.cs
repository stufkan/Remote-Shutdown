﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Shutdown
{

    public partial class MainForm : Form
    {
        Thread server;
        Server worker = new Server();
        ShutdownAction shutdown = new ShutdownAction();
        delegate void formCallback(string text);

        int milliseconds = -1;

        Minimize Mini = new Minimize();
        System.Windows.Forms.Timer visualTimer = new System.Windows.Forms.Timer();
        int tick = 1;




        //http://csharp.net-informations.com/communications/csharp-chat-server-programming.htm
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            visualTimer.Tick += new System.EventHandler(visual_Tick);

            notifyIcon1.Click += notifyIcon1_Click;



            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(mainInterface1.AddTen, "Right click to toggle between 1 and 10 minutes. Hold ctrl to subtract");
            shutdown.Timer_Elapsed += new EventHandler(Timer_Elapsed);
            server = new Thread(worker.ServerLoop);
            server.Start();

            Task consumer = Task.Factory.StartNew(Consumer);

            mainInterface1.Execute.Click += Execute_Click;


        }



        void Timer_Elapsed(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            milliseconds = mainInterface1.CalculateTime();

            ExecuteShutdown(milliseconds, mainInterface1.ShutdownType);

        }

        private void ExecuteShutdown(int milliseconds, ShutdownType st)
        {
            if (milliseconds >= 0)
            {
                shutdown.ShutdownActionExe(milliseconds, st);
                Mini.ToTray(notifyIcon1, this, shutdown.MyTimer, st);
                tick = 1;
                visualTimer.Interval = 1000;
                visualTimer.Enabled = true;
            }
            else MessageBox.Show("Time must be positive");
        }

        public void ExecuteShutdown(ShutdownMessage s)
        {

            ExecuteShutdown(s.Interval, s.Type);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }
        private void visual_Tick(object sender, EventArgs e)
        {

            mainInterface1.statusLabel.Text = TimeInterpreter.TimeRemaining(shutdown.MyTimer.Interval, tick);
            tick++;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            ShutdownType s = mainInterface1.ShutdownType;
            notifyIcon1.BalloonTipText = "Time remaining to " + s.ToString() + ": " + TimeInterpreter.TimeRemaining(shutdown.MyTimer.Interval, tick);
            notifyIcon1.ShowBalloonTip(500);
        }

        public void Consumer()
        {
            while (true)
            {
                ShutdownMessage s;
                if (worker.shutdownCollection.TryTake(out s))
                    ExecuteShutdown(s);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that contains the event data.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (shutdown.MyTimer.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show(this, "This will cancel the shutdown. Do you want to continue?", "Cancel shutdown?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
                base.OnFormClosing(e);
            }

            worker.RequestStop();

        }
    }
}

