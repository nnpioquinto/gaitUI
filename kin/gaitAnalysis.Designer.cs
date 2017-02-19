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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gaitAnalysis));
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.noKinectWarn = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.stepLbl = new System.Windows.Forms.Label();
            this.skelLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
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
            this.videoBox.BackColor = System.Drawing.Color.White;
            this.videoBox.Location = new System.Drawing.Point(33, 28);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(640, 480);
            this.videoBox.TabIndex = 0;
            this.videoBox.TabStop = false;
            this.videoBox.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(828, 530);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(129, 43);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // noKinectWarn
            // 
            this.noKinectWarn.AutoSize = true;
            this.noKinectWarn.BackColor = System.Drawing.Color.White;
            this.noKinectWarn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noKinectWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.noKinectWarn.Location = new System.Drawing.Point(48, 66);
            this.noKinectWarn.Name = "noKinectWarn";
            this.noKinectWarn.Size = new System.Drawing.Size(402, 39);
            this.noKinectWarn.TabIndex = 2;
            this.noKinectWarn.Text = "No Kinect Sensor found!";
            this.noKinectWarn.Visible = false;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.White;
            this.stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(689, 530);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(129, 43);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(679, 382);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(3);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(87, 32);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "Time: ";
            // 
            // stepLbl
            // 
            this.stepLbl.AutoSize = true;
            this.stepLbl.BackColor = System.Drawing.Color.Transparent;
            this.stepLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLbl.ForeColor = System.Drawing.Color.Black;
            this.stepLbl.Location = new System.Drawing.Point(679, 344);
            this.stepLbl.Margin = new System.Windows.Forms.Padding(3);
            this.stepLbl.Name = "stepLbl";
            this.stepLbl.Size = new System.Drawing.Size(90, 32);
            this.stepLbl.TabIndex = 5;
            this.stepLbl.Text = "Steps: ";
            // 
            // skelLbl
            // 
            this.skelLbl.AutoSize = true;
            this.skelLbl.BackColor = System.Drawing.Color.Transparent;
            this.skelLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skelLbl.Location = new System.Drawing.Point(679, 295);
            this.skelLbl.Margin = new System.Windows.Forms.Padding(3);
            this.skelLbl.Name = "skelLbl";
            this.skelLbl.Size = new System.Drawing.Size(87, 32);
            this.skelLbl.TabIndex = 6;
            this.skelLbl.Text = "Body: ";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(33, 537);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(110, 36);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // feetLbl
            // 
            this.feetLbl.AutoSize = true;
            this.feetLbl.BackColor = System.Drawing.Color.Transparent;
            this.feetLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.feetLbl.Location = new System.Drawing.Point(679, 256);
            this.feetLbl.Margin = new System.Windows.Forms.Padding(3);
            this.feetLbl.Name = "feetLbl";
            this.feetLbl.Size = new System.Drawing.Size(70, 32);
            this.feetLbl.TabIndex = 8;
            this.feetLbl.Text = "Feet:";
            // 
            // sLenLbl
            // 
            this.sLenLbl.AutoSize = true;
            this.sLenLbl.BackColor = System.Drawing.Color.Transparent;
            this.sLenLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.sLenLbl.Location = new System.Drawing.Point(679, 28);
            this.sLenLbl.Margin = new System.Windows.Forms.Padding(3);
            this.sLenLbl.Name = "sLenLbl";
            this.sLenLbl.Size = new System.Drawing.Size(163, 32);
            this.sLenLbl.TabIndex = 9;
            this.sLenLbl.Text = "Step Length: ";
            // 
            // sFreqLbl
            // 
            this.sFreqLbl.AutoSize = true;
            this.sFreqLbl.BackColor = System.Drawing.Color.Transparent;
            this.sFreqLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFreqLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.sFreqLbl.Location = new System.Drawing.Point(679, 104);
            this.sFreqLbl.Margin = new System.Windows.Forms.Padding(3);
            this.sFreqLbl.Name = "sFreqLbl";
            this.sFreqLbl.Size = new System.Drawing.Size(199, 32);
            this.sFreqLbl.TabIndex = 10;
            this.sFreqLbl.Text = "Step Frequency:";
            // 
            // swingTimeLbl
            // 
            this.swingTimeLbl.AutoSize = true;
            this.swingTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.swingTimeLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swingTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.swingTimeLbl.Location = new System.Drawing.Point(679, 180);
            this.swingTimeLbl.Margin = new System.Windows.Forms.Padding(3);
            this.swingTimeLbl.Name = "swingTimeLbl";
            this.swingTimeLbl.Size = new System.Drawing.Size(169, 32);
            this.swingTimeLbl.TabIndex = 11;
            this.swingTimeLbl.Text = "Swing Time:  ";
            // 
            // StanceTimeLbl
            // 
            this.StanceTimeLbl.AutoSize = true;
            this.StanceTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.StanceTimeLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StanceTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.StanceTimeLbl.Location = new System.Drawing.Point(679, 218);
            this.StanceTimeLbl.Margin = new System.Windows.Forms.Padding(3);
            this.StanceTimeLbl.Name = "StanceTimeLbl";
            this.StanceTimeLbl.Size = new System.Drawing.Size(174, 32);
            this.StanceTimeLbl.TabIndex = 12;
            this.StanceTimeLbl.Text = "Stance Time:  ";
            // 
            // srLenLbl
            // 
            this.srLenLbl.AutoSize = true;
            this.srLenLbl.BackColor = System.Drawing.Color.Transparent;
            this.srLenLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srLenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.srLenLbl.Location = new System.Drawing.Point(679, 66);
            this.srLenLbl.Margin = new System.Windows.Forms.Padding(3);
            this.srLenLbl.Name = "srLenLbl";
            this.srLenLbl.Size = new System.Drawing.Size(182, 32);
            this.srLenLbl.TabIndex = 13;
            this.srLenLbl.Text = "Stride Length: ";
            // 
            // srVeloLbl
            // 
            this.srVeloLbl.AutoSize = true;
            this.srVeloLbl.BackColor = System.Drawing.Color.Transparent;
            this.srVeloLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srVeloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.srVeloLbl.Location = new System.Drawing.Point(679, 142);
            this.srVeloLbl.Margin = new System.Windows.Forms.Padding(3);
            this.srVeloLbl.Name = "srVeloLbl";
            this.srVeloLbl.Size = new System.Drawing.Size(194, 32);
            this.srVeloLbl.TabIndex = 14;
            this.srVeloLbl.Text = "Stride Velocity: ";
            // 
            // gaitAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kin.Properties.Resources.bg5;
            this.ClientSize = new System.Drawing.Size(969, 585);
            this.Controls.Add(this.srVeloLbl);
            this.Controls.Add(this.srLenLbl);
            this.Controls.Add(this.StanceTimeLbl);
            this.Controls.Add(this.swingTimeLbl);
            this.Controls.Add(this.sFreqLbl);
            this.Controls.Add(this.sLenLbl);
            this.Controls.Add(this.feetLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.skelLbl);
            this.Controls.Add(this.stepLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.noKinectWarn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.videoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gaitAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gait Analysis";
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
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label feetLbl;
        private System.Windows.Forms.Label sLenLbl;
        private System.Windows.Forms.Label sFreqLbl;
        private System.Windows.Forms.Label swingTimeLbl;
        private System.Windows.Forms.Label StanceTimeLbl;
        private System.Windows.Forms.Label srLenLbl;
        private System.Windows.Forms.Label srVeloLbl;
    }
}