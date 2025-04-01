

using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Drawing.Design;

namespace ExpenseTracker {





    public partial class IconButton : UserControl {


        private Color _normalColor = Color.White;
        private Color _hoverColor = Color.FromArgb(238, 238, 238);
        private Color _downColor = Color.FromArgb(150, 150, 150);
        private Color _normalForeColor = Color.Black;
        private bool _mouseDown = false;
        private string displayIconValue = "e000";

        [Browsable(true)]
        [Category("_CustomParams"), Description("is btn in toggled/active state?")]
        public bool IsActive { get; set; }

        [Browsable(true)]
        [Category("_CustomParams"), Description("bg color used when mouse hover")]
        public Color HoverColor {
            get { return _hoverColor; }
            set {
                _hoverColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("_CustomParams"), Description("normal bg color.")]
        public Color NormalColor {
            get { return _normalColor; }
            set {
                _normalColor = value;
                this.BackColor = _normalColor;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("_CustomParams"), Description("bg color used when mouse is pressed")]
        public Color DownColor {
            get { return _downColor; }
            set {
                _downColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("_CustomParams"), Description("text color used when btn is active")]
        public Color ActiveForeColor { get; set; } = Color.FromArgb(33, 150, 243);

        [Browsable(true)]
        [Category("_CustomParams"), Description("normal text color")]
        public Color NormalForeColor {
            get { return _normalForeColor; }
            set {
                _normalForeColor = value;
                this.Invalidate();
            }
        }


        [Category("_CustomParams"), Description("Adjust for alignment")]
        [Browsable(true)]
        public int IconSize {
            get { return (int)this.IconLabel.Font.Size; }
            set { this.IconLabel.Font = Static.GetMaterialFont((value >= 12) ? value : 12); }
        }

        [Category("_CustomParams")]
        [Description("Icon code in hex (e.g., e000).")]
        [Browsable(true)]
        public string DisplayIcon {
            get {
                return displayIconValue;
            }
            set {
                if (GetIcon(value, out string icon)) {
                    IconLabel.Text = icon;
                    displayIconValue = value;
                    this.Invalidate();
                }
            }
        }


        public IconButton() {
            InitializeComponent();

            // forward child events
            IconLabel.MouseEnter += (s, e) => OnMouseEnter(e);
            IconLabel.MouseLeave += (s, e) => OnMouseLeave(e);
            IconLabel.MouseDown += (s, e) => OnMouseDown(e);
            IconLabel.MouseUp += (s, e) => OnMouseUp(e);

            horizontalAlignPanel.MouseEnter += (s, e) => OnMouseEnter(e);
            horizontalAlignPanel.MouseLeave += (s, e) => OnMouseLeave(e);
            horizontalAlignPanel.MouseDown += (s, e) => OnMouseDown(e);
            horizontalAlignPanel.MouseUp += (s, e) => OnMouseUp(e);



            IconLabel.Click += (s, e) => OnClick(e);
            horizontalAlignPanel.Click += (s, e) => OnClick(e);


            horizontalAlignPanel.Dock = DockStyle.Fill;

            // wire up events on self
            this.MouseEnter += TextButton_MouseEnter;
            this.MouseLeave += TextButton_MouseLeave;
            this.MouseDown += TextButton_MouseDown;
            this.MouseUp += TextButton_MouseUp;

            this.Margin = new Padding(0);
            this.Load += NavBarButton_Load;

            this.BackColorChanged += NavBarButton_BackColorChanged;


            this.IconLabel.Font = Static.GetMaterialFont(24);
            this.IconLabel.Text = "\u0000";

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BorderStyle = BorderStyle.FixedSingle;

        }





        private bool GetIcon(string codepoint, out string result) {
            if (int.TryParse(codepoint, System.Globalization.NumberStyles.HexNumber, null, out int code)) {
                result = char.ConvertFromUtf32(code);
                return true;
            }
            else {
                result = "\u0000";
                return false;
            }
        }

        private void NavBarButton_BackColorChanged(object? sender, EventArgs e) {
            IconLabel.BackColor = this.BackColor;

            horizontalAlignPanel.BackColor = this.BackColor;
        }




        private void NavBarButton_Load(object? sender, EventArgs e) {

        }

        private void TextButton_MouseEnter(object sender, EventArgs e) {
            if (!_mouseDown && !IsActive)
                this.BackColor = HoverColor;
        }

        private void TextButton_MouseLeave(object sender, EventArgs e) {
            if (!IsActive) {
                this.BackColor = NormalColor;
                _mouseDown = false;
            }
        }

        private void TextButton_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                _mouseDown = true;
                this.BackColor = DownColor;
            }
        }

        private void TextButton_MouseUp(object sender, MouseEventArgs e) {
            _mouseDown = false;
            // Let NavBar handle "activating" 
            // we do partial highlight if still inside
            if (this.ClientRectangle.Contains(PointToClient(Cursor.Position))) {
                if (!IsActive) this.BackColor = HoverColor;
            }
            else {
                if (!IsActive) this.BackColor = NormalColor;
            }
        }
        public void SetForeColor(Color c) {
            IconLabel.ForeColor = c;
        }

    }
}
