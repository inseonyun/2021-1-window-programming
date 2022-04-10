using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputDayOfMonth
{
    public partial class FrmOutputDayOfMonth : Form
    {
        public FrmOutputDayOfMonth()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int month;

            month = int.Parse(txtMonth.Text);

            switch(month)
            {
                case 1:
                    txtDay.Text = "31";
                    break;
                case 2:
                    txtDay.Text = "28";
                    break;
                case 3:
                    txtDay.Text = "31";
                    break;
                case 4:
                    txtDay.Text = "30";
                    break;
                case 5:
                    txtDay.Text = "31";
                    break;
                case 6:
                    txtDay.Text = "30";
                    break;
                case 7:
                    txtDay.Text = "31";
                    break;
                case 8:
                    txtDay.Text = "31";
                    break;
                case 9:
                    txtDay.Text = "30";
                    break;
                case 10:
                    txtDay.Text = "31";
                    break;
                case 11:
                    txtDay.Text = "30";
                    break;
                case 12:
                    txtDay.Text = "31";
                    break;
            }
        }
    }
}
