

using System.Runtime.CompilerServices;

namespace ExpenseTracker.Controls {



    public partial class ElementContainer : UserControl {


        ElementView? currentView = null;
        public ElementView? CurrentView { get { return currentView; } private set { currentView = value; } }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public ElementContainer() {
            InitializeComponent();


           

                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
                timer.Enabled = Enabled;
                timer.Tick += Timer_Tick;
                timer.Interval = 1;
                this.Paint += ElementContainer_Paint;
            

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


        /// <summary>
        /// sets and loads a new view into container
        /// </summary>
        public void SetView(ElementView view) {
            if (view == null)
                throw new ArgumentNullException(nameof(view));

            this.SuspendLayout(); // pause UI updates

            // hide current elems
            if (currentView != null) {
                foreach (var el in currentView.GetAllElements()) {
                    Controls.Remove(el);
                }
            }

            view.Build(); // or cache it if it's heavy
            currentView = view;

            foreach (var el in view.GetAllElements()) {
                Controls.Add(el);
            }

            this.ResumeLayout(true); // resume UI updates
            timer.Start();
        }

    }
}