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
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.CausesValidation = false;
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
            // SettingsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "SettingsElement";
            Size = new Size(859, 554);
            Title = "Monthly Report";
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
