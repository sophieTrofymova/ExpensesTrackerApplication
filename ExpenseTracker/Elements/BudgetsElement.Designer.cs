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
            btnAddBudget = new Button();
            Budgets = new ThemedGroupBox();
            ThemedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudgets).BeginInit();
            Budgets.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(Budgets);
            ThemedGroupBox.Controls.Add(btnAddBudget);
            ThemedGroupBox.Location = new Point(2, 19);
            ThemedGroupBox.Size = new Size(774, 519);
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
            dgvBudgets.Location = new Point(3, 35);
            dgvBudgets.Name = "dgvBudgets";
            dgvBudgets.RowHeadersWidth = 51;
            dgvBudgets.Size = new Size(756, 190);
            dgvBudgets.TabIndex = 1;
            // 
            // btnAddBudget
            // 
            btnAddBudget.BackColor = Color.LightGreen;
            btnAddBudget.ForeColor = Color.Black;
            btnAddBudget.Location = new Point(557, 312);
            btnAddBudget.Name = "btnAddBudget";
            btnAddBudget.Size = new Size(199, 43);
            btnAddBudget.TabIndex = 2;
            btnAddBudget.Text = "Set New Budget";
            btnAddBudget.UseVisualStyleBackColor = false;
            btnAddBudget.Click += btnAddBudget_Click;
            // 
            // Budgets
            // 
            Budgets.Controls.Add(dgvBudgets);
            Budgets.Location = new Point(6, 63);
            Budgets.Name = "Budgets";
            Budgets.Size = new Size(762, 228);
            Budgets.TabIndex = 3;
            Budgets.TabStop = false;
            Budgets.Text = "My Budgets";
            // 
            // BudgetsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "BudgetsElement";
            Size = new Size(784, 556);
            ThemedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBudgets).EndInit();
            Budgets.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBudgets;
        private Button btnAddBudget;
        private ThemedGroupBox Budgets;
    }
}
