using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace ExpenseTracker.Elements
{
    public partial class SettingsElement : Element {
        public SettingsElement(ElementView parentView) : base(parentView) {
            InitializeComponent();


        }

        public override void Init() {
            themeDropDown.Items.Clear();

            foreach (var theme in App.State.Themes) {
                themeDropDown.Items.Add(theme.Name);
            }

            themeDropDown.SelectedIndex = App.State.Themes.FindIndex(t => t.Name == App.State.CurrentTheme.Name);


        }

        private void themeDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            App.State.SetTheme(App.State.Themes[themeDropDown.SelectedIndex].Name);


        }
    }
}

