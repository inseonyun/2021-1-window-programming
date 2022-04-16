
namespace InputFormApp
{
    partial class InputForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblSlash1 = new System.Windows.Forms.Label();
            this.lblSlash2 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.grpFavorite = new System.Windows.Forms.GroupBox();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.chkFishing = new System.Windows.Forms.CheckBox();
            this.chkGaming = new System.Windows.Forms.CheckBox();
            this.chkSinging = new System.Windows.Forms.CheckBox();
            this.grpGender.SuspendLayout();
            this.grpFavorite.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(32, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 12);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "age";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(29, 183);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(29, 12);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "birth";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(109, 280);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(76, 57);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 21);
            this.txtAge.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(62, 180);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(57, 21);
            this.txtYear.TabIndex = 6;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(144, 180);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(28, 21);
            this.txtMonth.TabIndex = 7;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(193, 180);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(28, 21);
            this.txtDay.TabIndex = 7;
            // 
            // lblSlash1
            // 
            this.lblSlash1.AutoSize = true;
            this.lblSlash1.Location = new System.Drawing.Point(125, 183);
            this.lblSlash1.Name = "lblSlash1";
            this.lblSlash1.Size = new System.Drawing.Size(11, 12);
            this.lblSlash1.TabIndex = 2;
            this.lblSlash1.Text = "/";
            // 
            // lblSlash2
            // 
            this.lblSlash2.AutoSize = true;
            this.lblSlash2.Location = new System.Drawing.Point(178, 183);
            this.lblSlash2.Name = "lblSlash2";
            this.lblSlash2.Size = new System.Drawing.Size(11, 12);
            this.lblSlash2.TabIndex = 2;
            this.lblSlash2.Text = "/";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoMan);
            this.grpGender.Controls.Add(this.rdoWoman);
            this.grpGender.Location = new System.Drawing.Point(34, 95);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(187, 66);
            this.grpGender.TabIndex = 8;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "gender";
            // 
            // grpFavorite
            // 
            this.grpFavorite.Controls.Add(this.chkSinging);
            this.grpFavorite.Controls.Add(this.chkGaming);
            this.grpFavorite.Controls.Add(this.chkFishing);
            this.grpFavorite.Location = new System.Drawing.Point(16, 220);
            this.grpFavorite.Name = "grpFavorite";
            this.grpFavorite.Size = new System.Drawing.Size(255, 50);
            this.grpFavorite.TabIndex = 8;
            this.grpFavorite.TabStop = false;
            this.grpFavorite.Text = "favorite";
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(17, 29);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(48, 16);
            this.rdoMan.TabIndex = 9;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "man";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(93, 29);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(65, 16);
            this.rdoWoman.TabIndex = 10;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "woman";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // chkFishing
            // 
            this.chkFishing.AutoSize = true;
            this.chkFishing.Location = new System.Drawing.Point(15, 20);
            this.chkFishing.Name = "chkFishing";
            this.chkFishing.Size = new System.Drawing.Size(61, 16);
            this.chkFishing.TabIndex = 0;
            this.chkFishing.Text = "fishing";
            this.chkFishing.UseVisualStyleBackColor = true;
            // 
            // chkGaming
            // 
            this.chkGaming.AutoSize = true;
            this.chkGaming.Location = new System.Drawing.Point(90, 20);
            this.chkGaming.Name = "chkGaming";
            this.chkGaming.Size = new System.Drawing.Size(66, 16);
            this.chkGaming.TabIndex = 1;
            this.chkGaming.Text = "gaming";
            this.chkGaming.UseVisualStyleBackColor = true;
            // 
            // chkSinging
            // 
            this.chkSinging.AutoSize = true;
            this.chkSinging.Location = new System.Drawing.Point(177, 20);
            this.chkSinging.Name = "chkSinging";
            this.chkSinging.Size = new System.Drawing.Size(65, 16);
            this.chkSinging.TabIndex = 2;
            this.chkSinging.Text = "singing";
            this.chkSinging.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 330);
            this.Controls.Add(this.grpFavorite);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSlash2);
            this.Controls.Add(this.lblSlash1);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpFavorite.ResumeLayout(false);
            this.grpFavorite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblSlash1;
        private System.Windows.Forms.Label lblSlash2;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.GroupBox grpFavorite;
        private System.Windows.Forms.CheckBox chkSinging;
        private System.Windows.Forms.CheckBox chkGaming;
        private System.Windows.Forms.CheckBox chkFishing;
    }
}

