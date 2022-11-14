namespace Game1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skor = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.restartBtn = new System.Windows.Forms.Label();
            this.pauseAct = new System.Windows.Forms.Label();
            this.pipaBawah4 = new System.Windows.Forms.PictureBox();
            this.pipaBawah5 = new System.Windows.Forms.PictureBox();
            this.pipaBawah3 = new System.Windows.Forms.PictureBox();
            this.pipaAtas3 = new System.Windows.Forms.PictureBox();
            this.pipaAtas4 = new System.Windows.Forms.PictureBox();
            this.pipaAtas5 = new System.Windows.Forms.PictureBox();
            this.pipaBawah2 = new System.Windows.Forms.PictureBox();
            this.pipaAtas2 = new System.Windows.Forms.PictureBox();
            this.pipaAtas = new System.Windows.Forms.PictureBox();
            this.pipaBawah = new System.Windows.Forms.PictureBox();
            this.burung = new System.Windows.Forms.PictureBox();
            this.tanah = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanah)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timerku);
            // 
            // skor
            // 
            this.skor.BackColor = System.Drawing.Color.Transparent;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skor.Location = new System.Drawing.Point(466, 741);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(161, 46);
            this.skor.TabIndex = 6;
            this.skor.Text = "Score";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // restartBtn
            // 
            this.restartBtn.AutoSize = true;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(637, 416);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(81, 25);
            this.restartBtn.TabIndex = 13;
            this.restartBtn.Text = "Restart";
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // pauseAct
            // 
            this.pauseAct.AutoSize = true;
            this.pauseAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseAct.Location = new System.Drawing.Point(588, 300);
            this.pauseAct.Name = "pauseAct";
            this.pauseAct.Size = new System.Drawing.Size(188, 55);
            this.pauseAct.TabIndex = 14;
            this.pauseAct.Text = "Paused";
            this.pauseAct.Visible = false;
            // 
            // pipaBawah4
            // 
            this.pipaBawah4.Image = global::Game1.Properties.Resources.PipeBottom;
            this.pipaBawah4.Location = new System.Drawing.Point(2400, 480);
            this.pipaBawah4.Name = "pipaBawah4";
            this.pipaBawah4.Size = new System.Drawing.Size(100, 250);
            this.pipaBawah4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaBawah4.TabIndex = 12;
            this.pipaBawah4.TabStop = false;
            // 
            // pipaBawah5
            // 
            this.pipaBawah5.Image = global::Game1.Properties.Resources.PipeBottom;
            this.pipaBawah5.Location = new System.Drawing.Point(2700, 480);
            this.pipaBawah5.Name = "pipaBawah5";
            this.pipaBawah5.Size = new System.Drawing.Size(100, 250);
            this.pipaBawah5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaBawah5.TabIndex = 11;
            this.pipaBawah5.TabStop = false;
            // 
            // pipaBawah3
            // 
            this.pipaBawah3.Image = global::Game1.Properties.Resources.PipeBottom;
            this.pipaBawah3.Location = new System.Drawing.Point(2100, 480);
            this.pipaBawah3.Name = "pipaBawah3";
            this.pipaBawah3.Size = new System.Drawing.Size(100, 250);
            this.pipaBawah3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaBawah3.TabIndex = 10;
            this.pipaBawah3.TabStop = false;
            // 
            // pipaAtas3
            // 
            this.pipaAtas3.Image = global::Game1.Properties.Resources.PipeTop;
            this.pipaAtas3.Location = new System.Drawing.Point(2100, -1);
            this.pipaAtas3.Name = "pipaAtas3";
            this.pipaAtas3.Size = new System.Drawing.Size(100, 250);
            this.pipaAtas3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaAtas3.TabIndex = 9;
            this.pipaAtas3.TabStop = false;
            // 
            // pipaAtas4
            // 
            this.pipaAtas4.Image = global::Game1.Properties.Resources.PipeTop;
            this.pipaAtas4.Location = new System.Drawing.Point(2400, -1);
            this.pipaAtas4.Name = "pipaAtas4";
            this.pipaAtas4.Size = new System.Drawing.Size(100, 250);
            this.pipaAtas4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaAtas4.TabIndex = 8;
            this.pipaAtas4.TabStop = false;
            // 
            // pipaAtas5
            // 
            this.pipaAtas5.Image = global::Game1.Properties.Resources.PipeTop;
            this.pipaAtas5.Location = new System.Drawing.Point(2700, -1);
            this.pipaAtas5.Name = "pipaAtas5";
            this.pipaAtas5.Size = new System.Drawing.Size(100, 250);
            this.pipaAtas5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaAtas5.TabIndex = 7;
            this.pipaAtas5.TabStop = false;
            // 
            // pipaBawah2
            // 
            this.pipaBawah2.Image = global::Game1.Properties.Resources.PipeBottom;
            this.pipaBawah2.Location = new System.Drawing.Point(1800, 480);
            this.pipaBawah2.Name = "pipaBawah2";
            this.pipaBawah2.Size = new System.Drawing.Size(100, 250);
            this.pipaBawah2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaBawah2.TabIndex = 5;
            this.pipaBawah2.TabStop = false;
            // 
            // pipaAtas2
            // 
            this.pipaAtas2.Image = global::Game1.Properties.Resources.PipeTop;
            this.pipaAtas2.Location = new System.Drawing.Point(1800, -1);
            this.pipaAtas2.Name = "pipaAtas2";
            this.pipaAtas2.Size = new System.Drawing.Size(100, 250);
            this.pipaAtas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaAtas2.TabIndex = 4;
            this.pipaAtas2.TabStop = false;
            // 
            // pipaAtas
            // 
            this.pipaAtas.Image = global::Game1.Properties.Resources.PipeTop;
            this.pipaAtas.Location = new System.Drawing.Point(1500, -1);
            this.pipaAtas.Name = "pipaAtas";
            this.pipaAtas.Size = new System.Drawing.Size(100, 250);
            this.pipaAtas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaAtas.TabIndex = 3;
            this.pipaAtas.TabStop = false;
            // 
            // pipaBawah
            // 
            this.pipaBawah.Image = global::Game1.Properties.Resources.PipeBottom;
            this.pipaBawah.Location = new System.Drawing.Point(1500, 480);
            this.pipaBawah.Name = "pipaBawah";
            this.pipaBawah.Size = new System.Drawing.Size(100, 250);
            this.pipaBawah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipaBawah.TabIndex = 2;
            this.pipaBawah.TabStop = false;
            // 
            // burung
            // 
            this.burung.Image = global::Game1.Properties.Resources.Bird2;
            this.burung.Location = new System.Drawing.Point(315, 300);
            this.burung.Name = "burung";
            this.burung.Size = new System.Drawing.Size(39, 44);
            this.burung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burung.TabIndex = 0;
            this.burung.TabStop = false;
            // 
            // tanah
            // 
            this.tanah.Image = global::Game1.Properties.Resources.Ground;
            this.tanah.Location = new System.Drawing.Point(0, 714);
            this.tanah.Name = "tanah";
            this.tanah.Size = new System.Drawing.Size(1497, 98);
            this.tanah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tanah.TabIndex = 1;
            this.tanah.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 796);
            this.Controls.Add(this.pauseAct);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.pipaBawah4);
            this.Controls.Add(this.pipaBawah5);
            this.Controls.Add(this.pipaBawah3);
            this.Controls.Add(this.pipaAtas3);
            this.Controls.Add(this.pipaAtas4);
            this.Controls.Add(this.pipaAtas5);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.pipaBawah2);
            this.Controls.Add(this.pipaAtas2);
            this.Controls.Add(this.pipaAtas);
            this.Controls.Add(this.pipaBawah);
            this.Controls.Add(this.burung);
            this.Controls.Add(this.tanah);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 835);
            this.Name = "Form1";
            this.Text = "Flying Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tekanBawah);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.testKlik);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tekanAtas);
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaBawah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burung;
        private System.Windows.Forms.PictureBox tanah;
        private System.Windows.Forms.PictureBox pipaBawah;
        private System.Windows.Forms.PictureBox pipaAtas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pipaAtas2;
        private System.Windows.Forms.PictureBox pipaBawah2;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.PictureBox pipaAtas5;
        private System.Windows.Forms.PictureBox pipaAtas4;
        private System.Windows.Forms.PictureBox pipaAtas3;
        private System.Windows.Forms.PictureBox pipaBawah3;
        private System.Windows.Forms.PictureBox pipaBawah5;
        private System.Windows.Forms.PictureBox pipaBawah4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label restartBtn;
        private System.Windows.Forms.Label pauseAct;
    }
}

