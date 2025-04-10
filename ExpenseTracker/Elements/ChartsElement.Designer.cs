namespace ExpenseTracker.Elements {
    partial class BarChartElement {
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
            panel1 = new Panel();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(panel1);
            ThemedGroupBox.Size = new Size(690, 488);
            ThemedGroupBox.Text = "Example Chart";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(21, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 425);
            panel1.TabIndex = 0;
            // 
            // ChartsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "ChartsElement";
            Size = new Size(700, 538);
            Title = "Example Chart";
            ThemedGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
    }
}
