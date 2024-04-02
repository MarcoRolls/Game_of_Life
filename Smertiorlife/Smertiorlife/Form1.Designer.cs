namespace Smertiorlife
{
    partial class TheGameOfLife
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
            this.bblue = new System.Windows.Forms.Button();
            this.bred = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LifeBox = new System.Windows.Forms.PictureBox();
            this.LifeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bblue);
            this.splitContainer1.Panel1.Controls.Add(this.bred);
            this.splitContainer1.Panel1.Controls.Add(this.bStop);
            this.splitContainer1.Panel1.Controls.Add(this.bStart);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LifeBox);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 651);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 0;
            // 
            // bblue
            // 
            this.bblue.Location = new System.Drawing.Point(11, 325);
            this.bblue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bblue.Name = "bblue";
            this.bblue.Size = new System.Drawing.Size(99, 56);
            this.bblue.TabIndex = 9;
            this.bblue.Text = "Синие";
            this.bblue.UseVisualStyleBackColor = true;
            this.bblue.Click += new System.EventHandler(this.BlueClick);
            // 
            // bred
            // 
            this.bred.Location = new System.Drawing.Point(11, 261);
            this.bred.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bred.Name = "bred";
            this.bred.Size = new System.Drawing.Size(99, 56);
            this.bred.TabIndex = 8;
            this.bred.Text = "Красные";
            this.bred.UseVisualStyleBackColor = true;
            this.bred.Click += new System.EventHandler(this.RedClick);
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(11, 172);
            this.bStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(130, 42);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "Стоп ";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(11, 122);
            this.bStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(130, 42);
            this.bStart.TabIndex = 5;
            this.bStart.Text = "Старт ";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(11, 88);
            this.nudDensity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(135, 26);
            this.nudDensity.TabIndex = 4;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плотность клеток ";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(11, 32);
            this.nudResolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(135, 26);
            this.nudResolution.TabIndex = 2;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение ";
            // 
            // LifeBox
            // 
            this.LifeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LifeBox.Location = new System.Drawing.Point(0, 0);
            this.LifeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(1171, 647);
            this.LifeBox.TabIndex = 0;
            this.LifeBox.TabStop = false;
            this.LifeBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // LifeTimer
            // 
            this.LifeTimer.Interval = 40;
            this.LifeTimer.Tick += new System.EventHandler(this.LifeTick);
            // 
            // GameLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 651);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameLife";
            this.Text = "Игра Жизнь ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LifeBox;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer LifeTimer;
        private System.Windows.Forms.Button bblue;
        private System.Windows.Forms.Button bred;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label label2;
    }
}

