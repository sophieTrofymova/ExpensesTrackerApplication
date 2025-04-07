namespace ExpenseTracker.Controls {
    partial class FilterTransactionsElement {
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
            monthDropDown = new ComboBox();
            label1 = new Label();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(label1);
            GroupBox.Controls.Add(monthDropDown);
            GroupBox.Size = new Size(607, 330);
            // 
            // monthDropDown
            // 
            monthDropDown.FormattingEnabled = true;
            monthDropDown.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthDropDown.Location = new Point(139, 51);
            monthDropDown.Name = "monthDropDown";
            monthDropDown.Size = new Size(328, 39);
            monthDropDown.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 1;
            label1.Text = "Month:";
            // 
            // FilterTransactionsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "FilterTransactionsElement";
            Size = new Size(617, 380);
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        public ComboBox monthDropDown;
    }
}
