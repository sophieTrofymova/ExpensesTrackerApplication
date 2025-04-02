using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace ExpenseTracker.Controls {
    // custom typed collection
    public class NavBarButtonCollection : Collection<NavBarButton> {
        private NavBar _owner;

        public NavBarButtonCollection(NavBar owner) {
            _owner = owner;
        }

        protected override void InsertItem(int index, NavBarButton item) {
            base.InsertItem(index, item);
            _owner.AddNavButton(item);
        }

        protected override void RemoveItem(int index) {
            var item = this[index];
            base.RemoveItem(index);
            if (_owner.Controls.Contains(item)) {
                _owner.Controls.Remove(item);
            }
        }

        protected override void SetItem(int index, NavBarButton item) {
            var oldItem = this[index];
            if (_owner.Controls.Contains(oldItem))
                _owner.Controls.Remove(oldItem);

            base.SetItem(index, item);

            _owner.AddNavButton(item);
        }

        protected override void ClearItems() {
            foreach (var b in this) {
                if (_owner.Controls.Contains(b))
                    _owner.Controls.Remove(b);
            }
            base.ClearItems();
        }
    }
}
