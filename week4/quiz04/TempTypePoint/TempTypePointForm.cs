using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempTypePoint
{
    public partial class TempTypePointForm : Form
    {
        public TempTypePointForm()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(txtX.Text, out i))
            {
                int x = i;
                int y = int.Parse(txtY.Text);
                Point<int> p1 = new Point<int>(x, y);
                txtPrint.Text = p1.ToString();
                txtType.Text = "정수";
            }
            else
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                Point<double> p1 = new Point<double>(x, y);
                txtPrint.Text = p1.ToString();
                txtType.Text = "실수";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtX.Text, out i))
            {
                int x = i;
                int y = int.Parse(txtY.Text);
                Point<int> p1 = new Point<int>(x, y);
                txtPrint.Text = p1.ToString();
                txtType.Text = "정수";
            }
            else
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                Point<double> p1 = new Point<double>(x, y);
                txtPrint.Text = p1.ToString();
                txtType.Text = "실수";
            }
            
        }
    }
}
