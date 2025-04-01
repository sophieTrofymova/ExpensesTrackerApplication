using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public partial class Sanbox : Form
    {

        List<NotificationForm> NotificationsShown = new List<NotificationForm>();

        public void ShowNotification(string header, string message, int seconds = 5)
        {
            NotificationForm notification = new NotificationForm();

            var posx = this.Location.X + this.Size.Width - notification.Width - 50;
            var posy = this.Location.Y + this.Size.Height - notification.Height - 30 - (NotificationsShown.Count * (notification.Height + 10));

            notification.StartPosition = FormStartPosition.Manual;
            notification.Location = new Point(posx, posy);

            notification.NotificationHeader.Text = header;
            notification.NotificaticationContent.Text = message;
            notification.SecondsFormVisible = seconds;

            notification.FormClosed += (sender, e) => { NotificationsShown.Remove(sender as NotificationForm); };
            NotificationsShown.Add(notification);
            notification.Show();
        }
    }
}
