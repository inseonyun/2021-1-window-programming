
namespace AddFraction
{
    partial class AddFractopn
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator3 = new System.Windows.Forms.TextBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.lblDenominator2 = new System.Windows.Forms.Label();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.txtNumerator3 = new System.Windows.Forms.TextBox();
            this.lblDenominator1 = new System.Windows.Forms.Label();
            this.lblNumerator2 = new System.Windows.Forms.Label();
            this.lblDenominator3 = new System.Windows.Forms.Label();
            this.lblNumerator1 = new System.Windows.Forms.Label();
            this.lblFraction2 = new System.Windows.Forms.Label();
            this.lblFraction1 = new System.Windows.Forms.Label();
            this.lblNumerator3 = new System.Windows.Forms.Label();
            this.lblFraction3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(296, 54);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(11, 12);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = "+";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(139, 170);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 19;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Location = new System.Drawing.Point(457, 84);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator2.TabIndex = 17;
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Location = new System.Drawing.Point(138, 84);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator1.TabIndex = 16;
            // 
            // txtDenominator3
            // 
            this.txtDenominator3.Location = new System.Drawing.Point(356, 200);
            this.txtDenominator3.Name = "txtDenominator3";
            this.txtDenominator3.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator3.TabIndex = 15;
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(457, 30);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator2.TabIndex = 14;
            // 
            // lblDenominator2
            // 
            this.lblDenominator2.AutoSize = true;
            this.lblDenominator2.Location = new System.Drawing.Point(413, 87);
            this.lblDenominator2.Name = "lblDenominator2";
            this.lblDenominator2.Size = new System.Drawing.Size(29, 12);
            this.lblDenominator2.TabIndex = 10;
            this.lblDenominator2.Text = "분모";
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(138, 30);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator1.TabIndex = 18;
            // 
            // txtNumerator3
            // 
            this.txtNumerator3.Location = new System.Drawing.Point(356, 146);
            this.txtNumerator3.Name = "txtNumerator3";
            this.txtNumerator3.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator3.TabIndex = 13;
            // 
            // lblDenominator1
            // 
            this.lblDenominator1.AutoSize = true;
            this.lblDenominator1.Location = new System.Drawing.Point(94, 87);
            this.lblDenominator1.Name = "lblDenominator1";
            this.lblDenominator1.Size = new System.Drawing.Size(29, 12);
            this.lblDenominator1.TabIndex = 11;
            this.lblDenominator1.Text = "분모";
            // 
            // lblNumerator2
            // 
            this.lblNumerator2.AutoSize = true;
            this.lblNumerator2.Location = new System.Drawing.Point(413, 33);
            this.lblNumerator2.Name = "lblNumerator2";
            this.lblNumerator2.Size = new System.Drawing.Size(29, 12);
            this.lblNumerator2.TabIndex = 9;
            this.lblNumerator2.Text = "분자";
            // 
            // lblDenominator3
            // 
            this.lblDenominator3.AutoSize = true;
            this.lblDenominator3.Location = new System.Drawing.Point(312, 203);
            this.lblDenominator3.Name = "lblDenominator3";
            this.lblDenominator3.Size = new System.Drawing.Size(29, 12);
            this.lblDenominator3.TabIndex = 8;
            this.lblDenominator3.Text = "분모";
            // 
            // lblNumerator1
            // 
            this.lblNumerator1.AutoSize = true;
            this.lblNumerator1.Location = new System.Drawing.Point(94, 33);
            this.lblNumerator1.Name = "lblNumerator1";
            this.lblNumerator1.Size = new System.Drawing.Size(29, 12);
            this.lblNumerator1.TabIndex = 7;
            this.lblNumerator1.Text = "분자";
            // 
            // lblFraction2
            // 
            this.lblFraction2.AutoSize = true;
            this.lblFraction2.Location = new System.Drawing.Point(354, 54);
            this.lblFraction2.Name = "lblFraction2";
            this.lblFraction2.Size = new System.Drawing.Size(35, 12);
            this.lblFraction2.TabIndex = 6;
            this.lblFraction2.Text = "분수2";
            // 
            // lblFraction1
            // 
            this.lblFraction1.AutoSize = true;
            this.lblFraction1.Location = new System.Drawing.Point(35, 54);
            this.lblFraction1.Name = "lblFraction1";
            this.lblFraction1.Size = new System.Drawing.Size(35, 12);
            this.lblFraction1.TabIndex = 5;
            this.lblFraction1.Text = "분수1";
            // 
            // lblNumerator3
            // 
            this.lblNumerator3.AutoSize = true;
            this.lblNumerator3.Location = new System.Drawing.Point(312, 149);
            this.lblNumerator3.Name = "lblNumerator3";
            this.lblNumerator3.Size = new System.Drawing.Size(29, 12);
            this.lblNumerator3.TabIndex = 12;
            this.lblNumerator3.Text = "분자";
            // 
            // lblFraction3
            // 
            this.lblFraction3.AutoSize = true;
            this.lblFraction3.Location = new System.Drawing.Point(253, 170);
            this.lblFraction3.Name = "lblFraction3";
            this.lblFraction3.Size = new System.Drawing.Size(29, 12);
            this.lblFraction3.TabIndex = 4;
            this.lblFraction3.Text = "결과";
            // 
            // AddFractopn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 249);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.txtDenominator3);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.lblDenominator2);
            this.Controls.Add(this.txtNumerator1);
            this.Controls.Add(this.txtNumerator3);
            this.Controls.Add(this.lblDenominator1);
            this.Controls.Add(this.lblNumerator2);
            this.Controls.Add(this.lblDenominator3);
            this.Controls.Add(this.lblNumerator1);
            this.Controls.Add(this.lblFraction2);
            this.Controls.Add(this.lblFraction1);
            this.Controls.Add(this.lblNumerator3);
            this.Controls.Add(this.lblFraction3);
            this.Name = "AddFractopn";
            this.Text = "분수 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.TextBox txtDenominator3;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.Label lblDenominator2;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.TextBox txtNumerator3;
        private System.Windows.Forms.Label lblDenominator1;
        private System.Windows.Forms.Label lblNumerator2;
        private System.Windows.Forms.Label lblDenominator3;
        private System.Windows.Forms.Label lblNumerator1;
        private System.Windows.Forms.Label lblFraction2;
        private System.Windows.Forms.Label lblFraction1;
        private System.Windows.Forms.Label lblNumerator3;
        private System.Windows.Forms.Label lblFraction3;
    }
}

