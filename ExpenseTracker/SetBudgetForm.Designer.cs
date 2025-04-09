namespace ExpenseTracker
{
    partial class SetBudgetForm
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            cmbAccountBudget = new ComboBox();
            txtlimitAmount = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnSetBudget = new Button();
            btnCloseForm = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbAccountBudget);
            groupBox1.Controls.Add(txtlimitAmount);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSetBudget);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set New Budget";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 192);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 6;
            label3.Text = "Account";
            label3.Click += label3_Click;
            // 
            // cmbAccountBudget
            // 
            cmbAccountBudget.FormattingEnabled = true;
            cmbAccountBudget.Location = new Point(212, 189);
            cmbAccountBudget.Name = "cmbAccountBudget";
            cmbAccountBudget.Size = new Size(151, 39);
            cmbAccountBudget.TabIndex = 5;
            // 
            // txtlimitAmount
            // 
            txtlimitAmount.Location = new Point(212, 282);
            txtlimitAmount.Name = "txtlimitAmount";
            txtlimitAmount.Size = new Size(125, 38);
            txtlimitAmount.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(212, 90);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 39);
            cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 289);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 2;
            label2.Text = "Limit Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 93);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 1;
            label1.Text = "Category";
            label1.Click += label1_Click;
            // 
            // btnSetBudget
            // 
            btnSetBudget.ForeColor = Color.Black;
            btnSetBudget.Location = new Point(224, 370);
            btnSetBudget.Name = "btnSetBudget";
            btnSetBudget.Size = new Size(160, 38);
            btnSetBudget.TabIndex = 0;
            btnSetBudget.Text = "Set Budget";
            btnSetBudget.UseVisualStyleBackColor = true;
            btnSetBudget.Click += btnSetBudget_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseForm.Location = new Point(371, 12);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(36, 46);
            btnCloseForm.TabIndex = 1;
            btnCloseForm.Text = "x";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // SetBudgetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 41, 41);
            ClientSize = new Size(435, 505);
            Controls.Add(btnCloseForm);
            Controls.Add(groupBox1);
            Name = "SetBudgetForm";
            Text = "SetBudgetForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtlimitAmount;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label1;
        private Button btnSetBudget;
        private Label label3;
        private ComboBox cmbAccountBudget;
        private Button btnCloseForm;
    }
}