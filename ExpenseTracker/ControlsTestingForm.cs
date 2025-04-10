using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker {
    public partial class ControlsTestingForm : Form {
        public ControlsTestingForm() {
            InitializeComponent();
            themedListViewControl1.SetItems(new List<ListViewRow> {
    new ListViewRow { AccountName = "Bank", Balance = 1200.50m },
    new ListViewRow { AccountName = "Wallet", Balance = 43.75m },
});


            //themedListViewControl1.View = View.Details;
            //themedListViewControl1.FullRowSelect = true;
            //themedListViewControl1.MultiSelect = false;
            //themedListViewControl1.Columns.Clear();
            //themedListViewControl1.Columns.Add("Account Name", 250);
            //themedListViewControl1.Columns.Add("Balance", 300);

            //themedListViewControl1.Items.Clear();

            //var accounts = Session.CurrentUser?.Accounts;
            //if (accounts != null) {
            //    foreach (var acc in accounts) {
            //        var item = new ListViewItem(acc.Name);
            //        item.SubItems.Add(acc.Balance.ToString("F2"));
            //        item.Tag = acc; // keep original Account obj for later use
            //        themedListViewControl1.Items.Add(item);
            //    }
            //}

        }
    }
}
