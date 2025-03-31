using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpenseTracker {



    public partial class Element : UserControl {

        // some fields for tracking drag state
        private bool isDragging = false;
        private Point startOffset;
        public Element() {
            InitializeComponent();

            this.Location = new Point(10, 10);
            this.Size = new Size(100, 100);
            this.Margin = new Padding(10);
            this.MinimumSize = new Size(100, 100);
            this.MouseDown += draggablePanel_MouseDown;
            this.MouseMove += draggablePanel_MouseMove;
            this.MouseUp += draggablePanel_MouseUp;
        }


        private void draggablePanel_MouseDown(object sender, MouseEventArgs e) {
            // we do drag now
            isDragging = true;
            // store start pos of mouse relative to panel
            startOffset = e.Location;
        }

        private void draggablePanel_MouseMove(object sender, MouseEventArgs e) {
            if (isDragging) {
                // get the new location based on the offset
                var newLoc = this.Location;
                newLoc.X += e.X - startOffset.X;
                newLoc.Y += e.Y - startOffset.Y;

                // if you want to ensure it stays inside the parent panel, do boundary checks
                // e.g.:
                // newLoc.X = Math.Max(0, newLoc.X);
                // newLoc.X = Math.Min(parentPanel.Width - draggablePanel.Width, newLoc.X);
                // similarly for Y

                this.Location = newLoc;
            }
        }

        private void draggablePanel_MouseUp(object sender, MouseEventArgs e) {
            // stop dragging
            isDragging = false;
        }
    }
}
