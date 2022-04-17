
namespace WindowsDialogApp
{
    partial class DialogMainForm
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDefaultDialog = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnOkCancel = new System.Windows.Forms.Button();
            this.btnUserDialog1 = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnARI = new System.Windows.Forms.Button();
            this.btnUserDialog2 = new System.Windows.Forms.Button();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.btnYesNo = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.lblParameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(443, 51);
            this.txtResult.TabIndex = 0;
            // 
            // btnDefaultDialog
            // 
            this.btnDefaultDialog.Location = new System.Drawing.Point(12, 77);
            this.btnDefaultDialog.Name = "btnDefaultDialog";
            this.btnDefaultDialog.Size = new System.Drawing.Size(139, 48);
            this.btnDefaultDialog.TabIndex = 1;
            this.btnDefaultDialog.Text = "기본 대화상자";
            this.btnDefaultDialog.UseVisualStyleBackColor = true;
            this.btnDefaultDialog.Click += new System.EventHandler(this.btnDefaultDialog_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(316, 77);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(139, 48);
            this.btnPrintDialog.TabIndex = 1;
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(166, 77);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(139, 48);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnOkCancel
            // 
            this.btnOkCancel.Location = new System.Drawing.Point(12, 143);
            this.btnOkCancel.Name = "btnOkCancel";
            this.btnOkCancel.Size = new System.Drawing.Size(139, 48);
            this.btnOkCancel.TabIndex = 1;
            this.btnOkCancel.Text = "OK / CANCEL";
            this.btnOkCancel.UseVisualStyleBackColor = true;
            this.btnOkCancel.Click += new System.EventHandler(this.btnOkCancel_Click);
            // 
            // btnUserDialog1
            // 
            this.btnUserDialog1.Location = new System.Drawing.Point(316, 143);
            this.btnUserDialog1.Name = "btnUserDialog1";
            this.btnUserDialog1.Size = new System.Drawing.Size(139, 48);
            this.btnUserDialog1.TabIndex = 1;
            this.btnUserDialog1.Text = "사용자정의 1";
            this.btnUserDialog1.UseVisualStyleBackColor = true;
            this.btnUserDialog1.Click += new System.EventHandler(this.btnUserDialog1_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(166, 143);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(139, 48);
            this.btnFontDialog.TabIndex = 1;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnARI
            // 
            this.btnARI.Location = new System.Drawing.Point(10, 278);
            this.btnARI.Name = "btnARI";
            this.btnARI.Size = new System.Drawing.Size(141, 48);
            this.btnARI.TabIndex = 1;
            this.btnARI.Text = "Aboart / Retry / Ignore";
            this.btnARI.UseVisualStyleBackColor = true;
            this.btnARI.Click += new System.EventHandler(this.btnARI_Click);
            // 
            // btnUserDialog2
            // 
            this.btnUserDialog2.Location = new System.Drawing.Point(316, 278);
            this.btnUserDialog2.Name = "btnUserDialog2";
            this.btnUserDialog2.Size = new System.Drawing.Size(139, 48);
            this.btnUserDialog2.TabIndex = 1;
            this.btnUserDialog2.Text = "사용자 정의2";
            this.btnUserDialog2.UseVisualStyleBackColor = true;
            this.btnUserDialog2.Click += new System.EventHandler(this.btnUserDialog2_Click);
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Location = new System.Drawing.Point(166, 278);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(139, 48);
            this.btnFolderBrowser.TabIndex = 1;
            this.btnFolderBrowser.Text = "Folder Browser";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // btnYesNo
            // 
            this.btnYesNo.Location = new System.Drawing.Point(12, 213);
            this.btnYesNo.Name = "btnYesNo";
            this.btnYesNo.Size = new System.Drawing.Size(139, 48);
            this.btnYesNo.TabIndex = 1;
            this.btnYesNo.Text = "Yes / No";
            this.btnYesNo.UseVisualStyleBackColor = true;
            this.btnYesNo.Click += new System.EventHandler(this.btnYesNo_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(166, 213);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(139, 48);
            this.btnOpenFileDialog.TabIndex = 1;
            this.btnOpenFileDialog.Text = "OpenFile Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(316, 228);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(139, 21);
            this.txtParameter.TabIndex = 2;
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Location = new System.Drawing.Point(314, 213);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(62, 12);
            this.lblParameter.TabIndex = 3;
            this.lblParameter.Text = "parameter";
            // 
            // DialogMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 347);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.btnUserDialog2);
            this.Controls.Add(this.btnUserDialog1);
            this.Controls.Add(this.btnYesNo);
            this.Controls.Add(this.btnARI);
            this.Controls.Add(this.btnOkCancel);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnDefaultDialog);
            this.Controls.Add(this.txtResult);
            this.Name = "DialogMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDefaultDialog;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnOkCancel;
        private System.Windows.Forms.Button btnUserDialog1;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnARI;
        private System.Windows.Forms.Button btnUserDialog2;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button btnYesNo;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label lblParameter;
    }
}

