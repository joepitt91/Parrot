using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Parrot
{
    public partial class frmParrot : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public frmParrot()
        {
            InitializeComponent();
            txtBeat.Text = System.IO.File.ReadAllText("Resources\\Readme.txt");
            Defibrillator.DoWork += new DoWorkEventHandler(Heartbeat);
            Defibrillator.RunWorkerCompleted += new RunWorkerCompletedEventHandler(EOL);
            RegisterHotKey(this.Handle, 0, (int)KeyModifier.Shift, Keys.F2.GetHashCode());
            this.FormClosing += new FormClosingEventHandler(frmParrot_FormClosing);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                if (Defibrillator.IsBusy)
                {
                    btnStop_Click(this, null);
                }
                else
                {
                    btnStart_Click(this, null);
                }
            }
        }

        private void frmParrot_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void Heartbeat(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string beat = txtBeat.Text;
            beat = beat.Replace("{", "{{}");
            beat = beat.Replace("}", "{}}");
            beat = beat.Replace("{{{}}", "{{}");
            beat = beat.Replace("+", "{+}");
            beat = beat.Replace("^", "{^}");
            beat = beat.Replace("%", "{%}");
            beat = beat.Replace("~", "{~}");
            beat = beat.Replace("(", "{(}");
            beat = beat.Replace(")", "{)}");
            beat = beat.Replace("[", "{[}");
            beat = beat.Replace("]", "{]}");
            beat = beat.Replace(Environment.NewLine, "~");
            int rate = (int)numRate.Value * 1000;

            while (true)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    SendKeys.SendWait(beat);
                    Thread.Sleep(rate);
                }
            }
        }

        private void EOL(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            txtBeat.ReadOnly = false;
            numRate.Enabled = true;
            btnStop.Enabled = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Resources\\stop.wav");
            player.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Defibrillator.IsBusy)
            {
                Defibrillator.RunWorkerAsync();
            }
            btnStart.Enabled = false;
            txtBeat.ReadOnly = true;
            numRate.Enabled = false;
            btnStop.Enabled = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Resources\\start.wav");
            player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Defibrillator.CancelAsync();
        }
    }
}
