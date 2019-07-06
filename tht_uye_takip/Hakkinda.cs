using System;
using System.Windows.Forms;

namespace tht_uye_takip
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(label2.Text);
        }
    }
}
