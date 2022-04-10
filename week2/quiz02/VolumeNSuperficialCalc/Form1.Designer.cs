
namespace VolumeNSuperficialCalc
{
    partial class FrmVolumNSuperficialCalc
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtSuperficial = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSuperficial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRadius.Location = new System.Drawing.Point(87, 49);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(55, 15);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "반지름";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(149, 49);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(163, 21);
            this.txtRadius.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalc.Location = new System.Drawing.Point(177, 98);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(99, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "계산하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(149, 139);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(163, 21);
            this.txtVolume.TabIndex = 3;
            // 
            // txtSuperficial
            // 
            this.txtSuperficial.Location = new System.Drawing.Point(149, 202);
            this.txtSuperficial.Name = "txtSuperficial";
            this.txtSuperficial.Size = new System.Drawing.Size(163, 21);
            this.txtSuperficial.TabIndex = 4;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVolume.Location = new System.Drawing.Point(87, 139);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(39, 15);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "부피";
            // 
            // lblSuperficial
            // 
            this.lblSuperficial.AutoSize = true;
            this.lblSuperficial.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSuperficial.Location = new System.Drawing.Point(87, 202);
            this.lblSuperficial.Name = "lblSuperficial";
            this.lblSuperficial.Size = new System.Drawing.Size(55, 15);
            this.lblSuperficial.TabIndex = 6;
            this.lblSuperficial.Text = "표면적";
            // 
            // FrmVolumNSuperficialCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(438, 295);
            this.Controls.Add(this.lblSuperficial);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtSuperficial);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Name = "FrmVolumNSuperficialCalc";
            this.Text = "부피, 표면적 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtSuperficial;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblSuperficial;
    }
}

