namespace ExpenseTracker {
    public partial class ButtonLabel : Label {
        public bool IsActive { get; set; }
        public Color HoverColor { get; set; } = Color.FromArgb(238, 238, 238);
        public Color NormalColor { get; set; } = Color.Transparent;
        public Color DownColor { get; set; } = Color.FromArgb(150,150,150);
        public Color ActiveForeColor { get; set; } = Color.FromArgb(33, 150, 243);
        public Color NormalForeColor { get; set; } = Color.Black;

        private bool _mouseDown = false;

        public ButtonLabel() {
            this.Cursor = Cursors.Hand;
            this.BackColor = NormalColor;
            this.ForeColor = NormalForeColor;

            // wire up events
            this.MouseEnter += ButtonLabel_MouseEnter;
            this.MouseLeave += ButtonLabel_MouseLeave;
            this.MouseDown += ButtonLabel_MouseDown;
            this.MouseUp += ButtonLabel_MouseUp;
 
        }

        private void Parent_MouseUp(object? sender, MouseEventArgs e) {
            this.IsActive = false;

            this.ForeColor = (this.IsActive) ? ActiveForeColor : NormalForeColor;

        }

        private void ButtonLabel_MouseEnter(object sender, EventArgs e) {
            if (!_mouseDown)
                this.BackColor = HoverColor;
        }

        private void ButtonLabel_MouseLeave(object sender, EventArgs e) {
            this.BackColor = NormalColor;
            _mouseDown = false;
        }

        private void ButtonLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                _mouseDown = true;
                this.BackColor = DownColor;
            }
        }

        private void ButtonLabel_MouseUp(object sender, MouseEventArgs e) {
            _mouseDown = false;

            if(this.ClientRectangle.Contains(PointToClient(Cursor.Position))) {
                this.BackColor =  HoverColor;
                this.IsActive = true;
            } else {
                this.BackColor =  NormalColor;
                this.IsActive = false;
            }


            this.ForeColor = (this.IsActive)?ActiveForeColor: NormalForeColor;




        }
    }

}
