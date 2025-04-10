using ExpenseTracker.Controls;
using ExpenseTracker.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Elements {
    public partial class AddTransactionElement : Element {

        public TransactionType TransactionType { get; set; } = TransactionType.Expense;

        public AddTransactionElement() {
            InitializeComponent();
        }

        public override void Init() {

        }

        private void bAdd_Click(object sender, EventArgs e) {
            var container = (this.Parent as ElementContainer);
            container.UnlockView();
            container.SetView(new TransactionsView(
                container
            ));

        }

        private void bCancel_Click(object sender, EventArgs e) {
            var container = (this.Parent as ElementContainer);
            container.UnlockView();
            container.SetView(new TransactionsView(
                container
            ));
        }
    }
}
