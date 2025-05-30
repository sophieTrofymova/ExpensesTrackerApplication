﻿using ExpenseTracker.Storage;
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

namespace ExpenseTracker.Elements {



    public partial class Element : UserControl {

        // some fields for tracking drag state
        private bool isDragging = false;
        private Point startOffset;

        int rows = 1, cols = 1;
        int row = 0, col = 0;
        public int Rows { get { return rows; } set { rows = value > 0 ? value : 1; } }
        public int Cols { get { return cols; } set { cols = value > 0 ? value : 1; } }

        public int Row { get { return row; } set { row = value >= 0 ? value : 0; } }
        public int Col { get { return col; } set { col = value >= 0 ? value : 0; } }


        bool isDragAllowed = false;
        public bool AllowDrag { get { return isDragAllowed; } set { isDragAllowed = value; DragAdjust(); } }

        public string Title { get { return ThemedGroupBox.Text; } set { ThemedGroupBox.Text = value; } }

        public ElementView? ParentView { get; set; }


        public Element() : this(null) { }


        public Element(ElementView parentView) {
            InitializeComponent();

            this.ParentView = parentView;

            Location = new Point(10, 10);
            Size = new Size(100, 100);
            Margin = new Padding(10);
            MinimumSize = new Size(100, 100);
            MouseDown += draggablePanel_MouseDown;
            MouseMove += draggablePanel_MouseMove;
            MouseUp += draggablePanel_MouseUp;
            this.BackColor = GetColor(ThemeColor.ViewBackColor);
        }


        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }



        /// <summary>
        /// Ov
        /// </summary>
        public virtual void Init() {

        }

   

        /// <summary>
        /// Method to switch between local view screens.
        /// </summary>
        /// <param name="key">Local screen name</param>
        /// <param name="modal">Locked or not locked view</param>
        public void SwitchToLocalScreen(string key, bool modal) {

            if (!modal)
                this.ParentView?.Container?.UnlockView();

            this.ParentView?.SwitchScreen(key);

            if (modal)
                this.ParentView?.Container?.LockView();
        }

        private void DragAdjust() {
            if (isDragAllowed) {
                Padding = new Padding(5, 35, 5, 5);
                ThemedGroupBox.Dock = DockStyle.None;
                ThemedGroupBox.Location = new Point(5, 35);
            }
            else {

                Padding = new Padding(5);
                ThemedGroupBox.Dock = DockStyle.Fill;
                ThemedGroupBox.Location = new Point(0, 35);
            }
        }


        private void draggablePanel_MouseDown(object sender, MouseEventArgs e) {

            if (isDragAllowed) {
                // we do drag now
                isDragging = true;
                // store start pos of mouse relative to panel
                startOffset = e.Location;
            }
        }

        private void draggablePanel_MouseMove(object sender, MouseEventArgs e) {

            if (isDragAllowed) {
                if (isDragging) {
                    // get the new location based on the offset
                    var newLoc = Location;
                    newLoc.X += e.X - startOffset.X;
                    newLoc.Y += e.Y - startOffset.Y;

                    // if you want to ensure it stays inside the parent panel, do boundary checks
                    // e.g.:
                    // newLoc.X = Math.Max(0, newLoc.X);
                    // newLoc.X = Math.Min(parentPanel.Width - draggablePanel.Width, newLoc.X);
                    // similarly for Y

                    Location = newLoc;
                }
            }
        }

        private void draggablePanel_MouseUp(object sender, MouseEventArgs e) {

            if (isDragAllowed) {
                // stop dragging
                isDragging = false;
            }
        }
    }
}
