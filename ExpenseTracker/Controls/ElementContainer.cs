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

    public enum ElementContainerLayout {
        Grid,
        Absolute
    }
    public partial class ElementContainer : UserControl {

        public List<Element> Elements = new List<Element>();


        int rows = 1, cols = 1;
        public int Rows { get { return rows; } set { rows = (value > 0) ? value : 1; } }
        public int Cols { get { return cols; } set { cols = (value > 0) ? value : 1; } }

        public ElementContainer() {
            InitializeComponent();
            this.AutoScroll = true;
            this.ParentChanged += ElementContainer_ParentChanged;

        }

        private void ElementContainer_ParentChanged(object? sender, EventArgs e) {
            this.Parent.SizeChanged += (s, e) => {
                foreach (Element elem in Elements) {
                    elem.Width = (this.ClientSize.Width / cols)* elem.Cols;
                }
            };
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

        public void ShowElements(List<Element> elements) {

            for (int i = 0; i < elements.Count; i++) {
                AddElement(elements[i]);
            }
        }


       private void AddElement(Element element) {

            int colLeft = this.Cols;

            int count = Elements.Count;
            int colWidth = (this.ClientSize.Width / cols);

            int xOffset = 0, yOffset = 0;
            foreach (Element e in Elements) {
                xOffset += e.Location.X + e.Width;
                colLeft -= e.Cols;
            }

            element.Location = new Point(xOffset, yOffset);
            element.Width = element.Cols * colWidth;    

            this.Controls.Add(element);
            Elements.Add(element);
        } 
    }
}
