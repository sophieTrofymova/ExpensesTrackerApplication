using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedTextBox : UserControl {

        private readonly TextBox _innerTextBox; // the actual textbox we use

        [Category("Appearance")]
        [Description("Padding between border and textbox content.")]
        public Padding InnerPadding {
            get => _innerPadding;
            set {
                _innerPadding = value;
                UpdateLayout();
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Thickness of the outer border.")]
        public int BorderThickness {
            get => _borderThickness;
            set {
                _borderThickness = Math.Max(1, value);
                Invalidate();
            }
        }

        private Padding _innerPadding = new Padding(4);
        private int _borderThickness = 1;

        public ThemedTextBox() {
            DoubleBuffered = true;
            ResizeRedraw = true;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _innerTextBox = new TextBox {
                BorderStyle = BorderStyle.None, // no native border we draw our own
                Multiline = false
            };

            this.Controls.Add(_innerTextBox);
            this.Padding = new Padding(0);

            _innerTextBox.TextChanged += (s, e) => Invalidate();
            _innerTextBox.GotFocus += (s, e) => Invalidate();
            _innerTextBox.LostFocus += (s, e) => Invalidate();
            _innerTextBox.KeyDown += (s, e) => Invalidate();
            _innerTextBox.FontChanged += (s, e) => UpdateLayout();
            _innerTextBox.BackColor = GetColor(ThemeColor.TextBoxBackColor);
            _innerTextBox.ForeColor = GetColor(ThemeColor.TextBoxForeColor);

            this.SizeChanged += (s, e) => UpdateLayout();

           
        }

        private void UpdateLayout() {
            _innerTextBox.Location = new Point(InnerPadding.Left, InnerPadding.Top);
            _innerTextBox.Size = new Size(
                this.Width - InnerPadding.Horizontal,
                this.Height - InnerPadding.Vertical
            );
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (e?.Graphics == null) return;

            var g = e.Graphics;

            var borderColor = GetColor(ThemeColor.TextBoxBorderColor);
            var backColor = GetColor(ThemeColor.TextBoxBackColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using var backBrush = new SolidBrush(backColor);
            g.FillRectangle(backBrush, this.ClientRectangle);

            using var borderPen = new Pen(borderColor, BorderThickness);
            g.DrawRectangle(borderPen, rect);

            var focused = _innerTextBox.Focused;
            if (focused) {
                var glowPen = new Pen(GetColor(ThemeColor.TextBoxFocusedBorderColor), BorderThickness + 1);
                g.DrawRectangle(glowPen, rect);
            }

        }

        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }


        // 👇 Expose text + common props as passthroughs
        [Browsable(true)]
        public override string Text {
            get => _innerTextBox.Text;
            set => _innerTextBox.Text = value;
        }

        public override Font Font {
            get => _innerTextBox.Font;
            set => _innerTextBox.Font = value;
        }

        public override Color ForeColor {
            get => _innerTextBox.ForeColor;
            set => _innerTextBox.ForeColor = value;
        }

        public override Color BackColor {
            get => base.BackColor;
            set {
                base.BackColor = value;
                _innerTextBox.BackColor = value;
            }
        }

        public bool UseSystemPasswordChar {
            get => _innerTextBox.UseSystemPasswordChar;
            set => _innerTextBox.UseSystemPasswordChar = value;
        }

        public CharacterCasing CharacterCasing {
            get => _innerTextBox.CharacterCasing;
            set => _innerTextBox.CharacterCasing = value;
        }

        public HorizontalAlignment TextAlign {
            get => _innerTextBox.TextAlign;
            set => _innerTextBox.TextAlign = value;
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get => _innerTextBox.AutoCompleteCustomSource;
            set => _innerTextBox.AutoCompleteCustomSource = value;
        }

        public AutoCompleteMode AutoCompleteMode {
            get => _innerTextBox.AutoCompleteMode;
            set => _innerTextBox.AutoCompleteMode = value;
        }

        public AutoCompleteSource AutoCompleteSource {
            get => _innerTextBox.AutoCompleteSource;
            set => _innerTextBox.AutoCompleteSource = value;
        }
    }
}
