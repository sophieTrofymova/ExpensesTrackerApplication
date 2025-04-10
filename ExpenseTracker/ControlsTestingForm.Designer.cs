using ExpenseTracker.Controls;

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
            themedComboBox1 = new ThemedComboBox();
            themedGroupBox1 = new ThemedGroupBox();
            textBox1 = new ThemedTextBox();
            themedCheckBox1 = new ThemedCheckBox();
            themedLabel1 = new ThemedLabel();
            SuspendLayout();
            // 
            // themedComboBox1
            // 
            themedComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            themedComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            themedComboBox1.FormattingEnabled = true;
            themedComboBox1.Location = new Point(51, 32);
            themedComboBox1.Name = "themedComboBox1";
            themedComboBox1.Size = new Size(191, 28);
            themedComboBox1.TabIndex = 0;
            // 
            // themedGroupBox1
            // 
            themedGroupBox1.BorderPadding = 8;
            themedGroupBox1.ForeColor = Color.WhiteSmoke;
            themedGroupBox1.Location = new Point(51, 84);
            themedGroupBox1.Name = "themedGroupBox1";
            themedGroupBox1.Size = new Size(250, 125);
            themedGroupBox1.TabIndex = 1;
            themedGroupBox1.TabStop = false;
            themedGroupBox1.Text = "themedGroupBox1";
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.None;
            textBox1.AutoCompleteSource = AutoCompleteSource.None;
            textBox1.AutoSize = true;
            textBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            textBox1.BorderThickness = 2;
            textBox1.CharacterCasing = CharacterCasing.Normal;
            textBox1.InnerPadding = new Padding(4);
            textBox1.Location = new Point(51, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 27);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.UseSystemPasswordChar = false;
            // 
            // themedCheckBox1
            // 
            themedCheckBox1.AutoSize = true;
            themedCheckBox1.CheckBoxSize = 24;
            themedCheckBox1.Checked = true;
            themedCheckBox1.CheckState = CheckState.Checked;
            themedCheckBox1.Location = new Point(51, 217);
            themedCheckBox1.Margin = new Padding(5);
            themedCheckBox1.Name = "themedCheckBox1";
            themedCheckBox1.Padding = new Padding(5);
            themedCheckBox1.Size = new Size(164, 34);
            themedCheckBox1.TabIndex = 3;
            themedCheckBox1.Text = "themedCheckBox1";
            themedCheckBox1.UseVisualStyleBackColor = true;
            // 
            // themedLabel1
            // 
            themedLabel1.AutoSize = true;
            themedLabel1.Location = new Point(414, 179);
            themedLabel1.Name = "themedLabel1";
            themedLabel1.Size = new Size(96, 20);
            themedLabel1.TabIndex = 4;
            themedLabel1.Text = "themedLabel";
            // 
            // ControlsTestingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(themedLabel1);
            Controls.Add(themedCheckBox1);
            Controls.Add(textBox1);
            Controls.Add(themedGroupBox1);
            Controls.Add(themedComboBox1);
            Name = "ControlsTestingForm";
            Text = "Custom Controls Testing Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ThemedComboBox themedComboBox1;
        private ThemedGroupBox themedGroupBox1;
        private ThemedTextBox textBox1;
        private ThemedCheckBox themedCheckBox1;
        private ThemedLabel themedLabel1;
    }
}