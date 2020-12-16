
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.pictPlay = new System.Windows.Forms.PictureBox();
            this.pictMute = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LifeGameLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeGameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(914, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resolution";
            // 
            // nudResolution
            // 
            this.nudResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudResolution.BackColor = System.Drawing.Color.Black;
            this.nudResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudResolution.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudResolution.ForeColor = System.Drawing.SystemColors.Menu;
            this.nudResolution.Location = new System.Drawing.Point(1005, 22);
            this.nudResolution.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(35, 20);
            this.nudResolution.TabIndex = 7;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(936, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Density";
            // 
            // nudDensity
            // 
            this.nudDensity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDensity.BackColor = System.Drawing.Color.Black;
            this.nudDensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDensity.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudDensity.ForeColor = System.Drawing.SystemColors.Menu;
            this.nudDensity.Location = new System.Drawing.Point(1005, 48);
            this.nudDensity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(35, 20);
            this.nudDensity.TabIndex = 9;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.ForeColor = System.Drawing.SystemColors.Menu;
            this.bStop.Location = new System.Drawing.Point(77, 12);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(61, 30);
            this.bStop.TabIndex = 11;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.bStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.SystemColors.Menu;
            this.bStart.Location = new System.Drawing.Point(10, 12);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(61, 30);
            this.bStart.TabIndex = 10;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pictPlay
            // 
            this.pictPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictPlay.Image")));
            this.pictPlay.Location = new System.Drawing.Point(143, 17);
            this.pictPlay.Name = "pictPlay";
            this.pictPlay.Size = new System.Drawing.Size(28, 24);
            this.pictPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPlay.TabIndex = 13;
            this.pictPlay.TabStop = false;
            this.pictPlay.Click += new System.EventHandler(this.pictPlay_Click);
            // 
            // pictMute
            // 
            this.pictMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictMute.Image = ((System.Drawing.Image)(resources.GetObject("pictMute.Image")));
            this.pictMute.Location = new System.Drawing.Point(143, 17);
            this.pictMute.Name = "pictMute";
            this.pictMute.Size = new System.Drawing.Size(28, 24);
            this.pictMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictMute.TabIndex = 14;
            this.pictMute.TabStop = false;
            this.pictMute.Click += new System.EventHandler(this.pictMute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 547);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // LifeGameLogo
            // 
            this.LifeGameLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LifeGameLogo.Image = global::GameOfLife.Properties.Resources.LifeGameLogo;
            this.LifeGameLogo.Location = new System.Drawing.Point(229, 165);
            this.LifeGameLogo.Name = "LifeGameLogo";
            this.LifeGameLogo.Size = new System.Drawing.Size(596, 108);
            this.LifeGameLogo.TabIndex = 15;
            this.LifeGameLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 547);
            this.Controls.Add(this.LifeGameLogo);
            this.Controls.Add(this.pictPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDensity);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pictMute);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "The Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeGameLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictPlay;
        private System.Windows.Forms.PictureBox pictMute;
        private System.Windows.Forms.PictureBox LifeGameLogo;
    }
}

