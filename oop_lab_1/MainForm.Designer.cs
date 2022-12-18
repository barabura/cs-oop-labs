namespace oop_labs
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
            this.tboxVertexes = new System.Windows.Forms.TextBox();
            this.btnRedrawFigure = new System.Windows.Forms.Button();
            this.btnTrajectoryColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lblPulseSpeed = new System.Windows.Forms.Label();
            this.btnFigureColor = new System.Windows.Forms.Button();
            this.tbarPointPulse = new System.Windows.Forms.TrackBar();
            this.tbarPointSpeed = new System.Windows.Forms.TrackBar();
            this.lblPointSpeed = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lblMovingPointManagement = new System.Windows.Forms.Label();
            this.lblFFrequency = new System.Windows.Forms.Label();
            this.tbarFFrequency = new System.Windows.Forms.TrackBar();
            this.lblFTrajectorySize = new System.Windows.Forms.Label();
            this.tbarFTrajectorySize = new System.Windows.Forms.TrackBar();
            this.cdFigureColor = new System.Windows.Forms.ColorDialog();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.cdTrajectoryColor = new System.Windows.Forms.ColorDialog();
            this.btnDefaultFigure = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnPasteFromClipboard = new System.Windows.Forms.Button();
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
            this.pboxWorkSpace.Size = new System.Drawing.Size(564, 666);
            this.pboxWorkSpace.TabIndex = 0;
            this.pboxWorkSpace.TabStop = false;
            this.pboxWorkSpace.SizeChanged += new System.EventHandler(this.pboxWorkSpace_SizeChanged);
            this.pboxWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorkSpace_Paint);
            // 
            // pnlFControlSpace
            // 
            this.pnlFControlSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFControlSpace.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFControlSpace.Controls.Add(this.btnPasteFromClipboard);
            this.pnlFControlSpace.Controls.Add(this.btnCopyToClipboard);
            this.pnlFControlSpace.Controls.Add(this.lbl7);
            this.pnlFControlSpace.Controls.Add(this.lbl6);
            this.pnlFControlSpace.Controls.Add(this.lbl5);
            this.pnlFControlSpace.Controls.Add(this.lbl4);
            this.pnlFControlSpace.Controls.Add(this.lbl3);
            this.pnlFControlSpace.Controls.Add(this.lbl2);
            this.pnlFControlSpace.Controls.Add(this.lbl1);
            this.pnlFControlSpace.Controls.Add(this.lbl0);
            this.pnlFControlSpace.Controls.Add(this.btnDefaultFigure);
            this.pnlFControlSpace.Controls.Add(this.tboxVertexes);
            this.pnlFControlSpace.Controls.Add(this.btnRedrawFigure);
            this.pnlFControlSpace.Controls.Add(this.btnTrajectoryColor);
            this.pnlFControlSpace.Controls.Add(this.btnBackgroundColor);
            this.pnlFControlSpace.Controls.Add(this.lblPulseSpeed);
            this.pnlFControlSpace.Controls.Add(this.btnFigureColor);
            this.pnlFControlSpace.Controls.Add(this.tbarPointPulse);
            this.pnlFControlSpace.Controls.Add(this.tbarPointSpeed);
            this.pnlFControlSpace.Controls.Add(this.lblPointSpeed);
            this.pnlFControlSpace.Controls.Add(this.btStop);
            this.pnlFControlSpace.Controls.Add(this.btStart);
            this.pnlFControlSpace.Controls.Add(this.lblMovingPointManagement);
            this.pnlFControlSpace.Controls.Add(this.lblFFrequency);
            this.pnlFControlSpace.Controls.Add(this.tbarFFrequency);
            this.pnlFControlSpace.Controls.Add(this.lblFTrajectorySize);
            this.pnlFControlSpace.Controls.Add(this.tbarFTrajectorySize);
            this.pnlFControlSpace.Location = new System.Drawing.Point(582, 12);
            this.pnlFControlSpace.Name = "pnlFControlSpace";
            this.pnlFControlSpace.Size = new System.Drawing.Size(371, 666);
            this.pnlFControlSpace.TabIndex = 1;
            // 
            // tboxVertexes
            // 
            this.tboxVertexes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxVertexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxVertexes.Location = new System.Drawing.Point(231, 413);
            this.tboxVertexes.Multiline = true;
            this.tboxVertexes.Name = "tboxVertexes";
            this.tboxVertexes.Size = new System.Drawing.Size(127, 160);
            this.tboxVertexes.TabIndex = 16;
            // 
            // btnRedrawFigure
            // 
            this.btnRedrawFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedrawFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRedrawFigure.Location = new System.Drawing.Point(5, 516);
            this.btnRedrawFigure.Name = "btnRedrawFigure";
            this.btnRedrawFigure.Size = new System.Drawing.Size(175, 36);
            this.btnRedrawFigure.TabIndex = 15;
            this.btnRedrawFigure.Text = "Redraw figure";
            this.btnRedrawFigure.UseVisualStyleBackColor = true;
            this.btnRedrawFigure.Click += new System.EventHandler(this.btnRedrawFigure_Click);
            // 
            // btnTrajectoryColor
            // 
            this.btnTrajectoryColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrajectoryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrajectoryColor.Location = new System.Drawing.Point(4, 474);
            this.btnTrajectoryColor.Name = "btnTrajectoryColor";
            this.btnTrajectoryColor.Size = new System.Drawing.Size(176, 36);
            this.btnTrajectoryColor.TabIndex = 14;
            this.btnTrajectoryColor.Text = "Trajectory color";
            this.btnTrajectoryColor.UseVisualStyleBackColor = true;
            this.btnTrajectoryColor.Click += new System.EventHandler(this.btnTrajectoryColor_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColor.Location = new System.Drawing.Point(3, 436);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(176, 35);
            this.btnBackgroundColor.TabIndex = 13;
            this.btnBackgroundColor.Text = "Background color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lblPulseSpeed
            // 
            this.lblPulseSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPulseSpeed.AutoSize = true;
            this.lblPulseSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPulseSpeed.Location = new System.Drawing.Point(8, 329);
            this.lblPulseSpeed.Name = "lblPulseSpeed";
            this.lblPulseSpeed.Size = new System.Drawing.Size(168, 20);
            this.lblPulseSpeed.TabIndex = 12;
            this.lblPulseSpeed.Text = "Figure pulse intensity";
            // 
            // btnFigureColor
            // 
            this.btnFigureColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFigureColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFigureColor.Location = new System.Drawing.Point(4, 395);
            this.btnFigureColor.Name = "btnFigureColor";
            this.btnFigureColor.Size = new System.Drawing.Size(176, 35);
            this.btnFigureColor.TabIndex = 11;
            this.btnFigureColor.Text = "Figure color";
            this.btnFigureColor.UseVisualStyleBackColor = true;
            this.btnFigureColor.Click += new System.EventHandler(this.btnFigureColor_Click);
            // 
            // tbarPointPulse
            // 
            this.tbarPointPulse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarPointPulse.Location = new System.Drawing.Point(3, 352);
            this.tbarPointPulse.Minimum = 1;
            this.tbarPointPulse.Name = "tbarPointPulse";
            this.tbarPointPulse.Size = new System.Drawing.Size(364, 56);
            this.tbarPointPulse.TabIndex = 10;
            this.tbarPointPulse.Value = 1;
            this.tbarPointPulse.ValueChanged += new System.EventHandler(this.tbarPointPulse_ValueChanged);
            // 
            // tbarPointSpeed
            // 
            this.tbarPointSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarPointSpeed.Location = new System.Drawing.Point(3, 270);
            this.tbarPointSpeed.Maximum = 12;
            this.tbarPointSpeed.Minimum = 3;
            this.tbarPointSpeed.Name = "tbarPointSpeed";
            this.tbarPointSpeed.Size = new System.Drawing.Size(364, 56);
            this.tbarPointSpeed.TabIndex = 9;
            this.tbarPointSpeed.Value = 3;
            this.tbarPointSpeed.ValueChanged += new System.EventHandler(this.tbarPointSpeed_ValueChanged);
            // 
            // lblPointSpeed
            // 
            this.lblPointSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointSpeed.AutoSize = true;
            this.lblPointSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPointSpeed.Location = new System.Drawing.Point(8, 247);
            this.lblPointSpeed.Name = "lblPointSpeed";
            this.lblPointSpeed.Size = new System.Drawing.Size(102, 20);
            this.lblPointSpeed.TabIndex = 8;
            this.lblPointSpeed.Text = "Point speed:";
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(128, 196);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(105, 33);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(12, 196);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(110, 33);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblMovingPointManagement
            // 
            this.lblMovingPointManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovingPointManagement.AutoSize = true;
            this.lblMovingPointManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMovingPointManagement.Location = new System.Drawing.Point(8, 163);
            this.lblMovingPointManagement.Name = "lblMovingPointManagement";
            this.lblMovingPointManagement.Size = new System.Drawing.Size(204, 20);
            this.lblMovingPointManagement.TabIndex = 4;
            this.lblMovingPointManagement.Text = "Moving point management";
            // 
            // lblFFrequency
            // 
            this.lblFFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFFrequency.AutoSize = true;
            this.lblFFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFFrequency.Location = new System.Drawing.Point(8, 81);
            this.lblFFrequency.Name = "lblFFrequency";
            this.lblFFrequency.Size = new System.Drawing.Size(92, 20);
            this.lblFFrequency.TabIndex = 3;
            this.lblFFrequency.Text = "Frequency:";
            // 
            // tbarFFrequency
            // 
            this.tbarFFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarFFrequency.Location = new System.Drawing.Point(12, 104);
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
            this.lblFTrajectorySize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFTrajectorySize.AutoSize = true;
            this.lblFTrajectorySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTrajectorySize.Location = new System.Drawing.Point(8, 12);
            this.lblFTrajectorySize.Name = "lblFTrajectorySize";
            this.lblFTrajectorySize.Size = new System.Drawing.Size(125, 20);
            this.lblFTrajectorySize.TabIndex = 1;
            this.lblFTrajectorySize.Text = "Trajectory size:";
            // 
            // tbarFTrajectorySize
            // 
            this.tbarFTrajectorySize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarFTrajectorySize.Location = new System.Drawing.Point(12, 35);
            this.tbarFTrajectorySize.Maximum = 50;
            this.tbarFTrajectorySize.Minimum = 1;
            this.tbarFTrajectorySize.Name = "tbarFTrajectorySize";
            this.tbarFTrajectorySize.Size = new System.Drawing.Size(346, 56);
            this.tbarFTrajectorySize.TabIndex = 0;
            this.tbarFTrajectorySize.Value = 25;
            this.tbarFTrajectorySize.ValueChanged += new System.EventHandler(this.tbarFTrajectorySize_ValueChanged);
            // 
            // btnDefaultFigure
            // 
            this.btnDefaultFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefaultFigure.Location = new System.Drawing.Point(5, 558);
            this.btnDefaultFigure.Name = "btnDefaultFigure";
            this.btnDefaultFigure.Size = new System.Drawing.Size(175, 31);
            this.btnDefaultFigure.TabIndex = 17;
            this.btnDefaultFigure.Text = "Default figure";
            this.btnDefaultFigure.UseVisualStyleBackColor = true;
            this.btnDefaultFigure.Click += new System.EventHandler(this.btnDefaultFigure_Click);
            // 
            // lbl0
            // 
            this.lbl0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl0.Location = new System.Drawing.Point(211, 417);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(16, 18);
            this.lbl0.TabIndex = 18;
            this.lbl0.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(211, 435);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 18);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(211, 453);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 18);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(211, 471);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(16, 18);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "3";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4.Location = new System.Drawing.Point(211, 492);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(16, 18);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "4";
            // 
            // lbl5
            // 
            this.lbl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5.Location = new System.Drawing.Point(211, 510);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(16, 18);
            this.lbl5.TabIndex = 23;
            this.lbl5.Text = "5";
            // 
            // lbl6
            // 
            this.lbl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6.Location = new System.Drawing.Point(211, 528);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(16, 18);
            this.lbl6.TabIndex = 24;
            this.lbl6.Text = "6";
            // 
            // lbl7
            // 
            this.lbl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7.Location = new System.Drawing.Point(211, 546);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(16, 18);
            this.lbl7.TabIndex = 25;
            this.lbl7.Text = "7";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(5, 595);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(128, 68);
            this.btnCopyToClipboard.TabIndex = 26;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPasteFromClipboard.Location = new System.Drawing.Point(139, 595);
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(130, 68);
            this.btnPasteFromClipboard.TabIndex = 27;
            this.btnPasteFromClipboard.Text = "Paste from clipboard";
            this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 690);
            this.Controls.Add(this.pnlFControlSpace);
            this.Controls.Add(this.pboxWorkSpace);
            this.Name = "frmMain";
            this.Text = "My function";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnRedrawFigure;
        private System.Windows.Forms.TextBox tboxVertexes;
        private System.Windows.Forms.Button btnDefaultFigure;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Button btnPasteFromClipboard;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}

