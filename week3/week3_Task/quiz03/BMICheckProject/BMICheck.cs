using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICheckProject
{
    public partial class BMICheck : Form
    {
        public BMICheck()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double height, weight, standardWeight, bmi;
            String obesity;

            height = double.Parse(txtHeight.Text);
            weight = double.Parse(txtWeight.Text);

            standardWeight = (height - 100) * 0.9;
            bmi = (weight - standardWeight) / standardWeight * 100;

            if (bmi < 20)
                obesity = "정상";
            else if (bmi < 30)
                obesity = "경도비만";
            else if (bmi < 50)
                obesity = "중도비만";
            else
                obesity = "고도비만";

            txtStandardWeight.Text = standardWeight + "";
            txtBMI.Text = bmi.ToString();
            txtObesity.Text = obesity;
        }
    }
}
