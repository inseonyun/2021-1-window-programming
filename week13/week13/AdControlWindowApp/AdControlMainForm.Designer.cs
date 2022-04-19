
namespace AdControlWindowApp
{
    partial class AdControlMainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbValue = new System.Windows.Forms.TrackBar();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(143, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(53, 53);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(129, 21);
            this.nUpDown.TabIndex = 1;
            this.nUpDown.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // tbValue
            // 
            this.tbValue.LargeChange = 20;
            this.tbValue.Location = new System.Drawing.Point(248, 53);
            this.tbValue.Maximum = 100;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(179, 45);
            this.tbValue.SmallChange = 5;
            this.tbValue.TabIndex = 2;
            this.tbValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbValue.Scroll += new System.EventHandler(this.tbValue_Scroll);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(53, 115);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(374, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(236, 167);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // AdControlMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 237);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.btnStart);
            this.Name = "AdControlMainForm";
            this.Text = "AdControlApp";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.TrackBar tbValue;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
    }
}

