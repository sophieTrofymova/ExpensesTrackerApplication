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

    public partial class BalanceSummaryElement : Element {



        public BalanceSummaryElement() {

            InitializeComponent();

   
        }




        public void DisplayAccounts(List<Account> accounts) {

            this.AccountList.Clear();

            // Set ListView to show columns
            this.AccountList.View = View.Details;
            this.AccountList.FullRowSelect = true;

            // Add columns
            this.AccountList.Columns.Add("Account Name", 250);
            this.AccountList.Columns.Add("Balance", 250);

            this.AccountList.Items.Clear();

            foreach (var acc in accounts) {
                var item = new ListViewItem(acc.Name);
                item.SubItems.Add(acc.Balance.ToCurrencyString(MainForm.AppState.Settings.CurrencyType));
                this.AccountList.Items.Add(item);
            }
        }
    }
}
