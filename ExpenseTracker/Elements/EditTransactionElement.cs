using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace ExpenseTracker.Elements {
    public partial class EditTransactionElement : Element {

        public EditTransactionElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }


        Transaction? selTransaction = null;

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

            // Optional: if you want enum names instead of values (same result visually)
            typeDropDown.DisplayMember = "ToString"; // Enum.ToString() will be used

            // Select based on current value
            typeDropDown.SelectedItem = selTransaction.Type;



            //categoryDropDown.Enabled = selTransaction.Type != TransactionType.Transfer;
            //categoryDropDown.Items.Clear();

            //string[]? categories = selTransaction.Type switch {
            //    TransactionType.Expense => CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray(),
            //    TransactionType.Income => CategoryInfo.IncomeCategories.Select(c => c.Description).ToArray(),
            //    _ => null
            //};

            //if (categories != null) {
            //    categoryDropDown.Items.AddRange(categories);
            //}



            // first retrieve required list of categories
            List<CategoryInfo>? categories = selTransaction.Type switch {
                TransactionType.Expense => CategoryInfo.ExpenseCategories,
                TransactionType.Income => CategoryInfo.IncomeCategories,
                _ => null
            };
            // determine if the category drop down should be enabled
            // cause it is not needed for transfer transactions
            categoryDropDown.Enabled = categories != null;

            // clear the drop down list
            categoryDropDown.DataSource = null;
            categoryDropDown.Items.Clear();

            // fill the drop down list with the categories if any
            if (categories != null) {
                categoryDropDown.DataSource = new BindingList<CategoryInfo>(categories);
                categoryDropDown.DisplayMember = nameof(CategoryInfo.Description);
                categoryDropDown.ValueMember = nameof(CategoryInfo.ImageIcon); // optional
            }

            // select from transaction
            if (selTransaction.CategoryInfo != null) {
                categoryDropDown.SelectedItem = categoryDropDown.Items
                    .Cast<CategoryInfo>()
                    .FirstOrDefault(c => c.Description == selTransaction.CategoryInfo.Description);
            }


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
            // first retrieve required list of categories
            List<CategoryInfo>? categories = typeDropDown.SelectedItem switch {
                TransactionType.Expense => CategoryInfo.ExpenseCategories,
                TransactionType.Income => CategoryInfo.IncomeCategories,
                _ => null
            };
            // determine if the category drop down should be enabled
            // cause it is not needed for transfer transactions
            categoryDropDown.Enabled = categories != null;

            // clear the drop down list
            categoryDropDown.DataSource = null;
            categoryDropDown.Items.Clear();

            // fill the drop down list with the categories if any
            if (categories != null) {
                categoryDropDown.DataSource = new BindingList<CategoryInfo>(categories);
                categoryDropDown.DisplayMember = nameof(CategoryInfo.Description);
                categoryDropDown.ValueMember = nameof(CategoryInfo.ImageIcon); // optional
            }



        }

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e) {




        }
    }
}
