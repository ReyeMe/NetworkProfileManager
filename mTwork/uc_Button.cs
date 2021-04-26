using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mTwork {
    [DefaultEvent("Click")]
    public partial class uc_Button : UserControl {
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get { return label1.Text.Replace("\n", @"\n"); } set { label1.Text = value.Replace(@"\n", "\n"); } }

        public uc_Button()
        {
            InitializeComponent();
            label1_EnabledChanged(this, EventArgs.Empty);
        }

        private void label1_MouseDown( object sender, MouseEventArgs e )
        {
            if (Enabled) label1.BackColor = Color.FromArgb(175,175,175);
        }

        private void label1_MouseUp( object sender, MouseEventArgs e )
        {
            if (Enabled) label1.BackColor = Color.FromArgb(254, 253, 214);
        }

        private void label1_MouseLeave( object sender, EventArgs e )
        {
            if (Enabled) label1.BackColor = Color.FromArgb(254, 253, 214);
        }

        private void label1_Click( object sender, EventArgs e )
        {
            OnClick(e);
        }

        private void label1_EnabledChanged( object sender, EventArgs e )
        {
            label1.BackColor = (Enabled) ? Color.FromArgb(254, 253, 214) : Color.DimGray;
        }
    }
}
