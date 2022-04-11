
namespace BMICheckProject
{
    partial class BMICheck
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblStandardWeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblObesity = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtStandardWeight = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtObesity = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(65, 45);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(17, 12);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "키";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(54, 86);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 12);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "몸무게";
            // 
            // lblStandardWeight
            // 
            this.lblStandardWeight.AutoSize = true;
            this.lblStandardWeight.Location = new System.Drawing.Point(42, 213);
            this.lblStandardWeight.Name = "lblStandardWeight";
            this.lblStandardWeight.Size = new System.Drawing.Size(53, 12);
            this.lblStandardWeight.TabIndex = 2;
            this.lblStandardWeight.Text = "표준체중";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(19, 259);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(85, 12);
            this.lblBMI.TabIndex = 3;
            this.lblBMI.Text = "비만지수(BMI)";
            // 
            // lblObesity
            // 
            this.lblObesity.AutoSize = true;
            this.lblObesity.Location = new System.Drawing.Point(42, 305);
            this.lblObesity.Name = "lblObesity";
            this.lblObesity.Size = new System.Drawing.Size(41, 12);
            this.lblObesity.TabIndex = 4;
            this.lblObesity.Text = "비만도";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 42);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(110, 83);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 21);
            this.txtWeight.TabIndex = 6;
            // 
            // txtStandardWeight
            // 
            this.txtStandardWeight.Location = new System.Drawing.Point(110, 210);
            this.txtStandardWeight.Name = "txtStandardWeight";
            this.txtStandardWeight.ReadOnly = true;
            this.txtStandardWeight.Size = new System.Drawing.Size(100, 21);
            this.txtStandardWeight.TabIndex = 7;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(110, 256);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(100, 21);
            this.txtBMI.TabIndex = 8;
            // 
            // txtObesity
            // 
            this.txtObesity.Location = new System.Drawing.Point(110, 302);
            this.txtObesity.Name = "txtObesity";
            this.txtObesity.ReadOnly = true;
            this.txtObesity.Size = new System.Drawing.Size(100, 21);
            this.txtObesity.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(119, 144);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "확인";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // BMICheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 383);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtObesity);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtStandardWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblObesity);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblStandardWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Name = "BMICheck";
            this.Text = "비만도 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblStandardWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblObesity;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtStandardWeight;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtObesity;
        private System.Windows.Forms.Button btnCalc;
    }
}

