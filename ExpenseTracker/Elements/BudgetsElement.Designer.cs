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
        private void InitializeComponent() {
            lvBudgets = new ListView();
            btnAddBudget = new ThemedButton();
            btnEditBudget = new ThemedButton();
            btnDeleteBudget = new ThemedButton();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ThemedGroupBox.BackgroundImageLayout = ImageLayout.Center;
            ThemedGroupBox.Controls.Add(btnDeleteBudget);
            ThemedGroupBox.Controls.Add(btnEditBudget);
            ThemedGroupBox.Controls.Add(btnAddBudget);
            ThemedGroupBox.Controls.Add(lvBudgets);
            ThemedGroupBox.Dock = DockStyle.Fill;
            ThemedGroupBox.Size = new Size(1206, 745);
            // 
            // lvBudgets
            // 
            lvBudgets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvBudgets.BackColor = SystemColors.WindowFrame;
            lvBudgets.ForeColor = Color.WhiteSmoke;
            lvBudgets.GridLines = true;
            lvBudgets.Location = new Point(25, 96);
            lvBudgets.Name = "lvBudgets";
            lvBudgets.Size = new Size(1159, 624);
            lvBudgets.TabIndex = 0;
            lvBudgets.UseCompatibleStateImageBehavior = false;
            lvBudgets.View = View.Details;
            // 
            // btnAddBudget
            // 
            btnAddBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBudget.FlatAppearance.BorderSize = 0;
            btnAddBudget.FlatStyle = FlatStyle.Flat;
            btnAddBudget.Location = new Point(673, 43);
            btnAddBudget.Name = "btnAddBudget";
            btnAddBudget.Size = new Size(173, 47);
            btnAddBudget.TabIndex = 1;
            btnAddBudget.Text = "Add Budget";
            btnAddBudget.UseVisualStyleBackColor = true;
            btnAddBudget.Click += btnAddBudget_Click;
            // 
            // btnEditBudget
            // 
            btnEditBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditBudget.FlatAppearance.BorderSize = 0;
            btnEditBudget.FlatStyle = FlatStyle.Flat;
            btnEditBudget.Location = new Point(852, 43);
            btnEditBudget.Name = "btnEditBudget";
            btnEditBudget.Size = new Size(155, 47);
            btnEditBudget.TabIndex = 2;
            btnEditBudget.Text = "Edit Budget";
            btnEditBudget.UseVisualStyleBackColor = true;
            btnEditBudget.Click += btnEditBudget_Click;
            // 
            // btnDeleteBudget
            // 
            btnDeleteBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteBudget.FlatAppearance.BorderSize = 0;
            btnDeleteBudget.FlatStyle = FlatStyle.Flat;
            btnDeleteBudget.Location = new Point(1013, 43);
            btnDeleteBudget.Name = "btnDeleteBudget";
            btnDeleteBudget.Size = new Size(171, 47);
            btnDeleteBudget.TabIndex = 3;
            btnDeleteBudget.Text = "Delete Budget";
            btnDeleteBudget.UseVisualStyleBackColor = true;
            btnDeleteBudget.Click += btnDeleteBudget_Click;
            // 
            // BudgetsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "BudgetsElement";
            Size = new Size(1216, 795);
            ThemedGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView lvBudgets;
        private ThemedButton btnDeleteBudget;
        private ThemedButton btnEditBudget;
        private ThemedButton btnAddBudget;
    }
}
