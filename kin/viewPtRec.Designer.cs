namespace kin
{
    partial class viewPtRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPtRec));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.viewHist_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editPt_Btn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGrid.Location = new System.Drawing.Point(13, 33);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.Size = new System.Drawing.Size(837, 395);
            this.dataGrid.TabIndex = 0;
            // 
            // viewHist_btn
            // 
            this.viewHist_btn.BackColor = System.Drawing.Color.White;
            this.viewHist_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewHist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.viewHist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.viewHist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewHist_btn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHist_btn.Location = new System.Drawing.Point(21, 491);
            this.viewHist_btn.Margin = new System.Windows.Forms.Padding(4);
            this.viewHist_btn.Name = "viewHist_btn";
            this.viewHist_btn.Size = new System.Drawing.Size(165, 32);
            this.viewHist_btn.TabIndex = 1;
            this.viewHist_btn.Text = "View History";
            this.viewHist_btn.UseVisualStyleBackColor = false;
            this.viewHist_btn.Click += new System.EventHandler(this.viewHist_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a record above then choose from the buttons below.";
            // 
            // editPt_Btn
            // 
            this.editPt_Btn.BackColor = System.Drawing.Color.White;
            this.editPt_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editPt_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.editPt_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(246)))));
            this.editPt_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPt_Btn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPt_Btn.Location = new System.Drawing.Point(231, 491);
            this.editPt_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.editPt_Btn.Name = "editPt_Btn";
            this.editPt_Btn.Size = new System.Drawing.Size(165, 32);
            this.editPt_Btn.TabIndex = 3;
            this.editPt_Btn.Text = "Edit Patient Data";
            this.editPt_Btn.UseVisualStyleBackColor = false;
            this.editPt_Btn.Click += new System.EventHandler(this.editPt_Btn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(445, 491);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(165, 32);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start ";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(671, 491);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(165, 32);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewPtRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::kin.Properties.Resources.bg5;
            this.ClientSize = new System.Drawing.Size(871, 565);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.editPt_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewHist_btn);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewPtRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patient Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button viewHist_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editPt_Btn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button backBtn;

        
    }
}