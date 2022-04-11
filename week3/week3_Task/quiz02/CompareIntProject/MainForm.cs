using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareIntProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int i1, i2;

            i1 = int.Parse(txtInt1.Text);
            i2 = int.Parse(txtInt2.Text);

            if( i1 > i2)
            {
                lblResult.Text = i1 + " > " + i2;
            }
            else if( i1 < i2)
            {
                lblResult.Text = i1 + " < " + i2;
            }
            else
            {
                lblResult.Text = i1 + " = " + i2;
            }
        }
    }
}
