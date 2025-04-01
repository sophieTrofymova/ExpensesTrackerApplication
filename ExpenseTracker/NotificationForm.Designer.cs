namespace ExpenseTracker
{
    partial class NotificationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NotificationHeader = new Label();
            NotificaticationContent = new RichTextBox();
            bCloseImmidiatelly = new Button();
            SuspendLayout();
            // 
            // NotificationHeader
            // 
            NotificationHeader.AutoSize = true;
            NotificationHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            NotificationHeader.ForeColor = Color.WhiteSmoke;
            NotificationHeader.Location = new Point(12, 9);
            NotificationHeader.Name = "NotificationHeader";
            NotificationHeader.Size = new Size(193, 23);
            NotificationHeader.TabIndex = 0;
            NotificationHeader.Text = "<Notification Header>";
            // 
            // NotificaticationContent
            // 
            NotificaticationContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotificaticationContent.BackColor = SystemColors.Desktop;
            NotificaticationContent.BorderStyle = BorderStyle.None;
            NotificaticationContent.Font = new Font("Segoe UI", 10F);
            NotificaticationContent.ForeColor = Color.WhiteSmoke;
            NotificaticationContent.Location = new Point(12, 40);
            NotificaticationContent.Name = "NotificaticationContent";
            NotificaticationContent.Size = new Size(460, 97);
            NotificaticationContent.TabIndex = 1;
            NotificaticationContent.Text = "Some Text";
            // 
            // bCloseImmidiatelly
            // 
            bCloseImmidiatelly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bCloseImmidiatelly.FlatStyle = FlatStyle.Flat;
            bCloseImmidiatelly.Font = new Font("Segoe UI", 10F);
            bCloseImmidiatelly.ForeColor = Color.WhiteSmoke;
            bCloseImmidiatelly.Location = new Point(432, 2);
            bCloseImmidiatelly.Name = "bCloseImmidiatelly";
            bCloseImmidiatelly.Size = new Size(40, 35);
            bCloseImmidiatelly.TabIndex = 2;
            bCloseImmidiatelly.Text = "X";
            bCloseImmidiatelly.UseVisualStyleBackColor = true;
            bCloseImmidiatelly.Click += bCloseImmidiatelly_Click;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(484, 149);
            Controls.Add(bCloseImmidiatelly);
            Controls.Add(NotificaticationContent);
            Controls.Add(NotificationHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bCloseImmidiatelly;
        public Label NotificationHeader;
        public RichTextBox NotificaticationContent;
    }
}