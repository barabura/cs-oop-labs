﻿namespace oop_lab_1
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
            this.tbarPointPulse = new System.Windows.Forms.TrackBar();
            this.tbarPointSpeed = new System.Windows.Forms.TrackBar();
            this.lblPointSpeed = new System.Windows.Forms.Label();
            this.cboxChangeDitrection = new System.Windows.Forms.CheckBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lblMovingPointManagement = new System.Windows.Forms.Label();
            this.lblFFrequency = new System.Windows.Forms.Label();
            this.tbarFFrequency = new System.Windows.Forms.TrackBar();
            this.lblFTrajectorySize = new System.Windows.Forms.Label();
            this.tbarFTrajectorySize = new System.Windows.Forms.TrackBar();
            this.btnFigureColor = new System.Windows.Forms.Button();
            this.cdFigureColor = new System.Windows.Forms.ColorDialog();
            this.lblPulseSpeed = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.btnTrajectoryColor = new System.Windows.Forms.Button();
            this.cdTrajectoryColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlFControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPointPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPointSpeed)).BeginInit();
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
            this.pboxWorkSpace.Size = new System.Drawing.Size(562, 544);
            this.pboxWorkSpace.TabIndex = 0;
            this.pboxWorkSpace.TabStop = false;
            this.pboxWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorkSpace_Paint);
            // 
            // pnlFControlSpace
            // 
            this.pnlFControlSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFControlSpace.Controls.Add(this.btnTrajectoryColor);
            this.pnlFControlSpace.Controls.Add(this.btnBackgroundColor);
            this.pnlFControlSpace.Controls.Add(this.lblPulseSpeed);
            this.pnlFControlSpace.Controls.Add(this.btnFigureColor);
            this.pnlFControlSpace.Controls.Add(this.tbarPointPulse);
            this.pnlFControlSpace.Controls.Add(this.tbarPointSpeed);
            this.pnlFControlSpace.Controls.Add(this.lblPointSpeed);
            this.pnlFControlSpace.Controls.Add(this.cboxChangeDitrection);
            this.pnlFControlSpace.Controls.Add(this.btStop);
            this.pnlFControlSpace.Controls.Add(this.btStart);
            this.pnlFControlSpace.Controls.Add(this.lblMovingPointManagement);
            this.pnlFControlSpace.Controls.Add(this.lblFFrequency);
            this.pnlFControlSpace.Controls.Add(this.tbarFFrequency);
            this.pnlFControlSpace.Controls.Add(this.lblFTrajectorySize);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySize);
            this.pnlFControlSpace.Location = new System.Drawing.Point(583, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(352, 544);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // tbarPointPulse
            // 
            this.tbarPointPulse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarPointPulse.Location = new System.Drawing.Point(3, 376);
            this.tbarPointPulse.Minimum = 1;
            this.tbarPointPulse.Name = "tbarPointPulse";
            this.tbarPointPulse.Size = new System.Drawing.Size(345, 56);
            this.tbarPointPulse.TabIndex = 10;
            this.tbarPointPulse.Value = 1;
            this.tbarPointPulse.ValueChanged += new System.EventHandler(this.tbarPointPulse_ValueChanged);
            // 
            // tbarPointSpeed
            // 
            this.tbarPointSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarPointSpeed.Location = new System.Drawing.Point(3, 306);
            this.tbarPointSpeed.Maximum = 12;
            this.tbarPointSpeed.Minimum = 3;
            this.tbarPointSpeed.Name = "tbarPointSpeed";
            this.tbarPointSpeed.Size = new System.Drawing.Size(345, 56);
            this.tbarPointSpeed.TabIndex = 9;
            this.tbarPointSpeed.Value = 3;
            this.tbarPointSpeed.ValueChanged += new System.EventHandler(this.tbarPointSpeed_ValueChanged);
            // 
            // lblPointSpeed
            // 
            this.lblPointSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointSpeed.AutoSize = true;
            this.lblPointSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPointSpeed.Location = new System.Drawing.Point(8, 283);
            this.lblPointSpeed.Name = "lblPointSpeed";
            this.lblPointSpeed.Size = new System.Drawing.Size(102, 20);
            this.lblPointSpeed.TabIndex = 8;
            this.lblPointSpeed.Text = "Point speed:";
            // 
            // cboxChangeDitrection
            // 
            this.cboxChangeDitrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxChangeDitrection.AutoSize = true;
            this.cboxChangeDitrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxChangeDitrection.Location = new System.Drawing.Point(12, 242);
            this.cboxChangeDitrection.Name = "cboxChangeDitrection";
            this.cboxChangeDitrection.Size = new System.Drawing.Size(154, 24);
            this.cboxChangeDitrection.TabIndex = 7;
            this.cboxChangeDitrection.Text = "change direction";
            this.cboxChangeDitrection.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(126, 203);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(86, 33);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(12, 203);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(91, 33);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblMovingPointManagement
            // 
            this.lblMovingPointManagement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMovingPointManagement.AutoSize = true;
            this.lblMovingPointManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovingPointManagement.Location = new System.Drawing.Point(8, 168);
            this.lblMovingPointManagement.Name = "lblMovingPointManagement";
            this.lblMovingPointManagement.Size = new System.Drawing.Size(204, 20);
            this.lblMovingPointManagement.TabIndex = 4;
            this.lblMovingPointManagement.Text = "Moving point management";
            // 
            // lblFFrequency
            // 
            this.lblFFrequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFFrequency.AutoSize = true;
            this.lblFFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFFrequency.Location = new System.Drawing.Point(8, 86);
            this.lblFFrequency.Name = "lblFFrequency";
            this.lblFFrequency.Size = new System.Drawing.Size(92, 20);
            this.lblFFrequency.TabIndex = 3;
            this.lblFFrequency.Text = "Frequency:";
            // 
            // tbarFFrequency
            // 
            this.tbarFFrequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbarFFrequency.Location = new System.Drawing.Point(3, 109);
            this.tbarFFrequency.Maximum = 50;
            this.tbarFFrequency.Minimum = 3;
            this.tbarFFrequency.Name = "tbarFFrequency";
            this.tbarFFrequency.Size = new System.Drawing.Size(345, 56);
            this.tbarFFrequency.TabIndex = 2;
            this.tbarFFrequency.Value = 3;
            this.tbarFFrequency.ValueChanged += new System.EventHandler(this.tbarFFrequency_ValueChanged);
            // 
            // lblFTrajectorySize
            // 
            this.lblFTrajectorySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFTrajectorySize.AutoSize = true;
            this.lblFTrajectorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrajectorySize.Location = new System.Drawing.Point(8, 4);
            this.lblFTrajectorySize.Name = "lblFTrajectorySize";
            this.lblFTrajectorySize.Size = new System.Drawing.Size(125, 20);
            this.lblFTrajectorySize.TabIndex = 1;
            this.lblFTrajectorySize.Text = "Trajectory size:";
            // 
            // tbarFTrajectorySize
            // 
            this.tbarFTrajectorySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbarFTrajectorySize.Location = new System.Drawing.Point(3, 27);
            this.tbarFTrajectorySize.Maximum = 50;
            this.tbarFTrajectorySize.Minimum = 1;
            this.tbarFTrajectorySize.Name = "tbarFTrajectorySize";
            this.tbarFTrajectorySize.Size = new System.Drawing.Size(346, 56);
            this.tbarFTrajectorySize.TabIndex = 0;
            this.tbarFTrajectorySize.Value = 25;
            this.tbarFTrajectorySize.ValueChanged += new System.EventHandler(this.tbarFTrajectorySize_ValueChanged);
            // 
            // btnFigureColor
            // 
            this.btnFigureColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFigureColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFigureColor.Location = new System.Drawing.Point(12, 438);
            this.btnFigureColor.Name = "btnFigureColor";
            this.btnFigureColor.Size = new System.Drawing.Size(137, 35);
            this.btnFigureColor.TabIndex = 11;
            this.btnFigureColor.Text = "Figure color";
            this.btnFigureColor.UseVisualStyleBackColor = true;
            this.btnFigureColor.Click += new System.EventHandler(this.btnFigureColor_Click);
            // 
            // lblPulseSpeed
            // 
            this.lblPulseSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPulseSpeed.AutoSize = true;
            this.lblPulseSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPulseSpeed.Location = new System.Drawing.Point(8, 353);
            this.lblPulseSpeed.Name = "lblPulseSpeed";
            this.lblPulseSpeed.Size = new System.Drawing.Size(168, 20);
            this.lblPulseSpeed.TabIndex = 12;
            this.lblPulseSpeed.Text = "Figure pulse intensity";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColor.Location = new System.Drawing.Point(169, 438);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(170, 35);
            this.btnBackgroundColor.TabIndex = 13;
            this.btnBackgroundColor.Text = "Background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnTrajectoryColor
            // 
            this.btnTrajectoryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrajectoryColor.Location = new System.Drawing.Point(12, 488);
            this.btnTrajectoryColor.Name = "btnTrajectoryColor";
            this.btnTrajectoryColor.Size = new System.Drawing.Size(137, 36);
            this.btnTrajectoryColor.TabIndex = 14;
            this.btnTrajectoryColor.Text = "Trajectory color";
            this.btnTrajectoryColor.UseVisualStyleBackColor = true;
            this.btnTrajectoryColor.Click += new System.EventHandler(this.btnTrajectoryColor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 568);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxWorkSpace);
            this.Name = "frmMain";
            this.Text = "My function";
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).EndInit();
            this.pnlFControlSpace.ResumeLayout(false);
            this.pnlFControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPointPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPointSpeed)).EndInit();
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
        private System.Windows.Forms.Label lblMovingPointManagement;
        private System.Windows.Forms.CheckBox cboxChangeDitrection;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TrackBar tbarPointSpeed;
        private System.Windows.Forms.Label lblPointSpeed;
        private System.Windows.Forms.TrackBar tbarPointPulse;
        private System.Windows.Forms.Button btnFigureColor;
        private System.Windows.Forms.ColorDialog cdFigureColor;
        private System.Windows.Forms.Label lblPulseSpeed;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ColorDialog cdBackgroundColor;
        private System.Windows.Forms.Button btnTrajectoryColor;
        private System.Windows.Forms.ColorDialog cdTrajectoryColor;
    }
}

