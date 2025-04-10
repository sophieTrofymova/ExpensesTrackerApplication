using ExpenseTracker.Controls;

namespace ExpenseTracker.Elements
{
    partial class BudgetsElement
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
            dgvBudgets = new DataGridView();
            Budgets = new ThemedGroupBox();
            btnReset = new Button();
            btnDelete = new Button();
            btnAddBudget = new Button();
            pnlAddBudget = new Panel();
            gbEditBudget = new GroupBox();
            btnAddNewBudget = new Button();
            label3 = new Label();
            cmbAccountBudget = new ComboBox();
            txtlimitAmount = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnSetBudget = new Button();
            groupBox1 = new GroupBox();
            btnEditBudget = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            pnlEditBudget = new Panel();
            ThemedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudgets).BeginInit();
            Budgets.SuspendLayout();
            pnlAddBudget.SuspendLayout();
            gbEditBudget.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlEditBudget.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.BackgroundImageLayout = ImageLayout.Center;
            ThemedGroupBox.Controls.Add(pnlEditBudget);
            ThemedGroupBox.Controls.Add(pnlAddBudget);
            ThemedGroupBox.Controls.Add(btnAddBudget);
            ThemedGroupBox.Controls.Add(btnDelete);
            ThemedGroupBox.Controls.Add(btnReset);
            ThemedGroupBox.Controls.Add(Budgets);
            ThemedGroupBox.Location = new Point(2, 0);
            ThemedGroupBox.Size = new Size(1448, 835);
            // 
            // dgvBudgets
            // 
            dgvBudgets.AllowUserToAddRows = false;
            dgvBudgets.AllowUserToDeleteRows = false;
            dgvBudgets.AllowUserToResizeColumns = false;
            dgvBudgets.AllowUserToResizeRows = false;
            dgvBudgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudgets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudgets.Dock = DockStyle.Fill;
            dgvBudgets.Location = new Point(8, 40);
            dgvBudgets.Name = "dgvBudgets";
            dgvBudgets.RowHeadersWidth = 51;
            dgvBudgets.Size = new Size(1388, 276);
            dgvBudgets.TabIndex = 1;
            // 
            // Budgets
            // 
            Budgets.BorderPadding = 8;
            Budgets.Controls.Add(dgvBudgets);
            Budgets.ForeColor = Color.WhiteSmoke;
            Budgets.Location = new Point(11, 89);
            Budgets.Name = "Budgets";
            Budgets.Size = new Size(1404, 324);
            Budgets.TabIndex = 3;
            Budgets.TabStop = false;
            Budgets.Text = "My Budgets";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1156, 64);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "Edit";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1293, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 44);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddBudget
            // 
            btnAddBudget.Location = new Point(981, 64);
            btnAddBudget.Name = "btnAddBudget";
            btnAddBudget.Size = new Size(151, 42);
            btnAddBudget.TabIndex = 6;
            btnAddBudget.Text = "Add Budget";
            btnAddBudget.UseVisualStyleBackColor = true;
            btnAddBudget.Click += btnAddBudget_Click_1;
            // 
            // pnlAddBudget
            // 
            pnlAddBudget.Controls.Add(gbEditBudget);
            pnlAddBudget.Location = new Point(11, 419);
            pnlAddBudget.Name = "pnlAddBudget";
            pnlAddBudget.Size = new Size(514, 386);
            pnlAddBudget.TabIndex = 7;
            pnlAddBudget.Visible = false;
            // 
            // gbEditBudget
            // 
            gbEditBudget.Controls.Add(btnAddNewBudget);
            gbEditBudget.Controls.Add(label3);
            gbEditBudget.Controls.Add(cmbAccountBudget);
            gbEditBudget.Controls.Add(txtlimitAmount);
            gbEditBudget.Controls.Add(cmbCategory);
            gbEditBudget.Controls.Add(label2);
            gbEditBudget.Controls.Add(label1);
            gbEditBudget.Controls.Add(btnSetBudget);
            gbEditBudget.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEditBudget.ForeColor = Color.White;
            gbEditBudget.Location = new Point(8, 10);
            gbEditBudget.Name = "gbEditBudget";
            gbEditBudget.Size = new Size(490, 360);
            gbEditBudget.TabIndex = 1;
            gbEditBudget.TabStop = false;
            gbEditBudget.Text = "Set New Budget";
            gbEditBudget.Enter += groupBox2_Enter;
            // 
            // btnAddNewBudget
            // 
            btnAddNewBudget.ForeColor = Color.FromArgb(223, 107, 12);
            btnAddNewBudget.Location = new Point(347, 300);
            btnAddNewBudget.Name = "btnAddNewBudget";
            btnAddNewBudget.Size = new Size(115, 38);
            btnAddNewBudget.TabIndex = 7;
            btnAddNewBudget.Text = "Save";
            btnAddNewBudget.UseVisualStyleBackColor = true;
            btnAddNewBudget.Click += btnAddNewBudget_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 6;
            label3.Text = "Account";
            // 
            // cmbAccountBudget
            // 
            cmbAccountBudget.FormattingEnabled = true;
            cmbAccountBudget.Location = new Point(212, 136);
            cmbAccountBudget.Name = "cmbAccountBudget";
            cmbAccountBudget.Size = new Size(151, 39);
            cmbAccountBudget.TabIndex = 5;
            // 
            // txtlimitAmount
            // 
            txtlimitAmount.Location = new Point(212, 224);
            txtlimitAmount.Name = "txtlimitAmount";
            txtlimitAmount.Size = new Size(125, 38);
            txtlimitAmount.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(212, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 39);
            cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 227);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 2;
            label2.Text = "Limit Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 1;
            label1.Text = "Category";
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditBudget);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 360);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Budget";
            // 
            // btnEditBudget
            // 
            btnEditBudget.ForeColor = Color.FromArgb(223, 107, 12);
            btnEditBudget.Location = new Point(347, 300);
            btnEditBudget.Name = "btnEditBudget";
            btnEditBudget.Size = new Size(115, 38);
            btnEditBudget.TabIndex = 7;
            btnEditBudget.Text = "Save";
            btnEditBudget.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 144);
            label4.Name = "label4";
            label4.Size = new Size(98, 31);
            label4.TabIndex = 6;
            label4.Text = "Account";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 39);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 38);
            textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(212, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 39);
            comboBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 227);
            label5.Name = "label5";
            label5.Size = new Size(153, 31);
            label5.TabIndex = 2;
            label5.Text = "Limit Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 61);
            label6.Name = "label6";
            label6.Size = new Size(106, 31);
            label6.TabIndex = 1;
            label6.Text = "Category";
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(224, 370);
            button2.Name = "button2";
            button2.Size = new Size(160, 38);
            button2.TabIndex = 0;
            button2.Text = "Set Budget";
            button2.UseVisualStyleBackColor = true;
            // 
            // pnlEditBudget
            // 
            pnlEditBudget.Controls.Add(groupBox1);
            pnlEditBudget.Location = new Point(550, 411);
            pnlEditBudget.Name = "pnlEditBudget";
            pnlEditBudget.Size = new Size(513, 356);
            pnlEditBudget.TabIndex = 9;
            pnlEditBudget.Visible = false;
            // 
            // BudgetsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "BudgetsElement";
            Size = new Size(1472, 853);
            ThemedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBudgets).EndInit();
            Budgets.ResumeLayout(false);
            pnlAddBudget.ResumeLayout(false);
            gbEditBudget.ResumeLayout(false);
            gbEditBudget.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlEditBudget.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBudgets;
        private ThemedGroupBox Budgets;
        private Button btnDelete;
        private Button btnReset;
        private Button btnAddBudget;
        private Panel pnlAddBudget;
        private GroupBox gbEditBudget;
        private Label label3;
        private ComboBox cmbAccountBudget;
        private TextBox txtlimitAmount;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label1;
        private Button btnSetBudget;
        private GroupBox groupBox1;
        private Button btnEditBudget;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button btnAddNewBudget;
        private Panel pnlEditBudget;
    }
}
