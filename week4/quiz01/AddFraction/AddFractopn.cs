using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddFraction
{
    public partial class AddFractopn : Form
    {
        Fraction f = null;

        public AddFractopn()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            f = new Fraction(int.Parse(txtNumerator1.Text), Convert.ToInt32(txtDenominator1.Text), Convert.ToInt32(txtNumerator2.Text), int.Parse(txtDenominator2.Text));
            f.AddFraction();
            txtNumerator3.Text = f.GetNumerator3() + "";
            txtDenominator3.Text = f.GetDenominator3() + "";
        }
    }
}
