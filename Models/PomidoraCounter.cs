using PomidoraWins.Delegates;
using PomidoraWins.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PomidoraWins.Models
{
    public class PomidoraCounter
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private Stopwatch stopWatch = new Stopwatch();
 
        private object startObject = new object();
        private bool started;

        public event TimeSpanChangeHandler TimeChangedEvent;
        public PomidoraCounter()
        {
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += new EventHandler(timer_Tick);
        }

        public void start(PomidoraSettings settings)
        {
            bool started;
            lock (startObject)
            {
                started = this.started;
                if (!started)
                {
                    this.started = true;
                }
            }
            if (!started)
            {
                if (!timer.IsEnabled)
                {
                    timer.Start();
                }

                TimeSpan stopTime = PomidoraSettingsHelper.GetStopTimeFromSettings(settings);
                Task.Factory.StartNew(() => this.StartPomidoraCountDown(this.stopWatch, stopTime))
                .ContinueWith(r =>
                {
                    using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(settings.PomidorkaWAV))
                    {
                        player.Play();
                        lock (startObject)
                        {
                            this.started = false;
                        }
                    }
                    TimeChangedEvent.Invoke(stopTime);
                    timer.Stop();
                });
            }
        }

        public void StartPomidoraCountDown(Stopwatch stopWatch, TimeSpan stopTime)
        {
            stopWatch.Reset();
            stopWatch.Start();
            while (stopTime.TotalMilliseconds > stopWatch.ElapsedMilliseconds)
            {
                Thread.Sleep(100);
            }
            stopWatch.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeChangedEvent.Invoke(stopWatch.Elapsed);
        }
    }
}
