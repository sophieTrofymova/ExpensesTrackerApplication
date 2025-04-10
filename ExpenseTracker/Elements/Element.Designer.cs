using ExpenseTracker.Controls;

namespace ExpenseTracker.Elements {
    partial class Element {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ThemedGroupBox = new ThemedGroupBox();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThemedGroupBox.BorderPadding = 8;
            ThemedGroupBox.BackColor = Color.FromArgb(41, 41, 41);
            ThemedGroupBox.FlatStyle = FlatStyle.Flat;
            ThemedGroupBox.Font = new Font("Segoe UI", 14F);
            ThemedGroupBox.ForeColor = Color.FromArgb(223, 107, 12);
            ThemedGroupBox.Location = new Point(5, 35);
            ThemedGroupBox.Name = "ThemedGroupBox";
            ThemedGroupBox.Size = new Size(724, 421);
            ThemedGroupBox.TabIndex = 0;
            ThemedGroupBox.TabStop = false;
            ThemedGroupBox.Text = "GroupBoxText";
            // 
            // Element
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(ThemedGroupBox);
            Name = "Element";
            Padding = new Padding(5, 35, 5, 15);
            Size = new Size(734, 471);
            ResumeLayout(false);
        }

        #endregion

        public ThemedGroupBox ThemedGroupBox;
    }
}
