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
            int count = elements.Count;

            while (count != 0) {
                if (elements[count-1].Parent != null) {
                    elements[count-1].Parent.Controls.Remove(elements[count-1]);
                }
                Elements.Remove(elements[count-1]);
                count--;
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
