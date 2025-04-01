namespace ExpenseTracker {
    partial class NewElement {
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
            bAddTransaction = new Button();
            textBox1 = new TextBox();
            tbSomeField = new TextBox();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(tbSomeField);
            GroupBox.Controls.Add(textBox1);
            GroupBox.Controls.Add(bAddTransaction);
            GroupBox.Size = new Size(529, 353);
            GroupBox.Text = "New Element";
            // 
            // bAddTransaction
            // 
            bAddTransaction.Location = new Point(383, 290);
            bAddTransaction.Name = "bAddTransaction";
            bAddTransaction.Size = new Size(129, 44);
            bAddTransaction.TabIndex = 0;
            bAddTransaction.Text = "ADD";
            bAddTransaction.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 39);
            textBox1.TabIndex = 1;
            // 
            // tbSomeField
            // 
            tbSomeField.Location = new Point(29, 119);
            tbSomeField.Name = "tbSomeField";
            tbSomeField.Size = new Size(299, 39);
            tbSomeField.TabIndex = 1;
            // 
            // NewElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "NewElement";
            Size = new Size(539, 403);
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        public TextBox tbSomeField;
        public Button bAddTransaction;
    }
}
