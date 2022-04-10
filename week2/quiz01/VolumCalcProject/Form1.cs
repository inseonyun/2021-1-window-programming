using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumCalcProject
{
    public partial class FrmVolumeCalc : Form
    {
        public FrmVolumeCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            int depth;
            int volume;

            width = int.Parse(txtWidth.Text);
            height = int.Parse(txtHeight.Text);
            depth = int.Parse(txtDepth.Text);

            volume = width * height * depth;

            txtVolume.Text = volume + ""; // 자동 형변환으로 txtVolume.Text에 문자열로 저장됨
            //Volume.Text = volume.ToString 도 가능
        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void FrmVolumeCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
