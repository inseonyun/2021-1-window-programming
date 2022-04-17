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
    public partial class DialogMainForm : Form
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

        public DialogMainForm()
        {
            InitializeComponent();
        }

        private void btnDefaultDialog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보를 확인시켜주기 위한 대화상자", "기본 대화상자", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOkCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = MessageBox.Show("사용자로부터 OK Cancel을 확인하기 위한 대화상자", "OK,Cancel 대화상자", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) + "";
        }

        private void btnYesNo_Click(object sender, EventArgs e)
        {
            txtResult.Text = MessageBox.Show("사용자로부터 Yes, No, Cancel을 확인하기 위한 대화상자", "Yes, No, Cancel 대화상자", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) + "";
        }

        private void btnARI_Click(object sender, EventArgs e)
        {
            txtResult.Text = MessageBox.Show("사용자로부터 Aboart, Retry, Ignore를 결정하기 위한 대화상자", "Aboart, Retry, Ignore 대화상자", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) + "";
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            btnColorDialog.BackColor = c.Color;
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog d = new FontDialog();
            d.ShowDialog();
            btnFontDialog.Font = d.Font;
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            txtResult.Text = of.FileName;
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            txtResult.Text = fb.SelectedPath;
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            PrintDialog p = new PrintDialog();
            p.ShowDialog();
            txtResult.Text = p.PrinterSettings + "";
        }

        private void btnUserDialog1_Click(object sender, EventArgs e)
        {
            parameter = txtParameter.Text;

            UserDialog1Form uDialog1 = new UserDialog1Form();
            uDialog1.Parameter = parameter;
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
