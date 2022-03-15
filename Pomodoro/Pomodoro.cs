using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Pomodoro : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        
        public Pomodoro()
        {
            InitializeComponent();
        }

        private void txtResult_MouseMove(object sender, MouseEventArgs e)
        {
            txtResult.SelectionLength = 0;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            txtResult.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //s
            t.Elapsed += OnTimeEvent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0;
            m = 0;
            h = 0;
            txtResult.Text = "00:00:00";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

    }
}
