using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public partial class TransactionDetailsView : ElementView
    {
        public TransactionDetailsView(ElementContainer container) : base( container)
        {
            this.Name = "Transaction Details";
            this.NumRows = 5;
            this.NumCols = 4;

            Padding = new System.Windows.Forms.Padding(25);


            screenBuilders.Add("add", () => new List<Element> {
                new AddTransactionElement {
                    Title = "Add Transaction",
                    Col = 0,
                    Cols = 3,
                    Row = 0,
                    Rows = 3,
                    AllowDrag = false
                }
            });
            DefaultScreenKey = "add";


        }




    }
}
