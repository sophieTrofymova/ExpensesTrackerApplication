namespace ExpenseTracker {
    partial class TotalBalanceElement {
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
            OKButton = new Button();
            label6 = new Label();
            BalanceLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            BalanceInWalletsText = new Label();
            BalanceInCreditsText = new Label();
            TotalBalanceText = new Label();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(label4);
            GroupBox.Controls.Add(BalanceInWalletsText);
            GroupBox.Controls.Add(BalanceInCreditsText);
            GroupBox.Controls.Add(TotalBalanceText);
            GroupBox.Controls.Add(label6);
            GroupBox.Controls.Add(BalanceLabel);
            GroupBox.Controls.Add(label3);
            GroupBox.Controls.Add(OKButton);
            GroupBox.Size = new Size(545, 395);
            // 
            // OKButton
            // 
            OKButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OKButton.Location = new Point(383, 308);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(113, 48);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(37, 153);
            label6.Name = "label6";
            label6.Size = new Size(154, 32);
            label6.TabIndex = 1;
            label6.Text = "Credit Cards";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BalanceLabel.ForeColor = Color.WhiteSmoke;
            BalanceLabel.Location = new Point(37, 108);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(102, 32);
            BalanceLabel.TabIndex = 2;
            BalanceLabel.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(37, 63);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 3;
            label3.Text = "Summary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(37, 194);
            label4.Name = "label4";
            label4.Size = new Size(474, 32);
            label4.TabIndex = 4;
            label4.Text = "----------------------------------------------";
            // 
            // BalanceInWalletsText
            // 
            BalanceInWalletsText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BalanceInWalletsText.AutoSize = true;
            BalanceInWalletsText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BalanceInWalletsText.ForeColor = Color.WhiteSmoke;
            BalanceInWalletsText.Location = new Point(248, 108);
            BalanceInWalletsText.MinimumSize = new Size(264, 32);
            BalanceInWalletsText.Name = "BalanceInWalletsText";
            BalanceInWalletsText.Size = new Size(264, 32);
            BalanceInWalletsText.TabIndex = 5;
            BalanceInWalletsText.Text = "<BALANCE WALETS>";
            BalanceInWalletsText.TextAlign = ContentAlignment.TopRight;
            BalanceInWalletsText.Click += label7_Click;
            // 
            // BalanceInCreditsText
            // 
            BalanceInCreditsText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BalanceInCreditsText.AutoSize = true;
            BalanceInCreditsText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BalanceInCreditsText.ForeColor = Color.Red;
            BalanceInCreditsText.Location = new Point(248, 153);
            BalanceInCreditsText.MinimumSize = new Size(264, 32);
            BalanceInCreditsText.Name = "BalanceInCreditsText";
            BalanceInCreditsText.Size = new Size(264, 32);
            BalanceInCreditsText.TabIndex = 6;
            BalanceInCreditsText.Text = "<BALANCE CREDIT>";
            BalanceInCreditsText.TextAlign = ContentAlignment.TopRight;
            // 
            // TotalBalanceText
            // 
            TotalBalanceText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalBalanceText.AutoSize = true;
            TotalBalanceText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TotalBalanceText.ForeColor = Color.WhiteSmoke;
            TotalBalanceText.Location = new Point(248, 226);
            TotalBalanceText.MinimumSize = new Size(264, 32);
            TotalBalanceText.Name = "TotalBalanceText";
            TotalBalanceText.Size = new Size(264, 32);
            TotalBalanceText.TabIndex = 7;
            TotalBalanceText.Text = "<BALANCE>";
            TotalBalanceText.TextAlign = ContentAlignment.TopRight;
            // 
            // TotalBalanceElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "TotalBalanceElement";
            Size = new Size(555, 445);
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OKButton;
        private Label label6;
        private Label BalanceLabel;
        private Label label3;
        private Label label4;
        public Label BalanceInWalletsText;
        public Label BalanceInCreditsText;
        public Label TotalBalanceText;
    }
}
