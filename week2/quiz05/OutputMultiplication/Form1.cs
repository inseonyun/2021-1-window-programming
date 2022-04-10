using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputMultiplication
{
    public partial class FrmMultiplication : Form
    {
        public FrmMultiplication()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int multplication;
            
            multplication = int.Parse(txtMultiplication.Text);
            
            for(int i = 1; i < 10; i++)
            {
                txtResult.Text += multplication + " * " + i + " = " + multplication * i + Environment.NewLine;
            }
        }
    }
}
