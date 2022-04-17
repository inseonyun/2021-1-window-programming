using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDialogApp
{
    public partial class UserDialogForm : Form
    {
        public UserDialogForm()
        {
            InitializeComponent();
        }

        private void btnUserDialog1_Click(object sender, EventArgs e)
        {
            UserDialog1Form uDialog1 = new UserDialog1Form();
            uDialog1.Parameter = txtParameter.Text;
            uDialog1.ShowDialog();
        }

        private void btnUserDialog2_Click(object sender, EventArgs e)
        {
            UserDialog2Form uDialog2 = new UserDialog2Form();
            uDialog2.ShowDialog();

            txtParameter.Text = uDialog2.Parameter;

        }
    }
}
