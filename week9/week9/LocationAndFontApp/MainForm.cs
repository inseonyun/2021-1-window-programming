using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationAndFontApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lblHorse.Font = new Font("굴림", lblHorse.Font.Size + 1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lblHorse.Font = new Font("굴림", lblHorse.Font.Size - 1);
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(175, 120);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y - 1);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y + 1);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y);
        }

        private void btnLU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y - 1);
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y + 1);
        }

        private void btnRU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y - 1);
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y + 1);
        }
    }
}
