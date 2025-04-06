

namespace ExpenseTracker.Controls {



    public partial class ElementContainer : UserControl {


        ElementView? currentView = null;
        public ElementView? CurrentView { get { return currentView; } private set { currentView = value; } }


        public ElementContainer() {
            InitializeComponent();
            
        }


        /// <summary>
        /// sets and loads a new view into container
        /// </summary>
        public void SetView(ElementView view) {
            if (view == null)
                throw new ArgumentNullException(nameof(view));

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
        }

    }
}