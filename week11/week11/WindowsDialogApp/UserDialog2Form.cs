using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDialogApp
{
    public partial class UserDialog2Form : Form
    {
        private string parameter;
        
        public string Parameter
        {
            get
            {
                return parameter;
            }
            set
            {
                this.parameter = value;
            }
        }
        public UserDialog2Form()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Parameter = txtParameter.Text;
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Parameter = "";
            Close();
        }
    }
}
