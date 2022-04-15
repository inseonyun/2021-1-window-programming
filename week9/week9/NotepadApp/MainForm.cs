using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad V 0.1");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( txtMemo.Text != "" )
            {
                //MessageBox.Show에서 첫번째 인수는 내용, 두번쨰는 박스의 제목, 세번째는 버튼
                if (MessageBox.Show("텍스트 박스에 내용이 있습니다. 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Yes가 눌리면 캔슬하지 않고 폼을 종료함
                    e.Cancel = false;
                }//No가 눌리면 캔슬되고 폼을 종료하지 않음
                else
                    e.Cancel = true;
            }
        }
    }
}
