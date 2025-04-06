namespace ExpenseTracker {
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
            GroupBox = new GroupBox();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupBox.BackColor = Color.FromArgb(41, 41, 41);
            GroupBox.FlatStyle = FlatStyle.Flat;
            GroupBox.Font = new Font("Segoe UI", 14F);
            GroupBox.ForeColor = Color.FromArgb(223, 107, 12);
            GroupBox.Location = new Point(5, 35);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(724, 421);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "GroupBoxText";
            // 
            // Element
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            Controls.Add(GroupBox);
            Name = "Element";
            Padding = new Padding(5, 35, 5, 15);
            Size = new Size(734, 471);
            ResumeLayout(false);
        }

        #endregion

        public GroupBox GroupBox;
    }
}
