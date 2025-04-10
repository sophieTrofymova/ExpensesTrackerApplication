namespace ExpenseTracker {
    partial class DonutChartElement {
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
            ChartPanel = new Panel();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(ChartPanel);
            ThemedGroupBox.Margin = new Padding(5);
            ThemedGroupBox.Padding = new Padding(5);
            ThemedGroupBox.Size = new Size(412, 339);
            // 
            // ChartPanel
            // 
            ChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartPanel.Location = new Point(13, 45);
            ChartPanel.Margin = new Padding(5);
            ChartPanel.Name = "ChartPanel";
            ChartPanel.Padding = new Padding(5);
            ChartPanel.Size = new Size(386, 281);
            ChartPanel.TabIndex = 0;
            // 
            // DonutChartElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "DonutChartElement";
            Size = new Size(425, 392);
            ThemedGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ChartPanel;
    }
}
