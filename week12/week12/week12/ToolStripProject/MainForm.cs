using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStripProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일열기메뉴선택", "ToolStripMenuItem_Click");
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일저장메뉴선택", "ToolStripMenuItem_Click");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuLeft_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = true;
            mnuRight.Checked = false;
            mnuCenter.Checked = false;
            txtEdit.TextAlign = HorizontalAlignment.Left;
        }

        private void mnuCenter_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = false;
            mnuRight.Checked = false;
            mnuCenter.Checked = true;
            txtEdit.TextAlign = HorizontalAlignment.Center;
        }

        private void mnuRight_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = false;
            mnuRight.Checked = true;
            mnuCenter.Checked = false;
            txtEdit.TextAlign = HorizontalAlignment.Right;
        }
        private void mnuAlign_Clik(Object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            foreach(ToolStripMenuItem it in item.Owner.Items) {
                if (it == item)
                    it.Checked = true;
                else
                    it.Checked = false;
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEdit.Text);
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtEdit.Text += Clipboard.GetText();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            //statusStrip1.Items[0].Text = e.X + " " + e.Y;
            toolStripStatusLabel1.Text = e.X + " " + e.Y;
        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( " statusStrip1_ItemClicked");
        }
    }
}
