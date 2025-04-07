﻿using System;
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

        int rows = 1, cols = 1;
        int row = 0, col = 0;
        public int Rows { get { return rows; } set { rows = (value > 0) ? value : 1; } }
        public int Cols { get { return cols; } set { cols = (value > 0) ? value : 1; } }

        public int Row { get { return row; } set { row = (value >= 0) ? value : 0; } }
        public int Col { get { return col; } set { col = (value >= 0) ? value : 0; } }


        bool isDragAllowed = false;
        public bool AllowDrag { get { return isDragAllowed; } set { isDragAllowed = value; DragAdjust(); } }

        public string Title { get { return GroupBox.Text; } set { GroupBox.Text = value; } }

        public Element() {
            InitializeComponent();

            this.Location = new Point(10, 10);
            this.Size = new Size(100, 100);
            this.Margin = new Padding(10);
            this.MinimumSize = new Size(100, 100);
            this.MouseDown += draggablePanel_MouseDown;
            this.MouseMove += draggablePanel_MouseMove;
            this.MouseUp += draggablePanel_MouseUp;
            //this.BackColor = MainForm.AppState.Settings.CurrentTheme.GetColor( Storage.ThemeColor.ElementBackColor);
            //this.GroupBox.BackColor =  MainForm.AppState.Settings.CurrentTheme.GetColor(Storage.ThemeColor.ElementBackColor);
            //this.GroupBox.ForeColor = MainForm.AppState.Settings.CurrentTheme.GetColor(Storage.ThemeColor.CaptionColor);
        }


        private void DragAdjust() {
            if (isDragAllowed) {
                this.Padding = new Padding(5, 35, 5, 5);
                this.GroupBox.Dock = DockStyle.None;
                this.GroupBox.Location = new Point(5, 35);
            }
            else {

                this.Padding = new Padding(5);
                this.GroupBox.Dock = DockStyle.Fill;
                this.GroupBox.Location = new Point(0, 35);
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
        }

        private void draggablePanel_MouseUp(object sender, MouseEventArgs e) {

            if (isDragAllowed) {
                // stop dragging
                isDragging = false;
            }
        }
    }
}
