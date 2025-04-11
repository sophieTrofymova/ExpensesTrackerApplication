

using System.ComponentModel;
using System.Runtime.CompilerServices;
using ExpenseTracker.Elements;
using ExpenseTracker.Storage;
using static ExpenseTracker.Elements.ElementView;

namespace ExpenseTracker.Controls
{



    public partial class ElementContainer : UserControl {


        ElementView? currentView = null;
        public ElementView? CurrentView { get { return currentView; } private set { currentView = value; } }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private bool _lockView = false;

        public bool IsViewLocked { get { return _lockView; }  }

        public delegate void ViewChangedEventHandler(object sender, ElementView ev);

        public event ViewChangedEventHandler? ViewChanged;
        public event ViewChangedEventHandler? ViewLocked;
        public event ViewChangedEventHandler? ViewUnlocked;

        public ElementContainer() {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            timer.Enabled = Enabled;
            timer.Tick += Timer_Tick;
            timer.Interval = 1;
            this.Paint += ElementContainer_Paint;

            this.BackColor = GetColor(ThemeColor.ViewBackColor);
        }

        private void Timer_Tick(object? sender, EventArgs e) {
            this.Invalidate();
        }

        private void ElementContainer_Paint(object? sender, PaintEventArgs e) {
            var g = e.Graphics;
            if (currentView != null) {

                g.DrawRectangle(Pens.Blue, new Rectangle(currentView.Padding.Left, currentView.Padding.Top, this.Width - currentView.Padding.Horizontal, this.Height - currentView.Padding.Vertical));
                for (int r = 1; r < currentView.NumRows; r++) {
                    g.DrawLine(Pens.Red,
                        new Point(
                            currentView.Padding.Left,
                            currentView.Padding.Top + r * (currentView.DesiredSize.Height / currentView.NumRows)),
                        new Point(
                            currentView.Padding.Left + currentView.DesiredSize.Width - currentView.Padding.Horizontal,
                            currentView.Padding.Top + r * (currentView.DesiredSize.Height / currentView.NumRows)));
                }

                for (int c = 1; c < currentView.NumCols; c++) {
                    g.DrawLine(Pens.Red,
                        new Point(
                            currentView.Padding.Left + c * (currentView.DesiredSize.Width / currentView.NumCols),
                            currentView.Padding.Top),
                        new Point(
                            currentView.Padding.Left + c * (currentView.DesiredSize.Width / currentView.NumCols),
                            currentView.Padding.Top + currentView.DesiredSize.Height - currentView.Padding.Vertical));
                }
            }
        }


        public void LockView() {
            _lockView = true;
            ViewLocked?.Invoke(this, currentView);  
        }

        public void UnlockView() {
            _lockView = false;
            ViewUnlocked?.Invoke(this, currentView);
        }
        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }




        /// <summary>
        /// sets and loads a new view into container
        /// </summary>
        // in ElementContainer class:
        private ScreenChangedEventHandler? _screenChangedHandler;

        public void SetView(ElementView view, string screenKey = "default") {
            if (_lockView || view == null)
                return;

            this.SuspendLayout();

            if (currentView != null) {
                if (_screenChangedHandler != null)
                    currentView.ScreenChanged -= _screenChangedHandler;

                foreach (var el in currentView.Elements) {
                    Controls.Remove(el);
                }
            }

            view.SwitchScreen(screenKey); // 💥 actually use the parameter

            currentView = view;

            foreach (var el in view.Elements) {
                Controls.Add(el);
            }

            _screenChangedHandler = (sender, _) => UpdateView();
            currentView.ScreenChanged += _screenChangedHandler;

            this.ResumeLayout(true);
            timer.Start();

            ViewChanged?.Invoke(this, currentView);
        }





        public void UpdateView() {

            if (currentView == null)
                throw new ArgumentNullException(nameof(currentView));

            if (_lockView) {
                return;
            }

            this.SuspendLayout(); // pause UI updates

            Controls.Clear();
            Controls.AddRange(currentView.Elements.ToArray());

            this.ResumeLayout(true); // resume UI updates
            timer.Start();
        }


    }
}