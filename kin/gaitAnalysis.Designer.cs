namespace kin
{
    partial class gaitAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.noKinectWarn = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.stepLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoBox
            // 
            this.videoBox.Location = new System.Drawing.Point(33, 28);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(574, 387);
            this.videoBox.TabIndex = 0;
            this.videoBox.TabStop = false;
            this.videoBox.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(443, 518);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(129, 43);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // noKinectWarn
            // 
            this.noKinectWarn.AutoSize = true;
            this.noKinectWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noKinectWarn.Location = new System.Drawing.Point(27, 28);
            this.noKinectWarn.Name = "noKinectWarn";
            this.noKinectWarn.Size = new System.Drawing.Size(308, 31);
            this.noKinectWarn.TabIndex = 2;
            this.noKinectWarn.Text = "No Kinect Sensor found!";
            this.noKinectWarn.Visible = false;
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(638, 518);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(129, 43);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Salmon;
            this.timeLbl.Location = new System.Drawing.Point(51, 454);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(63, 24);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "Time: ";
            // 
            // stepLbl
            // 
            this.stepLbl.AutoSize = true;
            this.stepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLbl.ForeColor = System.Drawing.Color.Salmon;
            this.stepLbl.Location = new System.Drawing.Point(401, 454);
            this.stepLbl.Name = "stepLbl";
            this.stepLbl.Size = new System.Drawing.Size(67, 24);
            this.stepLbl.TabIndex = 5;
            this.stepLbl.Text = "Steps: ";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLbl.Location = new System.Drawing.Point(634, 363);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(70, 24);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Status: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gaitAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.stepLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.noKinectWarn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.videoBox);
            this.Name = "gaitAnalysis";
            this.Text = "gaitAnalysis";
            this.Load += new System.EventHandler(this.gaitAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label noKinectWarn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label stepLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button button1;
    }
}