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
    public partial class TotalBalanceElement : Element {
        public TotalBalanceElement() {

            InitializeComponent();

            GroupBox.Text = "BALANCE";
            this.Cols = 3;



        }



        public int Balance { get; set; } = 1000;



        private void OKButton_Click_1(object sender, EventArgs e) {
            Submit?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Submit;

        private void label7_Click(object sender, EventArgs e) {

        }
    }
}
