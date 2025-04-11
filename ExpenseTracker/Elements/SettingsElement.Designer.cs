namespace ExpenseTracker.Elements
{
    partial class SettingsElement {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            themeDropDown = new Controls.ThemedComboBox();
            themedLabel1 = new Controls.ThemedLabel();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.CausesValidation = false;
            ThemedGroupBox.Controls.Add(themedLabel1);
            ThemedGroupBox.Controls.Add(themeDropDown);
            ThemedGroupBox.Size = new Size(849, 504);
            ThemedGroupBox.Text = "Settings";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // themeDropDown
            // 
            themeDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            themeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            themeDropDown.FormattingEnabled = true;
            themeDropDown.Location = new Point(66, 113);
            themeDropDown.Name = "themeDropDown";
            themeDropDown.Size = new Size(353, 40);
            themeDropDown.TabIndex = 0;
            themeDropDown.SelectedIndexChanged += themeDropDown_SelectedIndexChanged;
            // 
            // themedLabel1
            // 
            themedLabel1.AutoSize = true;
            themedLabel1.Location = new Point(42, 69);
            themedLabel1.Name = "themedLabel1";
            themedLabel1.Size = new Size(180, 32);
            themedLabel1.TabIndex = 1;
            themedLabel1.Text = "Current Theme:";
            // 
            // SettingsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "SettingsElement";
            Size = new Size(859, 554);
            Title = "Settings";
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Controls.ThemedLabel themedLabel1;
        private Controls.ThemedComboBox themeDropDown;
    }
}
