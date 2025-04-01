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
    public partial class NewElement : Element {

        public int MyProperty { get; set; }
        public NewElement() {
            InitializeComponent();
           
            GroupBox.Text = "NewElement";
        }
    }
}
