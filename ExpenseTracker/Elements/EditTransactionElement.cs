using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace ExpenseTracker.Elements {
    public partial class EditTransactionElement : Element {

        public EditTransactionElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }


        Transaction? selTransaction = null;
        string[]? expenseCategories = null;
        string[]? incomeCategories = null;

        public override void Init() {


            // we need to fill fields with the selected transaction
            // receive the selected transaction from user session
            selTransaction = Session.SelectedTransaction();

            // return to transaction view if no transaction is selected
            if (selTransaction == null) {
                SwitchToLocalScreen("view", false);
            }

            // Bind directly to enum
            typeDropDown.DataSource = Enum.GetValues(typeof(TransactionType));

            // enum names instead of values (same result visually)
            typeDropDown.DisplayMember = "ToString"; 

            // Select based on current value
            typeDropDown.SelectedItem = selTransaction.Type;




            senderAccountDropDown.Items.Clear();
            var accounts = Session.CurrentUser?.Accounts.Select(a => a.Name).ToArray();
            senderAccountDropDown.Items.AddRange(accounts);

        }

        private void bEdit_Click(object sender, EventArgs e) {

            var acc = Session.CurrentUser?.Accounts.Select(a => a).Where(a => a.Name == (senderAccountDropDown.SelectedItem as string)).FirstOrDefault() as Account;
            var cat = CategoryInfo.ExpenseCategories.Select(c => c).Where(c => c.Description == (categoryDropDown.SelectedItem as string)).FirstOrDefault() as CategoryInfo;

            var transaction = new Transaction(acc.ID) {
                Amount = decimal.Parse(expenseAmount.Text),
                EffectDate = dtpAffectDate.Value,
                CategoryInfo = cat,
                Type = TransactionType.Expense
            };

            Session.CurrentUser?.Transactions.Add(transaction);

            SwitchToLocalScreen("view", false);
        }

        private void bCancel_Click(object sender, EventArgs e) {
            SwitchToLocalScreen("view", false);
        }




        private void RefreshCategories(TransactionType type) {

            categoryDropDown.Items.Clear();

            // turn of category selector for transfer transactions
            if (!(categoryDropDown.Enabled = selTransaction.Type != TransactionType.Transfer)) { return; }


            string[]? categories = type switch {
                TransactionType.Expense => CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray(),
                TransactionType.Income => CategoryInfo.IncomeCategories.Select(c => c.Description).ToArray(),
                _ => null
            };


            if (categories != null) {
                return;
            }

            //selTransaction.CategoryDescription == 

            // sorry its unfinished at 11/10/2023

        }

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e) {




        }
    }
}
