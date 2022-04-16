
namespace WindowFormApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoWindow = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMulti = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "window title";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(290, 65);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(77, 12);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "window size";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(24, 66);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(97, 12);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "window location";
            // 
            // lblBorder
            // 
            this.lblBorder.AutoSize = true;
            this.lblBorder.Location = new System.Drawing.Point(24, 147);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(99, 12);
            this.lblBorder.TabIndex = 3;
            this.lblBorder.Text = "FormBorderStyle";
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(24, 247);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(48, 12);
            this.lblOpacity.TabIndex = 4;
            this.lblOpacity.Text = "Opacity";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(152, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(12, 12);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "x";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(238, 46);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 12);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "y";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(388, 46);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 12);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(474, 46);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(39, 12);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "height";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(211, 281);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 32);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Form";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(425, 21);
            this.txtTitle.TabIndex = 10;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(127, 63);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(62, 21);
            this.txtX.TabIndex = 10;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(211, 63);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(62, 21);
            this.txtY.TabIndex = 10;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(373, 61);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(62, 21);
            this.txtWidth.TabIndex = 10;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(465, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(62, 21);
            this.txtHeight.TabIndex = 10;
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(78, 244);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(146, 21);
            this.txtOpacity.TabIndex = 10;
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Location = new System.Drawing.Point(3, 11);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(53, 16);
            this.rdoNone.TabIndex = 11;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Location = new System.Drawing.Point(3, 37);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(93, 16);
            this.rdoSingle.TabIndex = 12;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Fixed Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoWindow
            // 
            this.rdoWindow.AutoSize = true;
            this.rdoWindow.Location = new System.Drawing.Point(4, 66);
            this.rdoWindow.Name = "rdoWindow";
            this.rdoWindow.Size = new System.Drawing.Size(123, 16);
            this.rdoWindow.TabIndex = 13;
            this.rdoWindow.TabStop = true;
            this.rdoWindow.Text = "FixedToolWindow";
            this.rdoWindow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoSingle);
            this.panel1.Controls.Add(this.rdoWindow);
            this.panel1.Controls.Add(this.rdoNone);
            this.panel1.Location = new System.Drawing.Point(129, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(443, 68);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(13, 12);
            this.lblMulti.TabIndex = 8;
            this.lblMulti.Text = "X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtOpacity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtOpacity;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMulti;
    }
}

