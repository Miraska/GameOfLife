namespace GameOfLife
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.radioButtonFps10 = new System.Windows.Forms.RadioButton();
			this.radioButtonFps30 = new System.Windows.Forms.RadioButton();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.nudDensity = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.nudResolution = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.radioButtonFps10);
			this.splitContainer1.Panel1.Controls.Add(this.radioButtonFps30);
			this.splitContainer1.Panel1.Controls.Add(this.buttonStop);
			this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
			this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
			this.splitContainer1.Size = new System.Drawing.Size(939, 543);
			this.splitContainer1.SplitterDistance = 170;
			this.splitContainer1.TabIndex = 0;
			// 
			// radioButtonFps10
			// 
			this.radioButtonFps10.AutoSize = true;
			this.radioButtonFps10.Location = new System.Drawing.Point(14, 179);
			this.radioButtonFps10.Name = "radioButtonFps10";
			this.radioButtonFps10.Size = new System.Drawing.Size(60, 17);
			this.radioButtonFps10.TabIndex = 7;
			this.radioButtonFps10.TabStop = true;
			this.radioButtonFps10.Text = "10 FPS";
			this.radioButtonFps10.UseVisualStyleBackColor = true;
			// 
			// radioButtonFps30
			// 
			this.radioButtonFps30.AutoSize = true;
			this.radioButtonFps30.Location = new System.Drawing.Point(14, 156);
			this.radioButtonFps30.Name = "radioButtonFps30";
			this.radioButtonFps30.Size = new System.Drawing.Size(60, 17);
			this.radioButtonFps30.TabIndex = 6;
			this.radioButtonFps30.TabStop = true;
			this.radioButtonFps30.Text = "30 FPS";
			this.radioButtonFps30.UseVisualStyleBackColor = true;
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(14, 127);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 5;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(14, 98);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// nudDensity
			// 
			this.nudDensity.Location = new System.Drawing.Point(14, 71);
			this.nudDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudDensity.Name = "nudDensity";
			this.nudDensity.Size = new System.Drawing.Size(120, 20);
			this.nudDensity.TabIndex = 3;
			this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Density";
			// 
			// nudResolution
			// 
			this.nudResolution.Location = new System.Drawing.Point(14, 27);
			this.nudResolution.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.nudResolution.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudResolution.Name = "nudResolution";
			this.nudResolution.Size = new System.Drawing.Size(120, 20);
			this.nudResolution.TabIndex = 1;
			this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Resolution";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(761, 539);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 543);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Genration 0";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown nudResolution;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudDensity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.RadioButton radioButtonFps10;
		private System.Windows.Forms.RadioButton radioButtonFps30;
	}
}

