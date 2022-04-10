using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeTemperature
{
    public partial class FrmChangTemperature : Form
    {
        public FrmChangTemperature()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double ct;
            double ft;

            ct = double.Parse(txtCTemperature.Text);
            ft = (ct * 9 / 5) + 32;
            txtFTemperature.Text = ft + "";
        }
    }
}
