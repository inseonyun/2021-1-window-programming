using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdControlWindowApp
{
    public partial class AdControlMainForm : Form
    {
        public AdControlMainForm()
        {
            InitializeComponent();
        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {
            tbValue.Value = (int)nUpDown.Value;
            progress.Maximum = (int)nUpDown.Value;
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            nUpDown.Value = tbValue.Value;
            progress.Maximum = tbValue.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress.Value < progress.Maximum)
                progress.Value += 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
