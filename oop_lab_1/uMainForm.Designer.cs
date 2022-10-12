namespace oop_lab_1
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxWorkSpace = new System.Windows.Forms.PictureBox();
            this.pnlFControlSpace = new System.Windows.Forms.Panel();
            this.lblFFrequency = new System.Windows.Forms.Label();
            this.tbarFFrequency = new System.Windows.Forms.TrackBar();
            this.lblFTrajectorySize = new System.Windows.Forms.Label();
            this.tbarFTrajectorySize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySize)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxWorkSpace
            // 
            this.pboxWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxWorkSpace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pboxWorkSpace.Location = new System.Drawing.Point(12, 12);
            this.pboxWorkSpace.Name = "pboxWorkSpace";
            this.pboxWorkSpace.Size = new System.Drawing.Size(586, 502);
            this.pboxWorkSpace.TabIndex = 0;
            this.pboxWorkSpace.TabStop = false;
            this.pboxWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorkSpace_Paint);
            // 
            // pnlFControlSpace
            // 
            this.pnlFControlSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFControlSpace.Controls.Add(this.lblFFrequency);
            this.pnlFControlSpace.Controls.Add(this.tbarFFrequency);
            this.pnlFControlSpace.Controls.Add(this.lblFTrajectorySize);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySize);
            this.pnlFControlSpace.Location = new System.Drawing.Point(607, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(352, 502);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // lblFFrequency
            // 
            this.lblFFrequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFFrequency.AutoSize = true;
            this.lblFFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFFrequency.Location = new System.Drawing.Point(133, 257);
            this.lblFFrequency.Name = "lblFFrequency";
            this.lblFFrequency.Size = new System.Drawing.Size(92, 20);
            this.lblFFrequency.TabIndex = 3;
            this.lblFFrequency.Text = "Frequency:";
            // 
            // tbarFFrequency
            // 
            this.tbarFFrequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbarFFrequency.Location = new System.Drawing.Point(3, 297);
            this.tbarFFrequency.Maximum = 50;
            this.tbarFFrequency.Minimum = 3;
            this.tbarFFrequency.Name = "tbarFFrequency";
            this.tbarFFrequency.Size = new System.Drawing.Size(345, 56);
            this.tbarFFrequency.TabIndex = 2;
            this.tbarFFrequency.Value = 3;
            // 
            // lblFTrajectorySize
            // 
            this.lblFTrajectorySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFTrajectorySize.AutoSize = true;
            this.lblFTrajectorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrajectorySize.Location = new System.Drawing.Point(111, 44);
            this.lblFTrajectorySize.Name = "lblFTrajectorySize";
            this.lblFTrajectorySize.Size = new System.Drawing.Size(125, 20);
            this.lblFTrajectorySize.TabIndex = 1;
            this.lblFTrajectorySize.Text = "Trajectory size:";
            // 
            // tbarFTrajectorySize
            // 
            this.tbarFTrajectorySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbarFTrajectorySize.Location = new System.Drawing.Point(2, 77);
            this.tbarFTrajectorySize.Maximum = 50;
            this.tbarFTrajectorySize.Name = "tbarFTrajectorySize";
            this.tbarFTrajectorySize.Size = new System.Drawing.Size(346, 56);
            this.tbarFTrajectorySize.TabIndex = 0;
            this.tbarFTrajectorySize.Value = 25;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 526);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxWorkSpace);
            this.Name = "frmMain";
            this.Text = "My function";
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).EndInit();
            this.pnlFControlSpace.ResumeLayout(false);
            this.pnlFControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlFControlSpace;
        private System.Windows.Forms.TrackBar tbarFTrajectorySize;
        private System.Windows.Forms.Label lblFTrajectorySize;
        private System.Windows.Forms.Label lblFFrequency;
        private System.Windows.Forms.TrackBar tbarFFrequency;
    }
}

