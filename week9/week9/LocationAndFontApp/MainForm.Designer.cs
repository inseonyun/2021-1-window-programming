
namespace LocationAndFontApp
{
    partial class MainForm
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
            this.lblHorse = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnLU = new System.Windows.Forms.Button();
            this.btnRU = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorse
            // 
            this.lblHorse.BackColor = System.Drawing.Color.Aqua;
            this.lblHorse.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHorse.ForeColor = System.Drawing.Color.Black;
            this.lblHorse.Location = new System.Drawing.Point(175, 120);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(119, 20);
            this.lblHorse.TabIndex = 0;
            this.lblHorse.Text = "움직이는 말";
            this.lblHorse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(373, 30);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "크게";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(373, 77);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "작게";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(204, 255);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 1;
            this.btnU.Text = "위";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(119, 286);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 1;
            this.btnL.Text = "왼쪽";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(289, 286);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "오른쪽";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(204, 320);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "아래";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnLU
            // 
            this.btnLU.Location = new System.Drawing.Point(119, 255);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(75, 23);
            this.btnLU.TabIndex = 1;
            this.btnLU.Text = "왼쪽위";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // btnRU
            // 
            this.btnRU.Location = new System.Drawing.Point(289, 255);
            this.btnRU.Name = "btnRU";
            this.btnRU.Size = new System.Drawing.Size(75, 23);
            this.btnRU.TabIndex = 1;
            this.btnRU.Text = "오른쪽위";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Click += new System.EventHandler(this.btnRU_Click);
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(289, 320);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(75, 23);
            this.btnRD.TabIndex = 1;
            this.btnRD.Text = "오른쪽아래";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnLD
            // 
            this.btnLD.Location = new System.Drawing.Point(119, 320);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(75, 23);
            this.btnLD.TabIndex = 1;
            this.btnLD.Text = "왼쪽아래";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(204, 286);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(75, 23);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "처음위치";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 381);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.btnRD);
            this.Controls.Add(this.btnRU);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.btnOrigin);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblHorse);
            this.Name = "MainForm";
            this.Text = "위치,폰트크기 변경";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnOrigin;
    }
}

