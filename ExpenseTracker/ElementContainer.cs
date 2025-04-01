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
    public partial class ElementContainer : UserControl {

        public List<Element> Elements = new List<Element>();
        public ElementContainer() {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void ElementContainer_Load(object? sender, EventArgs e) {
            
        }


        public void HideElements(List<Element> elements) {
            for (int i = 0; i < elements.Count; i++) {
                if (elements[i].Parent != null) {
                    elements[i].Parent.Controls.Remove(elements[i]);
                }
                Elements.Remove(elements[i]);
            }
        }

        public void ShowElements(List<Element> elements, Control parent) {
            if (parent == null)
                return;
            for (int i = 0; i < elements.Count; i++) {
                parent.Controls.Add(elements[i]);
                Elements.Add(elements[i]);
            }
        }
    }
}
