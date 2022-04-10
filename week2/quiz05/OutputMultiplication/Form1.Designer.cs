
namespace OutputMultiplication
{
    partial class FrmMultiplication
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
            this.txtMultiplication = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.lblMultiplicationTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMultiplication
            // 
            this.txtMultiplication.Location = new System.Drawing.Point(74, 35);
            this.txtMultiplication.Name = "txtMultiplication";
            this.txtMultiplication.Size = new System.Drawing.Size(100, 21);
            this.txtMultiplication.TabIndex = 0;
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutput.Location = new System.Drawing.Point(81, 78);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(89, 25);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "출력하기";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 148);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(226, 241);
            this.txtResult.TabIndex = 2;
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMultiplication.Location = new System.Drawing.Point(51, 38);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(23, 15);
            this.lblMultiplication.TabIndex = 3;
            this.lblMultiplication.Text = "단";
            // 
            // lblMultiplicationTable
            // 
            this.lblMultiplicationTable.AutoSize = true;
            this.lblMultiplicationTable.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMultiplicationTable.Location = new System.Drawing.Point(12, 130);
            this.lblMultiplicationTable.Name = "lblMultiplicationTable";
            this.lblMultiplicationTable.Size = new System.Drawing.Size(93, 15);
            this.lblMultiplicationTable.TabIndex = 4;
            this.lblMultiplicationTable.Text = "구구단 출력";
            // 
            // FrmMultiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 401);
            this.Controls.Add(this.lblMultiplicationTable);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtMultiplication);
            this.Name = "FrmMultiplication";
            this.Text = "구구단 출력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMultiplication;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.Label lblMultiplicationTable;
    }
}

