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
            this.skelLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.feetLbl = new System.Windows.Forms.Label();
            this.sLenLbl = new System.Windows.Forms.Label();
            this.sFreqLbl = new System.Windows.Forms.Label();
            this.swingTimeLbl = new System.Windows.Forms.Label();
            this.StanceTimeLbl = new System.Windows.Forms.Label();
            this.srLenLbl = new System.Windows.Forms.Label();
            this.srVeloLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // videoBox
            // 
            this.videoBox.Location = new System.Drawing.Point(33, 28);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(539, 387);
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
            this.noKinectWarn.Location = new System.Drawing.Point(48, 66);
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
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(50, 438);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(63, 24);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "Time: ";
            // 
            // stepLbl
            // 
            this.stepLbl.AutoSize = true;
            this.stepLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLbl.ForeColor = System.Drawing.Color.Black;
            this.stepLbl.Location = new System.Drawing.Point(365, 438);
            this.stepLbl.Name = "stepLbl";
            this.stepLbl.Size = new System.Drawing.Size(67, 24);
            this.stepLbl.TabIndex = 5;
            this.stepLbl.Text = "Steps: ";
            // 
            // skelLbl
            // 
            this.skelLbl.AutoSize = true;
            this.skelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skelLbl.Location = new System.Drawing.Point(578, 379);
            this.skelLbl.Name = "skelLbl";
            this.skelLbl.Size = new System.Drawing.Size(93, 24);
            this.skelLbl.TabIndex = 6;
            this.skelLbl.Text = "Skeleton: ";
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
            // feetLbl
            // 
            this.feetLbl.AutoSize = true;
            this.feetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.feetLbl.Location = new System.Drawing.Point(578, 339);
            this.feetLbl.Name = "feetLbl";
            this.feetLbl.Size = new System.Drawing.Size(53, 24);
            this.feetLbl.TabIndex = 8;
            this.feetLbl.Text = "Feet:";
            // 
            // sLenLbl
            // 
            this.sLenLbl.AutoSize = true;
            this.sLenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sLenLbl.ForeColor = System.Drawing.Color.Green;
            this.sLenLbl.Location = new System.Drawing.Point(578, 35);
            this.sLenLbl.Name = "sLenLbl";
            this.sLenLbl.Size = new System.Drawing.Size(121, 24);
            this.sLenLbl.TabIndex = 9;
            this.sLenLbl.Text = "Step Length: ";
            // 
            // sFreqLbl
            // 
            this.sFreqLbl.AutoSize = true;
            this.sFreqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sFreqLbl.ForeColor = System.Drawing.Color.Green;
            this.sFreqLbl.Location = new System.Drawing.Point(578, 116);
            this.sFreqLbl.Name = "sFreqLbl";
            this.sFreqLbl.Size = new System.Drawing.Size(150, 24);
            this.sFreqLbl.TabIndex = 10;
            this.sFreqLbl.Text = "Step Frequency:";
            // 
            // swingTimeLbl
            // 
            this.swingTimeLbl.AutoSize = true;
            this.swingTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.swingTimeLbl.ForeColor = System.Drawing.Color.Green;
            this.swingTimeLbl.Location = new System.Drawing.Point(50, 484);
            this.swingTimeLbl.Name = "swingTimeLbl";
            this.swingTimeLbl.Size = new System.Drawing.Size(125, 24);
            this.swingTimeLbl.TabIndex = 11;
            this.swingTimeLbl.Text = "Swing Time:  ";
            // 
            // StanceTimeLbl
            // 
            this.StanceTimeLbl.AutoSize = true;
            this.StanceTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StanceTimeLbl.ForeColor = System.Drawing.Color.Green;
            this.StanceTimeLbl.Location = new System.Drawing.Point(365, 484);
            this.StanceTimeLbl.Name = "StanceTimeLbl";
            this.StanceTimeLbl.Size = new System.Drawing.Size(131, 24);
            this.StanceTimeLbl.TabIndex = 12;
            this.StanceTimeLbl.Text = "Stance Time:  ";
            // 
            // srLenLbl
            // 
            this.srLenLbl.AutoSize = true;
            this.srLenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.srLenLbl.ForeColor = System.Drawing.Color.Green;
            this.srLenLbl.Location = new System.Drawing.Point(578, 73);
            this.srLenLbl.Name = "srLenLbl";
            this.srLenLbl.Size = new System.Drawing.Size(131, 24);
            this.srLenLbl.TabIndex = 13;
            this.srLenLbl.Text = "Stride Length: ";
            // 
            // srVeloLbl
            // 
            this.srVeloLbl.AutoSize = true;
            this.srVeloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.srVeloLbl.ForeColor = System.Drawing.Color.Green;
            this.srVeloLbl.Location = new System.Drawing.Point(578, 159);
            this.srVeloLbl.Name = "srVeloLbl";
            this.srVeloLbl.Size = new System.Drawing.Size(139, 24);
            this.srVeloLbl.TabIndex = 14;
            this.srVeloLbl.Text = "Stride Velocity: ";
            // 
            // gaitAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 573);
            this.Controls.Add(this.srVeloLbl);
            this.Controls.Add(this.srLenLbl);
            this.Controls.Add(this.StanceTimeLbl);
            this.Controls.Add(this.swingTimeLbl);
            this.Controls.Add(this.sFreqLbl);
            this.Controls.Add(this.sLenLbl);
            this.Controls.Add(this.feetLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skelLbl);
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
        private System.Windows.Forms.Label skelLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label feetLbl;
        private System.Windows.Forms.Label sLenLbl;
        private System.Windows.Forms.Label sFreqLbl;
        private System.Windows.Forms.Label swingTimeLbl;
        private System.Windows.Forms.Label StanceTimeLbl;
        private System.Windows.Forms.Label srLenLbl;
        private System.Windows.Forms.Label srVeloLbl;
    }
}