
namespace TreeViewControlWindowApp
{
    partial class TreeViewMainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("C 프로그래밍");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Java Programming");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("자료구조");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("컴퓨터공학과", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("전자공학과");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("디지털콘텐츠학과");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("교과목", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48});
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.tvCourse = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNodeRemove = new System.Windows.Forms.Button();
            this.btnListRemove = new System.Windows.Forms.Button();
            this.lblAddNode = new System.Windows.Forms.Label();
            this.txtAddNode = new System.Windows.Forms.TextBox();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnFindNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.ItemHeight = 12;
            this.lstCourse.Location = new System.Drawing.Point(299, 36);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(196, 340);
            this.lstCourse.TabIndex = 0;
            // 
            // tvCourse
            // 
            this.tvCourse.Location = new System.Drawing.Point(12, 36);
            this.tvCourse.Name = "tvCourse";
            treeNode43.Name = "Cprogramming";
            treeNode43.Text = "C 프로그래밍";
            treeNode44.Name = "Java Programming";
            treeNode44.Text = "Java Programming";
            treeNode45.Name = "Data Structure";
            treeNode45.Text = "자료구조";
            treeNode46.Name = "computer";
            treeNode46.Text = "컴퓨터공학과";
            treeNode47.Name = "electronic";
            treeNode47.Text = "전자공학과";
            treeNode48.Name = "digital";
            treeNode48.Text = "디지털콘텐츠학과";
            treeNode49.Name = "root";
            treeNode49.Text = "교과목";
            this.tvCourse.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode49});
            this.tvCourse.Size = new System.Drawing.Size(191, 340);
            this.tvCourse.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNodeRemove
            // 
            this.btnNodeRemove.Location = new System.Drawing.Point(12, 382);
            this.btnNodeRemove.Name = "btnNodeRemove";
            this.btnNodeRemove.Size = new System.Drawing.Size(109, 23);
            this.btnNodeRemove.TabIndex = 3;
            this.btnNodeRemove.Text = "선택 노드 삭제";
            this.btnNodeRemove.UseVisualStyleBackColor = true;
            this.btnNodeRemove.Click += new System.EventHandler(this.btnNodeRemove_Click);
            // 
            // btnListRemove
            // 
            this.btnListRemove.Location = new System.Drawing.Point(299, 382);
            this.btnListRemove.Name = "btnListRemove";
            this.btnListRemove.Size = new System.Drawing.Size(75, 23);
            this.btnListRemove.TabIndex = 3;
            this.btnListRemove.Text = "선택 삭제";
            this.btnListRemove.UseVisualStyleBackColor = true;
            this.btnListRemove.Click += new System.EventHandler(this.btnListRemove_Click);
            // 
            // lblAddNode
            // 
            this.lblAddNode.AutoSize = true;
            this.lblAddNode.Location = new System.Drawing.Point(12, 418);
            this.lblAddNode.Name = "lblAddNode";
            this.lblAddNode.Size = new System.Drawing.Size(51, 12);
            this.lblAddNode.TabIndex = 4;
            this.lblAddNode.Text = "Node 명";
            // 
            // txtAddNode
            // 
            this.txtAddNode.Location = new System.Drawing.Point(12, 433);
            this.txtAddNode.Name = "txtAddNode";
            this.txtAddNode.Size = new System.Drawing.Size(100, 21);
            this.txtAddNode.TabIndex = 5;
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(12, 460);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 6;
            this.btnAddNode.Text = "노드 추가";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnFindNode
            // 
            this.btnFindNode.Location = new System.Drawing.Point(93, 460);
            this.btnFindNode.Name = "btnFindNode";
            this.btnFindNode.Size = new System.Drawing.Size(75, 23);
            this.btnFindNode.TabIndex = 6;
            this.btnFindNode.Text = "노드 검색";
            this.btnFindNode.UseVisualStyleBackColor = true;
            this.btnFindNode.Click += new System.EventHandler(this.btnFindNode_Click);
            // 
            // TreeViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 505);
            this.Controls.Add(this.btnFindNode);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.txtAddNode);
            this.Controls.Add(this.lblAddNode);
            this.Controls.Add(this.btnListRemove);
            this.Controls.Add(this.btnNodeRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tvCourse);
            this.Controls.Add(this.lstCourse);
            this.Name = "TreeViewMainForm";
            this.Text = "TreeViewControlExample";
            this.Load += new System.EventHandler(this.TreeViewMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.TreeView tvCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNodeRemove;
        private System.Windows.Forms.Button btnListRemove;
        private System.Windows.Forms.Label lblAddNode;
        private System.Windows.Forms.TextBox txtAddNode;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnFindNode;
    }
}

