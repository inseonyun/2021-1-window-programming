
namespace UserDialogApp
{
    partial class UserDialogForm
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
            this.btnUserDialog1 = new System.Windows.Forms.Button();
            this.btnUserDialog2 = new System.Windows.Forms.Button();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUserDialog1
            // 
            this.btnUserDialog1.Location = new System.Drawing.Point(27, 45);
            this.btnUserDialog1.Name = "btnUserDialog1";
            this.btnUserDialog1.Size = new System.Drawing.Size(159, 64);
            this.btnUserDialog1.TabIndex = 0;
            this.btnUserDialog1.Text = "대화상자로 값 전달";
            this.btnUserDialog1.UseVisualStyleBackColor = true;
            this.btnUserDialog1.Click += new System.EventHandler(this.btnUserDialog1_Click);
            // 
            // btnUserDialog2
            // 
            this.btnUserDialog2.Location = new System.Drawing.Point(27, 137);
            this.btnUserDialog2.Name = "btnUserDialog2";
            this.btnUserDialog2.Size = new System.Drawing.Size(159, 64);
            this.btnUserDialog2.TabIndex = 0;
            this.btnUserDialog2.Text = "대화상자로부터  값 전달";
            this.btnUserDialog2.UseVisualStyleBackColor = true;
            this.btnUserDialog2.Click += new System.EventHandler(this.btnUserDialog2_Click);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(192, 68);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(252, 21);
            this.txtParameter.TabIndex = 1;
            // 
            // UserDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 341);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.btnUserDialog2);
            this.Controls.Add(this.btnUserDialog1);
            this.Name = "UserDialogForm";
            this.Text = "사용자 정의 대화상자 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserDialog1;
        private System.Windows.Forms.Button btnUserDialog2;
        private System.Windows.Forms.TextBox txtParameter;
    }
}

