
namespace ChangeTemperature
{
    partial class FrmChangTemperature
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCTemperature = new System.Windows.Forms.TextBox();
            this.lblCTemperature = new System.Windows.Forms.Label();
            this.lblFTemperature = new System.Windows.Forms.Label();
            this.txtFTemperature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalc.Location = new System.Drawing.Point(103, 129);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "변환하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCTemperature
            // 
            this.txtCTemperature.Location = new System.Drawing.Point(103, 78);
            this.txtCTemperature.Name = "txtCTemperature";
            this.txtCTemperature.Size = new System.Drawing.Size(100, 21);
            this.txtCTemperature.TabIndex = 1;
            // 
            // lblCTemperature
            // 
            this.lblCTemperature.AutoSize = true;
            this.lblCTemperature.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCTemperature.Location = new System.Drawing.Point(26, 84);
            this.lblCTemperature.Name = "lblCTemperature";
            this.lblCTemperature.Size = new System.Drawing.Size(71, 15);
            this.lblCTemperature.TabIndex = 2;
            this.lblCTemperature.Text = "섭씨온도";
            // 
            // lblFTemperature
            // 
            this.lblFTemperature.AutoSize = true;
            this.lblFTemperature.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFTemperature.Location = new System.Drawing.Point(26, 199);
            this.lblFTemperature.Name = "lblFTemperature";
            this.lblFTemperature.Size = new System.Drawing.Size(71, 15);
            this.lblFTemperature.TabIndex = 3;
            this.lblFTemperature.Text = "화씨온도";
            // 
            // txtFTemperature
            // 
            this.txtFTemperature.Location = new System.Drawing.Point(103, 193);
            this.txtFTemperature.Name = "txtFTemperature";
            this.txtFTemperature.Size = new System.Drawing.Size(100, 21);
            this.txtFTemperature.TabIndex = 4;
            // 
            // FrmChangTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 295);
            this.Controls.Add(this.txtFTemperature);
            this.Controls.Add(this.lblFTemperature);
            this.Controls.Add(this.lblCTemperature);
            this.Controls.Add(this.txtCTemperature);
            this.Controls.Add(this.btnCalc);
            this.Name = "FrmChangTemperature";
            this.Text = "섭씨온도 화씨 온도 변환";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCTemperature;
        private System.Windows.Forms.Label lblCTemperature;
        private System.Windows.Forms.Label lblFTemperature;
        private System.Windows.Forms.TextBox txtFTemperature;
    }
}

