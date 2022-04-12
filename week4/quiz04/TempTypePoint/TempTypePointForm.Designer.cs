
namespace TempTypePoint
{
    partial class TempTypePointForm
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(40, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 12);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X값";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(40, 71);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 12);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y값";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(27, 184);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(53, 12);
            this.lblPrint.TabIndex = 2;
            this.lblPrint.Text = "객체정보";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(87, 28);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(87, 68);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 4;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(87, 181);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(252, 21);
            this.txtPrint.TabIndex = 5;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(35, 119);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 6;
            this.btnMake.Text = "객체생성";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(135, 119);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "좌표변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(206, 48);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(43, 21);
            this.txtType.TabIndex = 8;
            // 
            // TempTypePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 234);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "TempTypePointForm";
            this.Text = "TempTypePoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtType;
    }
}

