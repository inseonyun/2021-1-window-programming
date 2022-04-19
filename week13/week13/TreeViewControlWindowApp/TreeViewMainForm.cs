using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewControlWindowApp
{
    public partial class TreeViewMainForm : Form
    {
        public TreeViewMainForm()
        {
            InitializeComponent();
        }

        private void TreeViewMainForm_Load(object sender, EventArgs e)
        {
            tvCourse.ExpandAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstCourse.Items.Add(tvCourse.SelectedNode.Text);
        }

        private void btnNodeRemove_Click(object sender, EventArgs e)
        {
            if (tvCourse.SelectedNode.Nodes.Count == 0)
                tvCourse.Nodes.Remove(tvCourse.SelectedNode);
            else
                MessageBox.Show("자식노드가 있는 경우 삭제 불가");
        }

        private void btnListRemove_Click(object sender, EventArgs e)
        {
            if (lstCourse.SelectedIndex != -1)
                lstCourse.Items.Remove(lstCourse.SelectedItem);
            else
                MessageBox.Show("선택된 아이템 없음");
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (txtAddNode.Text != "")
                tvCourse.SelectedNode.Nodes.Add(txtAddNode.Text);
            else
                MessageBox.Show("입력된 노드명 없음");
        }

        private void btnFindNode_Click(object sender, EventArgs e)
        {
            TreeNode SelectedNode = SearchNode(txtAddNode.Text, tvCourse.Nodes[0]);
            if (SelectedNode != null)
            {
                this.tvCourse.SelectedNode = SelectedNode;
                this.tvCourse.SelectedNode.Expand(); //해당하는 노드가 있으면 노드 확장
                this.tvCourse.Select(); //해당하는 노드가 있으면 포커스 해줌
            } else
            {
                MessageBox.Show("해당하는 노드 없음"); //해당하는 노드가 없으면 메시지박스 나타냄
            }
        }

        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }
                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);//Recursive Search
                    if (node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }
    }
}
