using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointIndexerWindowApp
{
    public partial class PointIndexerForm : Form
    {
        Point p = null;
        PointArray parr = null;

        public PointIndexerForm()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            int x;
            int y;

            x = Convert.ToInt32(txtX.Text);
            y = Convert.ToInt32(txtY.Text);

            p = new Point(x, y);
            parr = new PointArray();

            parr[0] = p;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtResult.Text = parr[0].ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MyDelegate myd = new MyDelegate(parr[0].MoveTo);
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            myd(x, y);
            txtResult.Text = parr[0].ToString();

            /*
            myd -= new MyDelegate(parr[0].MoveTo);
            myd += new MyDelegate(parr[0].MoveBy);
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);
            myd(x, y);
            txtResult.Text = parr[0].ToString();
            */

        }
    }
}
