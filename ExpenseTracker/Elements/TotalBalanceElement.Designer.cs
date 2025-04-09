namespace ExpenseTracker {
    partial class BalanceSummaryElement {
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
            AccountList = new ListView();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(AccountList);
            ThemedGroupBox.Padding = new Padding(20);
            ThemedGroupBox.Size = new Size(762, 370);
            // 
            // AccountList
            // 
            AccountList.Dock = DockStyle.Fill;
            AccountList.Location = new Point(20, 52);
            AccountList.Name = "AccountList";
            AccountList.Size = new Size(722, 298);
            AccountList.TabIndex = 0;
            AccountList.UseCompatibleStateImageBehavior = false;
            // 
            // TotalBalanceElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "TotalBalanceElement";
            Size = new Size(775, 445);
            ThemedGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public ListView AccountList;
    }
}
