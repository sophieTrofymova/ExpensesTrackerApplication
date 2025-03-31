namespace ExpenseTracker {
    partial class NavBarButton {
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
            IconLabel = new Label();
            horizontalAlignPanel = new FlowLayoutPanel();
            TextLabel = new Label();
            horizontalAlignPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IconLabel
            // 
            IconLabel.AutoSize = true;
            IconLabel.BackColor = Color.Gainsboro;
            IconLabel.Font = new Font("Segoe UI", 14F);
            IconLabel.Location = new Point(10, 10);
            IconLabel.Margin = new Padding(5);
            IconLabel.Name = "IconLabel";
            IconLabel.Size = new Size(70, 32);
            IconLabel.TabIndex = 0;
            IconLabel.Text = "ICON";
            // 
            // horizontalAlignPanel
            // 
            horizontalAlignPanel.AutoSize = true;
            horizontalAlignPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            horizontalAlignPanel.BackColor = Color.White;
            horizontalAlignPanel.BorderStyle = BorderStyle.FixedSingle;
            horizontalAlignPanel.Controls.Add(IconLabel);
            horizontalAlignPanel.Controls.Add(TextLabel);
            horizontalAlignPanel.Location = new Point(0, 0);
            horizontalAlignPanel.Margin = new Padding(0);
            horizontalAlignPanel.Name = "horizontalAlignPanel";
            horizontalAlignPanel.Padding = new Padding(5);
            horizontalAlignPanel.Size = new Size(207, 54);
            horizontalAlignPanel.TabIndex = 1;
            horizontalAlignPanel.WrapContents = false;
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.BackColor = Color.Gainsboro;
            TextLabel.Font = new Font("Segoe UI", 14F);
            TextLabel.Location = new Point(90, 10);
            TextLabel.Margin = new Padding(5);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(105, 32);
            TextLabel.TabIndex = 1;
            TextLabel.Text = "BUTTON";
            // 
            // NavBarButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Red;
            Controls.Add(horizontalAlignPanel);
            Name = "NavBarButton";
            Size = new Size(207, 54);
            horizontalAlignPanel.ResumeLayout(false);
            horizontalAlignPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label IconLabel;
        private FlowLayoutPanel horizontalAlignPanel;
        public Label TextLabel;
    }
}
