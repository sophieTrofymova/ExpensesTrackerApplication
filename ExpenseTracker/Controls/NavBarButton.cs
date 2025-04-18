﻿

using ExpenseTracker.Storage;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Drawing.Design;

namespace ExpenseTracker.Controls {





    public partial class NavBarButton : UserControl {


        private Color _normalColor = Color.White;
        private Color _hoverColor = Color.FromArgb(238, 238, 238);
        private Color _downColor = Color.FromArgb(150, 150, 150);
        private Color _normalForeColor = Color.Black;
        private Color _activeForeColor = Color.Blue;
        private bool _mouseDown = false;
        private string displayIconValue = "error";

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
        public Color ActiveForeColor {
            get { return _activeForeColor; }
            set {
                _activeForeColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("_CustomParams"), Description("normal text color")]
        public Color NormalForeColor {
            get { return _normalForeColor; }
            set {
                _normalForeColor = value;
                if (TextLabel != null)
                    TextLabel.ForeColor = _normalForeColor;
                this.Invalidate();
            }
        }

        [Category("_CustomParams"), Description("The text displayed")]
        [Browsable(true)]
        public string DisplayLabel {
            get { return TextLabel.Text; }
            set { TextLabel.Text = value; }
        }

        [Category("_CustomParams"), Description("Adjust for alignment")]
        [Browsable(true)]
        public int MinIconWidth {
            get { return (IconLabel.MinimumSize.Width == 0) ? IconLabel.Size.Width : IconLabel.MinimumSize.Width; }
            set { IconLabel.MinimumSize = new Size((value >= 64) ? value : 64, IconLabel.Height); }
        }

        [Category("_CustomParams")]
        [Description("Icon code in hex (e.g., e000).")]
        [Browsable(true)]
        public string DisplayIcon {
            get {
                return displayIconValue;
            }
            set {

                IconLabel.Text = MaterialFont.GetIconByName(value);
                displayIconValue = value;
                this.Invalidate();

            }
        }

        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }




        public NavBarButton() {
            InitializeComponent();

            // forward child events
            IconLabel.MouseEnter += (s, e) => OnMouseEnter(e);
            IconLabel.MouseLeave += (s, e) => OnMouseLeave(e);
            IconLabel.MouseDown += (s, e) => OnMouseDown(e);
            IconLabel.MouseUp += (s, e) => OnMouseUp(e);

            TextLabel.MouseEnter += (s, e) => OnMouseEnter(e);
            TextLabel.MouseLeave += (s, e) => OnMouseLeave(e);
            TextLabel.MouseDown += (s, e) => OnMouseDown(e);
            TextLabel.MouseUp += (s, e) => OnMouseUp(e);

            horizontalAlignPanel.MouseEnter += (s, e) => OnMouseEnter(e);
            horizontalAlignPanel.MouseLeave += (s, e) => OnMouseLeave(e);
            horizontalAlignPanel.MouseDown += (s, e) => OnMouseDown(e);
            horizontalAlignPanel.MouseUp += (s, e) => OnMouseUp(e);

            horizontalAlignPanel.Dock = DockStyle.Fill;

            // wire up events on self
            this.MouseEnter += TextButton_MouseEnter;
            this.MouseLeave += TextButton_MouseLeave;
            this.MouseDown += TextButton_MouseDown;
            this.MouseUp += TextButton_MouseUp;

            this.Margin = new Padding(0);
            this.Load += NavBarButton_Load;

            this.BackColorChanged += NavBarButton_BackColorChanged;


            this.IconLabel.Font = MaterialFont.GenerateFont(24);
            this.IconLabel.Text = "\u0000";

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            this.ParentChanged += NavBarButton_ParentChanged;




        }

        private void NavBarButton_ParentChanged(object? sender, EventArgs e) {
            if (this.Parent != null) {
                this.Parent.SizeChanged += Parent_SizeChanged;

            }
        }

        private void Parent_SizeChanged(object? sender, EventArgs e) {
            if (this.Parent != null) {

                horizontalAlignPanel.MinimumSize =
                    new Size(
                        this.Parent.Size.Width -
                        this.Parent.Padding.Horizontal -
                        (((Parent as NavBar).VerticalScroll.Visible) ? 24 : 0),
                        horizontalAlignPanel.Height
                    );
                horizontalAlignPanel.Size =
                    new Size(
                        this.Parent.Size.Width -
                        this.Parent.Padding.Horizontal -
                        (((Parent as NavBar).VerticalScroll.Visible) ? 24 : 0),
                        horizontalAlignPanel.Height
                    );
            }
        }



        private void NavBarButton_BackColorChanged(object? sender, EventArgs e) {
            IconLabel.BackColor = this.NormalColor;
            TextLabel.BackColor = this.NormalColor;
            horizontalAlignPanel.BackColor = this.NormalColor;
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
            if (TextLabel != null) {
                IconLabel.ForeColor = c;
                TextLabel.ForeColor = c;
            }
        }

    }
}
