using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExpenseTracker.Controls {
    [DesignerCategory("code")]
    public class NavBar : FlowLayoutPanel {
        // event fired when a child button is clicked
        public event EventHandler<NavBarButtonClickEventArgs> ButtonClicked;

        // custom buttons collection
        private NavBarButtonCollection _buttons;

        [Browsable(true)]
        [Category("_CustomParams")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Collection of TextButtons used as nav items.")]
        [RefreshProperties(RefreshProperties.All)]
        public NavBarButtonCollection Buttons {
            get {
                // lazy init
                if (_buttons == null)
                    _buttons = new NavBarButtonCollection(this);
                return _buttons;
            }
        }



        // constructor
        public NavBar() {
            // set a default size so it's not invisible
            this.Size = new Size(150, 150);
            this.MinimumSize = new Size(50, 50);
            // typical vertical layout
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoScroll = true;
            this.BackColor = Color.WhiteSmoke;

        }

        // add single button to NavBar and wire up
        internal void AddNavButton(NavBarButton btn) {
            if (btn == null) return;

            // remove if already in Controls (avoid duplicates)
            if (this.Controls.Contains(btn))
                this.Controls.Remove(btn);

            // wire up mouse up event to identify clicked
            btn.MouseUp += (s, e) => {
                if (e.Button == MouseButtons.Left)
                    OnButtonClicked(btn);
            };

            this.Controls.Add(btn);

      
        }

        protected virtual void OnButtonClicked(NavBarButton btn) {
            // if you want only one active, unselect others
            foreach (Control c in this.Controls) {
                if (c is NavBarButton otherBtn && otherBtn != btn) {
                    otherBtn.IsActive = false;
                    otherBtn.BackColor = otherBtn.NormalColor;
                    otherBtn.SetForeColor(otherBtn.NormalForeColor);
                }
            }

            // set the clicked one
            btn.IsActive = true;
            btn.BackColor = Color.FromArgb(230, 230, 230); // highlight
            btn.SetForeColor(btn.ActiveForeColor);

            // find index
            int index = -1;
            if (_buttons != null) {
                index = _buttons.IndexOf(btn);
            }
            var args = new NavBarButtonClickEventArgs(btn, index);
            ButtonClicked?.Invoke(this, args);
        }
    }
}
