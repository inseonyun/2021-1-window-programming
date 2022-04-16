using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SubForm sf = new SubForm();
            sf.Text = txtTitle.Text;
            sf.Location = new Point(int.Parse(txtX.Text), int.Parse(txtY.Text));
            sf.Size = new Size(int.Parse(txtWidth.Text), int.Parse(txtHeight.Text));
            sf.Opacity = double.Parse(txtOpacity.Text);

            if (rdoNone.Checked)
            {
                sf.FormBorderStyle = FormBorderStyle.None;
            } else if (rdoSingle.Checked) 
            {
                sf.FormBorderStyle = FormBorderStyle.FixedSingle;
            } else if (rdoWindow.Checked) 
            {
                sf.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            sf.Show();
            //sf.ShowDialog(); //이렇게 하면 이 폼을 닫아야 다른 폼을 선택할 수 있음
        }
    }
}
