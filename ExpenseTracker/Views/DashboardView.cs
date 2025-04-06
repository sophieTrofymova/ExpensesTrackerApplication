using global::ExpenseTracker.Controls;
using System.Globalization;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {

        public class DashboardView : ElementView {

            

            public TotalBalanceElement BalanceSummary;

            public DashboardView(ElementContainer container, string name = "Dashboard") : base(name, container) { }

            public override void Build() {
                ClearElements();

                // view layout
                this.NumCols = 24;
                this.NumRows = 24;


                // create element
                BalanceSummary = new TotalBalanceElement();

                BalanceSummary.Collumn = 1;
                BalanceSummary.Row = 1;

                BalanceSummary.Cols = 22;
                BalanceSummary.Rows = 22;
                BalanceSummary.AllowDrag = false;



                LoadAccountsToListView(MainForm.AppState.currentUser.Accounts, CurrencyType.EUR);




                this.AddElements(new List<Element> { BalanceSummary });
                
            }

            private string FormatBalance(decimal balance, CurrencyType currency) {
                var culture = CultureInfo.InvariantCulture;

                switch (currency) {
                    case CurrencyType.EUR:
                        culture = new CultureInfo("fr-FR");
                        break;
                    case CurrencyType.GBP:
                        culture = new CultureInfo("en-GB");
                        break;
                    case CurrencyType.USD:
                    default:
                        culture = new CultureInfo("en-US");
                        break;
                }

                return string.Format(culture, "{0:C}", balance);
            }


            private void LoadAccountsToListView(List<Account> accounts, CurrencyType currency) {

                BalanceSummary.AccountList.Clear();

                // Set ListView to show columns
                BalanceSummary.AccountList.View = View.Details;
                BalanceSummary.AccountList.FullRowSelect = true;

                // Add columns
                BalanceSummary.AccountList.Columns.Add("Account Name", 250);
                BalanceSummary.AccountList.Columns.Add("Balance", 250);

                BalanceSummary.AccountList.Items.Clear();

                foreach (var acc in accounts) {
                    var item = new ListViewItem(acc.Name);
                    item.SubItems.Add(FormatBalance(acc.Balance, currency));
                    BalanceSummary.AccountList.Items.Add(item);
                }
            }

        }


    }

}
