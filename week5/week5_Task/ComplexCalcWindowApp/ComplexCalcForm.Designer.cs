
namespace ComplexCalcWindowApp
{
    partial class ComplexCalcForm
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
            this.lblReal = new System.Windows.Forms.Label();
            this.lblImaginary = new System.Windows.Forms.Label();
            this.lblComplexA = new System.Windows.Forms.Label();
            this.lblComplexB = new System.Windows.Forms.Label();
            this.lblComplexC = new System.Windows.Forms.Label();
            this.txtCBReal = new System.Windows.Forms.TextBox();
            this.txtCAReal = new System.Windows.Forms.TextBox();
            this.txtCCReal = new System.Windows.Forms.TextBox();
            this.txtCBImaginary = new System.Windows.Forms.TextBox();
            this.txtCAImaginary = new System.Windows.Forms.TextBox();
            this.txtCCImaginary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(21, 62);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(41, 12);
            this.lblReal.TabIndex = 0;
            this.lblReal.Text = "실수부";
            // 
            // lblImaginary
            // 
            this.lblImaginary.AutoSize = true;
            this.lblImaginary.Location = new System.Drawing.Point(21, 113);
            this.lblImaginary.Name = "lblImaginary";
            this.lblImaginary.Size = new System.Drawing.Size(41, 12);
            this.lblImaginary.TabIndex = 1;
            this.lblImaginary.Text = "허수부";
            // 
            // lblComplexA
            // 
            this.lblComplexA.AutoSize = true;
            this.lblComplexA.Location = new System.Drawing.Point(81, 35);
            this.lblComplexA.Name = "lblComplexA";
            this.lblComplexA.Size = new System.Drawing.Size(64, 12);
            this.lblComplexA.TabIndex = 2;
            this.lblComplexA.Text = "ComplexA";
            // 
            // lblComplexB
            // 
            this.lblComplexB.AutoSize = true;
            this.lblComplexB.Location = new System.Drawing.Point(197, 35);
            this.lblComplexB.Name = "lblComplexB";
            this.lblComplexB.Size = new System.Drawing.Size(64, 12);
            this.lblComplexB.TabIndex = 2;
            this.lblComplexB.Text = "ComplexB";
            // 
            // lblComplexC
            // 
            this.lblComplexC.AutoSize = true;
            this.lblComplexC.Location = new System.Drawing.Point(327, 35);
            this.lblComplexC.Name = "lblComplexC";
            this.lblComplexC.Size = new System.Drawing.Size(65, 12);
            this.lblComplexC.TabIndex = 2;
            this.lblComplexC.Text = "ComplexC";
            // 
            // txtCBReal
            // 
            this.txtCBReal.Location = new System.Drawing.Point(185, 59);
            this.txtCBReal.Name = "txtCBReal";
            this.txtCBReal.Size = new System.Drawing.Size(100, 21);
            this.txtCBReal.TabIndex = 3;
            // 
            // txtCAReal
            // 
            this.txtCAReal.Location = new System.Drawing.Point(68, 59);
            this.txtCAReal.Name = "txtCAReal";
            this.txtCAReal.Size = new System.Drawing.Size(100, 21);
            this.txtCAReal.TabIndex = 4;
            // 
            // txtCCReal
            // 
            this.txtCCReal.Location = new System.Drawing.Point(320, 59);
            this.txtCCReal.Name = "txtCCReal";
            this.txtCCReal.ReadOnly = true;
            this.txtCCReal.Size = new System.Drawing.Size(100, 21);
            this.txtCCReal.TabIndex = 5;
            // 
            // txtCBImaginary
            // 
            this.txtCBImaginary.Location = new System.Drawing.Point(185, 110);
            this.txtCBImaginary.Name = "txtCBImaginary";
            this.txtCBImaginary.Size = new System.Drawing.Size(100, 21);
            this.txtCBImaginary.TabIndex = 3;
            // 
            // txtCAImaginary
            // 
            this.txtCAImaginary.Location = new System.Drawing.Point(68, 110);
            this.txtCAImaginary.Name = "txtCAImaginary";
            this.txtCAImaginary.Size = new System.Drawing.Size(100, 21);
            this.txtCAImaginary.TabIndex = 4;
            // 
            // txtCCImaginary
            // 
            this.txtCCImaginary.Location = new System.Drawing.Point(320, 110);
            this.txtCCImaginary.Name = "txtCCImaginary";
            this.txtCCImaginary.ReadOnly = true;
            this.txtCCImaginary.Size = new System.Drawing.Size(100, 21);
            this.txtCCImaginary.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(232, 165);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // ComplexCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 231);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCCImaginary);
            this.Controls.Add(this.txtCCReal);
            this.Controls.Add(this.txtCAImaginary);
            this.Controls.Add(this.txtCBImaginary);
            this.Controls.Add(this.txtCAReal);
            this.Controls.Add(this.txtCBReal);
            this.Controls.Add(this.lblComplexC);
            this.Controls.Add(this.lblComplexB);
            this.Controls.Add(this.lblComplexA);
            this.Controls.Add(this.lblImaginary);
            this.Controls.Add(this.lblReal);
            this.Name = "ComplexCalcForm";
            this.Text = "복소수 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblImaginary;
        private System.Windows.Forms.Label lblComplexA;
        private System.Windows.Forms.Label lblComplexB;
        private System.Windows.Forms.Label lblComplexC;
        private System.Windows.Forms.TextBox txtCBReal;
        private System.Windows.Forms.TextBox txtCAReal;
        private System.Windows.Forms.TextBox txtCCReal;
        private System.Windows.Forms.TextBox txtCBImaginary;
        private System.Windows.Forms.TextBox txtCAImaginary;
        private System.Windows.Forms.TextBox txtCCImaginary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiply;
    }
}

