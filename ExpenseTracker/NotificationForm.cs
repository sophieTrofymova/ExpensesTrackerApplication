using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF = System.Windows.Forms;

namespace ExpenseTracker
{

    public partial class NotificationForm : Form
    {
        WF.Timer closeCountdown;
        WF.Timer opacityCountdown;

        public int SecondsFormVisible = 10;
        private int opacityFactor = 32;
        public NotificationForm()
        {
            InitializeComponent();


            this.Shown += NotificationForm_Shown;
            this.MouseHover += NotificationForm_MouseHover;
        }

        private void NotificationForm_MouseHover(object? sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void NotificationForm_Shown(object? sender, EventArgs e)
        {
            if (SecondsFormVisible < 2) SecondsFormVisible = 2;
            opacityFactor = (int)(6.4 * SecondsFormVisible);


            closeCountdown = new WF.Timer();
            opacityCountdown = new WF.Timer();

            closeCountdown.Interval = SecondsFormVisible * 1000;
            opacityCountdown.Interval = closeCountdown.Interval / opacityFactor;

            closeCountdown.Tick += CloseCountdown_Tick;
            opacityCountdown.Tick += OpacityCountdown_Tick;

            closeCountdown.Start();
            opacityCountdown.Start();
        }

        private void OpacityCountdown_Tick(object? sender, EventArgs e)
        {
            this.Opacity -= (100 / opacityFactor) /100.0;
        }

        private void Finish()
        {
            closeCountdown.Stop();
            opacityCountdown.Stop();
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CloseCountdown_Tick(object? sender, EventArgs e)
        {
            Finish();
        }
        private void bCloseImmidiatelly_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}
