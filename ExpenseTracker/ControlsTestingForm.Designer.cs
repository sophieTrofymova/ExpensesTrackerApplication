namespace ExpenseTracker {
    partial class ControlsTestingForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            themedComboBox1 = new Controls.ThemedComboBox();
            themedGroupBox1 = new Controls.ThemedGroupBox();
            SuspendLayout();
            // 
            // themedComboBox1
            // 
            themedComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            themedComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            themedComboBox1.FormattingEnabled = true;
            themedComboBox1.Location = new Point(194, 44);
            themedComboBox1.Name = "themedComboBox1";
            themedComboBox1.Size = new Size(191, 28);
            themedComboBox1.TabIndex = 0;
            // 
            // themedGroupBox1
            // 
            themedGroupBox1.BorderPadding = 8;
            themedGroupBox1.ForeColor = Color.WhiteSmoke;
            themedGroupBox1.Location = new Point(194, 97);
            themedGroupBox1.Name = "themedGroupBox1";
            themedGroupBox1.Size = new Size(250, 125);
            themedGroupBox1.TabIndex = 1;
            themedGroupBox1.TabStop = false;
            themedGroupBox1.Text = "themedGroupBox1";
            // 
            // ControlsTestingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(themedGroupBox1);
            Controls.Add(themedComboBox1);
            Name = "ControlsTestingForm";
            Text = "Custom Controls Testing Form";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ThemedComboBox themedComboBox1;
        private Controls.ThemedGroupBox themedGroupBox1;
    }
}