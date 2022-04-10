using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeNSuperficialCalc
{
    public partial class FrmVolumNSuperficialCalc : Form
    {
        public FrmVolumNSuperficialCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double radius;
            double volume;
            double superficial;

            radius = double.Parse(txtRadius.Text);
            volume = ((radius * radius * radius) * 3.14 * 4) / 3;
            superficial = radius * radius * 4 * 3.14;

            txtVolume.Text = volume + "";
            txtSuperficial.Text = superficial + "";
        }
    }
}
