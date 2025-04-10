namespace ExpenseTracker.Elements
{
    partial class ReportElement
    {
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
        private void InitializeComponent()
        {
            panelReport = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbMonth = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ThemedGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(groupBox1);
            ThemedGroupBox.Controls.Add(label1);
            ThemedGroupBox.Controls.Add(cmbMonth);
            ThemedGroupBox.Size = new Size(849, 504);
            ThemedGroupBox.Text = "Monthly Report";
            // 
            // panelReport
            // 
            panelReport.Dock = DockStyle.Fill;
            panelReport.Location = new Point(3, 35);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(754, 306);
            panelReport.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(158, 69);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(151, 39);
            cmbMonth.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 2;
            label1.Text = "Month";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelReport);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(44, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 344);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "My Report";
            // 
            // ReportElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "ReportElement";
            Size = new Size(859, 554);
            Title = "Monthly Report";
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReport;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbMonth;
    }
}
