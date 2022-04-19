
namespace ListViewControlWindowApp
{
    partial class ListViewMainForm
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
            this.lstInfo = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dmView = new System.Windows.Forms.DomainUpDown();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblSno = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTell = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chSno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInfo
            // 
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSno,
            this.chName,
            this.chAddress,
            this.chTel,
            this.chDept});
            this.lstInfo.FullRowSelect = true;
            this.lstInfo.HideSelection = false;
            this.lstInfo.Location = new System.Drawing.Point(12, 12);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(733, 104);
            this.lstInfo.TabIndex = 0;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 120);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "선택 삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(93, 120);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "선택 출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dmView
            // 
            this.dmView.Items.Add("Detail");
            this.dmView.Items.Add("LargeIcon");
            this.dmView.Items.Add("SmallIcon");
            this.dmView.Location = new System.Drawing.Point(344, 122);
            this.dmView.Name = "dmView";
            this.dmView.Size = new System.Drawing.Size(120, 21);
            this.dmView.TabIndex = 2;
            this.dmView.Text = "Detail";
            this.dmView.SelectedItemChanged += new System.EventHandler(this.dmView_SelectedItemChanged);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnAdd);
            this.grpInfo.Controls.Add(this.txtDept);
            this.grpInfo.Controls.Add(this.txtTel);
            this.grpInfo.Controls.Add(this.txtAddress);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.txtSno);
            this.grpInfo.Controls.Add(this.lblDept);
            this.grpInfo.Controls.Add(this.lblTell);
            this.grpInfo.Controls.Add(this.lblAddress);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.lblSno);
            this.grpInfo.Location = new System.Drawing.Point(12, 181);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(732, 273);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "학생 정보";
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.Location = new System.Drawing.Point(23, 32);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(29, 12);
            this.lblSno.TabIndex = 0;
            this.lblSno.Text = "학번";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 106);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "주소";
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Location = new System.Drawing.Point(23, 147);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(29, 12);
            this.lblTell.TabIndex = 0;
            this.lblTell.Text = "전화";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(23, 193);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(29, 12);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "학과";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(58, 29);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(192, 21);
            this.txtSno.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(58, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(464, 21);
            this.txtAddress.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(58, 147);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(303, 21);
            this.txtTel.TabIndex = 1;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(56, 190);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(217, 21);
            this.txtDept.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(332, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chSno
            // 
            this.chSno.Text = "학번";
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "주소";
            this.chAddress.Width = 300;
            // 
            // chTel
            // 
            this.chTel.Text = "전화";
            this.chTel.Width = 100;
            // 
            // chDept
            // 
            this.chDept.Text = "학과";
            this.chDept.Width = 150;
            // 
            // ListViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 481);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.dmView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstInfo);
            this.Name = "ListViewMainForm";
            this.Text = "Form1";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DomainUpDown dmView;
        private System.Windows.Forms.ColumnHeader chSno;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chDept;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSno;
    }
}

