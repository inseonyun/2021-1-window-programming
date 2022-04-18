using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadWindowApp
{
    public partial class NotePadForm : Form
    {
        public NotePadForm()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text != "")
            {
                if (MessageBox.Show("텍스트가 남아있습니다. 저장하시겠습니까?", "NotePadApp", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                        txtEdit.Text = "파일이 저장되었습니다.";
                }
                else
                    txtEdit.Text = "";
            }
            
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                txtEdit.Text = openFileDialog1.FileName;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                txtEdit.Text = saveFileDialog1.FileName;
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                txtEdit.Text = "파일을 출력합니다.";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
                txtEdit.Font = fontDialog1.Font;
        }
    }
}
