using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Elements;

namespace ExpenseTracker
{

    public partial class BalanceSummaryElement : Element {



        public BalanceSummaryElement(ElementView parentView) : base(parentView) {

            InitializeComponent();

   
        }


        public override void Init() {
            DisplayAccounts(App.State.UserManager.LoggedUser.Accounts);
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

            decimal total = 0; // trackin total

            foreach (var acc in accounts) {
                var item = new ListViewItem(acc.Name);
                item.SubItems.Add(acc.Balance.ToCurrencyString(App.State.Settings.CurrencyType));
                this.AccountList.Items.Add(item);

                total += acc.Balance; // addin up
            }

            // separator row - fake it til u make it
            var separatorItem = new ListViewItem(new string('-', 40)); // 40 dashs, tweak if u want
            separatorItem.SubItems.Add(""); // empty subitem for bal col
            this.AccountList.Items.Add(separatorItem);

            // total row
            var totalItem = new ListViewItem("Total");
            totalItem.SubItems.Add(total.ToCurrencyString(App.State.Settings.CurrencyType));
            this.AccountList.Items.Add(totalItem);
        }


    }
}
