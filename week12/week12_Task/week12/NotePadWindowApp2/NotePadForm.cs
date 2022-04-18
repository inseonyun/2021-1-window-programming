using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadWindowApp2
{
    public partial class NotePadForm : Form
    {
        public NotePadForm()
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
        
        private void Align_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem it in item.Owner.Items)
            {
                if (it == item)
                {
                    it.Checked = true;  // 클릭한 메뉴만 checked를  true로
                    if (it.Tag == "Left")
                        txtOut.TextAlign = HorizontalAlignment.Left;
                    else if (it.Tag == "Center")
                        txtOut.TextAlign = HorizontalAlignment.Center;
                    else
                        txtOut.TextAlign = HorizontalAlignment.Right;
                }
                else
                {
                    it.Checked = false;  // 나머지 메뉴는 false로 변경
                }
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOut.Text);  //클립보드로 텍스트박스의 문자열 복사
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtOut.Text += Clipboard.GetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일저장메뉴선택", "ToolStripMenuItem_Click");
        }

        private void NotePadForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = "마우스 포인터 : " + e.X + "," + e.Y;
            }
        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            StatusStrip statusStrip1 = (StatusStrip)sender;
            MessageBox.Show(" statusStrip1_ItemClicked");
        }
    }
}
