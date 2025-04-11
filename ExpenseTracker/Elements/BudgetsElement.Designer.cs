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
            Budgets = new ThemedGroupBox();
            lvBudgets = new ListView();
            btnReset = new Button();
            btnDelete = new Button();
            btnAddBudget = new Button();
            tbDeleteBudget = new ThemedButton();
            bEditBudget = new ThemedButton();
            bAddBudget = new ThemedButton();
            ThemedGroupBox.SuspendLayout();
            Budgets.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.BackgroundImageLayout = ImageLayout.Center;
            ThemedGroupBox.Controls.Add(bEditBudget);
            ThemedGroupBox.Controls.Add(tbDeleteBudget);
            ThemedGroupBox.Controls.Add(bAddBudget);
            ThemedGroupBox.Controls.Add(btnAddBudget);
            ThemedGroupBox.Controls.Add(btnDelete);
            ThemedGroupBox.Controls.Add(btnReset);
            ThemedGroupBox.Controls.Add(Budgets);
            ThemedGroupBox.Location = new Point(2, 0);
            ThemedGroupBox.Size = new Size(1018, 759);
            // 
            // Budgets
            // 
            Budgets.BorderPadding = 8;
            Budgets.Controls.Add(lvBudgets);
            Budgets.ForeColor = Color.WhiteSmoke;
            Budgets.Location = new Point(6, 126);
            Budgets.Name = "Budgets";
            Budgets.Size = new Size(1017, 640);
            Budgets.TabIndex = 3;
            Budgets.TabStop = false;
            Budgets.Text = "My Budgets";
            // 
            // lvBudgets
            // 
            lvBudgets.Location = new Point(30, 65);
            lvBudgets.Name = "lvBudgets";
            lvBudgets.Size = new Size(960, 541);
            lvBudgets.TabIndex = 0;
            lvBudgets.UseCompatibleStateImageBehavior = false;
            // 
            //
            // tbDeleteBudget
            // 
            tbDeleteBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDeleteBudget.FlatAppearance.BorderSize = 0;
            tbDeleteBudget.FlatStyle = FlatStyle.Flat;
            tbDeleteBudget.Location = new Point(803, 76);
            tbDeleteBudget.Name = "tbDeleteBudget";
            tbDeleteBudget.Size = new Size(191, 44);
            tbDeleteBudget.TabIndex = 7;
            tbDeleteBudget.Text = "Delete Budget";
            tbDeleteBudget.UseVisualStyleBackColor = true;
            tbDeleteBudget.Click += tbDeleteBudget_Click;
            // 
            // bEditBudget
            // 
            bEditBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditBudget.FlatAppearance.BorderSize = 0;
            bEditBudget.FlatStyle = FlatStyle.Flat;
            bEditBudget.Location = new Point(631, 76);
            bEditBudget.Name = "bEditBudget";
            bEditBudget.Size = new Size(169, 44);
            bEditBudget.TabIndex = 8;
            bEditBudget.Text = "Edit Budget";
            bEditBudget.UseVisualStyleBackColor = true;
            bEditBudget.Click += bEditBudget_Click;
            // 
            // bAddBudget
            // 
            bAddBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddBudget.FlatAppearance.BorderSize = 0;
            bAddBudget.FlatStyle = FlatStyle.Flat;
            bAddBudget.Location = new Point(456, 76);
            bAddBudget.Name = "bAddBudget";
            bAddBudget.Size = new Size(169, 44);
            bAddBudget.TabIndex = 9;
            bAddBudget.TabStop = false;
            bAddBudget.Text = "Add Budget";
            bAddBudget.UseVisualStyleBackColor = true;
            bAddBudget.Click += bAddBudget_Click;
            // 
            // BudgetsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "BudgetsElement";
            Size = new Size(1044, 795);
            ThemedGroupBox.ResumeLayout(false);
            Budgets.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ThemedGroupBox Budgets;
        private Button btnDelete;
        private Button btnReset;
        private Button btnAddBudget;
        private ThemedButton tbDeleteBudget;
        private ThemedButton bAddBudget;
        private ThemedButton bEditBudget;
        private ListView lvBudgets;
    }
}
