namespace ExpenseTracker.Elements {
    partial class EditTransactionElement {
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
            expenseAmount = new Controls.ThemedTextBox();
            dtpAffectDate = new DateTimePicker();
            label6 = new Controls.ThemedLabel();
            senderAccountDropDown = new Controls.ThemedComboBox();
            label7 = new Controls.ThemedLabel();
            bCategory = new Controls.ThemedLabel();
            label2 = new Controls.ThemedLabel();
            categoryDropDown = new Controls.ThemedComboBox();
            bCancel = new Controls.ThemedButton();
            bEdit = new Controls.ThemedButton();
            typeDropDown = new Controls.ThemedComboBox();
            themedLabel1 = new Controls.ThemedLabel();
            themedLabel2 = new Controls.ThemedLabel();
            receiverAccountDropDown = new Controls.ThemedComboBox();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(bEdit);
            ThemedGroupBox.Controls.Add(bCancel);
            ThemedGroupBox.Controls.Add(dtpAffectDate);
            ThemedGroupBox.Controls.Add(label2);
            ThemedGroupBox.Controls.Add(expenseAmount);
            ThemedGroupBox.Controls.Add(label6);
            ThemedGroupBox.Controls.Add(themedLabel1);
            ThemedGroupBox.Controls.Add(bCategory);
            ThemedGroupBox.Controls.Add(receiverAccountDropDown);
            ThemedGroupBox.Controls.Add(themedLabel2);
            ThemedGroupBox.Controls.Add(senderAccountDropDown);
            ThemedGroupBox.Controls.Add(label7);
            ThemedGroupBox.Controls.Add(typeDropDown);
            ThemedGroupBox.Controls.Add(categoryDropDown);
            ThemedGroupBox.Size = new Size(449, 581);
            // 
            // expenseAmount
            // 
            expenseAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            expenseAmount.AutoCompleteMode = AutoCompleteMode.None;
            expenseAmount.AutoCompleteSource = AutoCompleteSource.None;
            expenseAmount.AutoSize = true;
            expenseAmount.BorderThickness = 1;
            expenseAmount.CharacterCasing = CharacterCasing.Normal;
            expenseAmount.InnerPadding = new Padding(4);
            expenseAmount.Location = new Point(32, 372);
            expenseAmount.Name = "expenseAmount";
            expenseAmount.Size = new Size(382, 39);
            expenseAmount.TabIndex = 6;
            expenseAmount.TextAlign = HorizontalAlignment.Left;
            expenseAmount.UseSystemPasswordChar = false;
            // 
            // dtpAffectDate
            // 
            dtpAffectDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpAffectDate.CustomFormat = "dd/MM/yyyy";
            dtpAffectDate.Font = new Font("Segoe UI", 12F);
            dtpAffectDate.Format = DateTimePickerFormat.Custom;
            dtpAffectDate.Location = new Point(32, 445);
            dtpAffectDate.Name = "dtpAffectDate";
            dtpAffectDate.Size = new Size(382, 34);
            dtpAffectDate.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(32, 341);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 3;
            label6.Text = "Amount:";
            // 
            // senderAccountDropDown
            // 
            senderAccountDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            senderAccountDropDown.BackColor = SystemColors.WindowFrame;
            senderAccountDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            senderAccountDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            senderAccountDropDown.ForeColor = Color.WhiteSmoke;
            senderAccountDropDown.FormattingEnabled = true;
            senderAccountDropDown.Location = new Point(32, 224);
            senderAccountDropDown.Name = "senderAccountDropDown";
            senderAccountDropDown.Size = new Size(382, 40);
            senderAccountDropDown.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(32, 193);
            label7.Name = "label7";
            label7.Size = new Size(227, 28);
            label7.TabIndex = 3;
            label7.Text = "Current/Sender Account:";
            // 
            // bCategory
            // 
            bCategory.AutoSize = true;
            bCategory.Font = new Font("Segoe UI", 12F);
            bCategory.Location = new Point(32, 119);
            bCategory.Name = "bCategory";
            bCategory.Size = new Size(96, 28);
            bCategory.TabIndex = 3;
            bCategory.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 414);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Affect Date:";
            // 
            // categoryDropDown
            // 
            categoryDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryDropDown.BackColor = SystemColors.WindowFrame;
            categoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            categoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryDropDown.ForeColor = Color.WhiteSmoke;
            categoryDropDown.FormattingEnabled = true;
            categoryDropDown.Location = new Point(32, 150);
            categoryDropDown.Name = "categoryDropDown";
            categoryDropDown.Size = new Size(382, 40);
            categoryDropDown.TabIndex = 2;
            // 
            // bCancel
            // 
            bCancel.FlatAppearance.BorderSize = 0;
            bCancel.FlatStyle = FlatStyle.Flat;
            bCancel.Location = new Point(32, 502);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(132, 39);
            bCancel.TabIndex = 7;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bEdit
            // 
            bEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEdit.FlatAppearance.BorderSize = 0;
            bEdit.FlatStyle = FlatStyle.Flat;
            bEdit.Location = new Point(284, 502);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(130, 39);
            bEdit.TabIndex = 7;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // typeDropDown
            // 
            typeDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeDropDown.BackColor = SystemColors.WindowFrame;
            typeDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            typeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            typeDropDown.ForeColor = Color.WhiteSmoke;
            typeDropDown.FormattingEnabled = true;
            typeDropDown.Location = new Point(32, 76);
            typeDropDown.Name = "typeDropDown";
            typeDropDown.Size = new Size(382, 40);
            typeDropDown.TabIndex = 2;
            typeDropDown.SelectedIndexChanged += typeDropDown_SelectedIndexChanged;
            // 
            // themedLabel1
            // 
            themedLabel1.AutoSize = true;
            themedLabel1.Font = new Font("Segoe UI", 12F);
            themedLabel1.Location = new Point(32, 45);
            themedLabel1.Name = "themedLabel1";
            themedLabel1.Size = new Size(57, 28);
            themedLabel1.TabIndex = 3;
            themedLabel1.Text = "Type:";
            // 
            // themedLabel2
            // 
            themedLabel2.AutoSize = true;
            themedLabel2.Font = new Font("Segoe UI", 12F);
            themedLabel2.Location = new Point(32, 267);
            themedLabel2.Name = "themedLabel2";
            themedLabel2.Size = new Size(165, 28);
            themedLabel2.TabIndex = 3;
            themedLabel2.Text = "Receiver Account:";
            // 
            // receiverAccountDropDown
            // 
            receiverAccountDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            receiverAccountDropDown.BackColor = SystemColors.WindowFrame;
            receiverAccountDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            receiverAccountDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            receiverAccountDropDown.ForeColor = Color.WhiteSmoke;
            receiverAccountDropDown.FormattingEnabled = true;
            receiverAccountDropDown.Location = new Point(32, 298);
            receiverAccountDropDown.Name = "receiverAccountDropDown";
            receiverAccountDropDown.Size = new Size(382, 40);
            receiverAccountDropDown.TabIndex = 2;
            // 
            // EditTransactionElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "EditTransactionElement";
            Size = new Size(459, 634);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpAffectDate;
        private Controls.ThemedLabel label2;
        private Controls.ThemedTextBox expenseAmount;
        private Controls.ThemedLabel label6;
        private Controls.ThemedLabel bCategory;
        public Controls.ThemedComboBox senderAccountDropDown;
        private Controls.ThemedLabel label7;
        public Controls.ThemedComboBox categoryDropDown;
        private Controls.ThemedButton bEdit;
        private Controls.ThemedButton bCancel;
        private Controls.ThemedLabel themedLabel1;
        public Controls.ThemedComboBox typeDropDown;
        public Controls.ThemedComboBox receiverAccountDropDown;
        private Controls.ThemedLabel themedLabel2;
    }
}
