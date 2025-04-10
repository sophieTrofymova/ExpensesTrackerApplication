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
            themedListViewControl1 = new ThemedListViewControl();
            SuspendLayout();
            // 
            // themedListViewControl1
            // 
            themedListViewControl1.BackColor = Color.DarkCyan;
            themedListViewControl1.Location = new Point(237, 118);
            themedListViewControl1.Name = "themedListViewControl1";
            themedListViewControl1.Size = new Size(517, 287);
            themedListViewControl1.TabIndex = 0;
            // 
            // ControlsTestingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(themedListViewControl1);
            Name = "ControlsTestingForm";
            Text = "Custom Controls Testing Form";
            ResumeLayout(false);
        }

        #endregion

        private ThemedListViewControl themedListViewControl1;
    }
}