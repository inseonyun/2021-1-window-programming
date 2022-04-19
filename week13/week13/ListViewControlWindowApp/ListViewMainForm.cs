using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewControlWindowApp
{
    public partial class ListViewMainForm : Form
    {
        public ListViewMainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 아래와 같이 각각의 변수 생성 하는 법과 배열을 만들어 하는 법이 있다.
            /* 
            ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub4 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub5 = new ListViewItem.ListViewSubItem();
            */
            ListViewItem.ListViewSubItem []sub = new ListViewItem.ListViewSubItem[5];
            for(int i = 0; i< 5; i++)
            {
                sub[i] = new ListViewItem.ListViewSubItem();
            }
            //sub1.Text = txtSno.Text;
            sub[1].Text = txtName.Text;
            sub[2].Text = txtAddress.Text;
            sub[3].Text = txtTel.Text;
            sub[4].Text = txtDept.Text;

            ListViewItem lvitem = new ListViewItem();
            //.SubItems.Add(sub1);
            lvitem.Text = txtSno.Text;
            lvitem.SubItems.Add(sub[1]);
            lvitem.SubItems.Add(sub[2]);
            lvitem.SubItems.Add(sub[3]);
            lvitem.SubItems.Add(sub[4]);

            lstInfo.Items.Add(lvitem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstInfo.SelectedItems.Count != 0)
            {
                //다중 선택이 가능하기 때문에 하나만 선택하여 삭제하기 위해 인덱스 0을 입력함
                lstInfo.SelectedItems[0].Remove();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(lstInfo.SelectedItems.Count != 0)
            {
                //txtSno.Text = lstInfo.SelectedItems[0].Text;
                txtSno.Text = lstInfo.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lstInfo.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = lstInfo.SelectedItems[0].SubItems[2].Text;
                txtTel.Text = lstInfo.SelectedItems[0].SubItems[3].Text;
                txtDept.Text = lstInfo.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void dmView_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dmView.Text == "Detail")
                lstInfo.View = View.Details;
            else if (dmView.Text == "LargeIcon")
                lstInfo.View = View.LargeIcon;
            else
                lstInfo.View = View.SmallIcon;
        }
    }
}
