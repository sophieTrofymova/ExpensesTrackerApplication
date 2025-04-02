using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpenseTracker.Controls {
    public partial class IconButton : Button {

        private string displayIconValue = "error";
        private float displayIconSize = 24f;

        [Category("_CustomParams")]
        [Description("Google Material font icon name.")]
        [Browsable(true)]

        public string DisplayIcon {
            get => displayIconValue;
            set {
                displayIconValue = value;
                this.Text = MaterialFont.GetIconByName(value);
                this.Invalidate();
            }
        }

        [Category("_CustomParams")]
        [Description("Google Material font size.")]
        [Browsable(true)]

        public float DisplayIconSize {
            get => displayIconSize;
            set {
                displayIconSize = value;
                this.Font = MaterialFont.GenerateFont(displayIconSize);
                this.Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text {
            get => base.Text;
            set => base.Text = value;
        }




        public IconButton() {
            this.Font = MaterialFont.GenerateFont(displayIconSize);
            this.Text = "\uE000";

            this.FlatStyle = FlatStyle.Flat;

            this.FlatAppearance.BorderSize = 0;
        }
    }
}
