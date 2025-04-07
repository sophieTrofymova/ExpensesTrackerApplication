namespace ExpenseTracker {
    partial class TestModeUserSelectorForm {
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
            lvSelectUser = new ListView();
            bConfirm = new Button();
            SelectAccountHintLabel = new Label();
            SuspendLayout();
            // 
            // lvSelectAccount
            // 
            lvSelectUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvSelectUser.BackColor = SystemColors.InactiveBorder;
            lvSelectUser.Location = new Point(16, 64);
            lvSelectUser.Margin = new Padding(4);
            lvSelectUser.Name = "lvSelectAccount";
            lvSelectUser.Size = new Size(569, 302);
            lvSelectUser.TabIndex = 7;
            lvSelectUser.UseCompatibleStateImageBehavior = false;
            lvSelectUser.MouseDoubleClick += lvSelectUser_MouseDoubleClick;
            // 
            // bConfirm
            // 
            bConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bConfirm.BackColor = SystemColors.ButtonFace;
            bConfirm.FlatAppearance.MouseOverBackColor = Color.Lime;
            bConfirm.FlatStyle = FlatStyle.Flat;
            bConfirm.Location = new Point(456, 381);
            bConfirm.Margin = new Padding(4);
            bConfirm.Name = "bConfirm";
            bConfirm.Size = new Size(129, 41);
            bConfirm.TabIndex = 8;
            bConfirm.Text = "Confirm";
            bConfirm.UseVisualStyleBackColor = false;
            // 
            // SelectAccountHintLabel
            // 
            SelectAccountHintLabel.AutoSize = true;
            SelectAccountHintLabel.Location = new Point(16, 19);
            SelectAccountHintLabel.Name = "SelectAccountHintLabel";
            SelectAccountHintLabel.Size = new Size(337, 28);
            SelectAccountHintLabel.TabIndex = 9;
            SelectAccountHintLabel.Text = "Select Account you want to sign with:";
            // 
            // TestModeAccountSelectorForm
            // 
            AcceptButton = bConfirm;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(604, 439);
            Controls.Add(SelectAccountHintLabel);
            Controls.Add(bConfirm);
            Controls.Add(lvSelectUser);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(622, 486);
            Name = "TestModeAccountSelectorForm";
            Text = "Test Mode - Account Selector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSelectUser;
        private Button bConfirm;
        private Label SelectAccountHintLabel;
    }
}