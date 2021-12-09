
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tla = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipaDolNaVrh = new System.Windows.Forms.PictureBox();
            this.pipaVrhNavzdol = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pipaDol2 = new System.Windows.Forms.PictureBox();
            this.pipaDol3 = new System.Windows.Forms.PictureBox();
            this.pipaVrh3 = new System.Windows.Forms.PictureBox();
            this.pipaVrh2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDolNaVrh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrhNavzdol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDol3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tla
            // 
            this.tla.Image = global::WinFormsApp5.Properties.Resources._base;
            this.tla.Location = new System.Drawing.Point(48, 533);
            this.tla.Name = "tla";
            this.tla.Size = new System.Drawing.Size(984, 85);
            this.tla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tla.TabIndex = 0;
            this.tla.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::WinFormsApp5.Properties.Resources.bluebird_midflap;
            this.flappyBird.Location = new System.Drawing.Point(168, 269);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(43, 37);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // pipaDolNaVrh
            // 
            this.pipaDolNaVrh.Image = global::WinFormsApp5.Properties.Resources.pipe_red;
            this.pipaDolNaVrh.Location = new System.Drawing.Point(544, 332);
            this.pipaDolNaVrh.Name = "pipaDolNaVrh";
            this.pipaDolNaVrh.Size = new System.Drawing.Size(57, 206);
            this.pipaDolNaVrh.TabIndex = 2;
            this.pipaDolNaVrh.TabStop = false;
            this.pipaDolNaVrh.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipaVrhNavzdol
            // 
            this.pipaVrhNavzdol.BackColor = System.Drawing.SystemColors.Info;
            this.pipaVrhNavzdol.Image = global::WinFormsApp5.Properties.Resources._1;
            this.pipaVrhNavzdol.Location = new System.Drawing.Point(633, -3);
            this.pipaVrhNavzdol.Name = "pipaVrhNavzdol";
            this.pipaVrhNavzdol.Size = new System.Drawing.Size(57, 206);
            this.pipaVrhNavzdol.TabIndex = 3;
            this.pipaVrhNavzdol.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Goudy", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(333, 549);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(125, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.casovnikEvent);
            // 
            // pipaDol2
            // 
            this.pipaDol2.Image = global::WinFormsApp5.Properties.Resources.pipe_red;
            this.pipaDol2.Location = new System.Drawing.Point(607, 332);
            this.pipaDol2.Name = "pipaDol2";
            this.pipaDol2.Size = new System.Drawing.Size(57, 206);
            this.pipaDol2.TabIndex = 5;
            this.pipaDol2.TabStop = false;
            // 
            // pipaDol3
            // 
            this.pipaDol3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pipaDol3.Image = global::WinFormsApp5.Properties.Resources.pipe_red;
            this.pipaDol3.Location = new System.Drawing.Point(670, 332);
            this.pipaDol3.Name = "pipaDol3";
            this.pipaDol3.Size = new System.Drawing.Size(57, 206);
            this.pipaDol3.TabIndex = 6;
            this.pipaDol3.TabStop = false;
            this.pipaDol3.Click += new System.EventHandler(this.pipaDol3_Click);
            // 
            // pipaVrh3
            // 
            this.pipaVrh3.Image = global::WinFormsApp5.Properties.Resources._1;
            this.pipaVrh3.Location = new System.Drawing.Point(759, -3);
            this.pipaVrh3.Name = "pipaVrh3";
            this.pipaVrh3.Size = new System.Drawing.Size(57, 206);
            this.pipaVrh3.TabIndex = 7;
            this.pipaVrh3.TabStop = false;
            // 
            // pipaVrh2
            // 
            this.pipaVrh2.BackColor = System.Drawing.SystemColors.Info;
            this.pipaVrh2.Image = global::WinFormsApp5.Properties.Resources._1;
            this.pipaVrh2.Location = new System.Drawing.Point(696, -3);
            this.pipaVrh2.Name = "pipaVrh2";
            this.pipaVrh2.Size = new System.Drawing.Size(57, 206);
            this.pipaVrh2.TabIndex = 8;
            this.pipaVrh2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp5.Properties.Resources._71tg7xmy7l;
            this.pictureBox1.Location = new System.Drawing.Point(35, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1059, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pipaVrh2);
            this.Controls.Add(this.pipaVrh3);
            this.Controls.Add(this.pipaDol3);
            this.Controls.Add(this.pipaDol2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipaVrhNavzdol);
            this.Controls.Add(this.pipaDolNaVrh);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.tla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.eventUp);
            ((System.ComponentModel.ISupportInitialize)(this.tla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDolNaVrh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrhNavzdol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaDol3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipaVrh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap rBitmap = new Bitmap(300, 500);
            using (Graphics g = Graphics.FromImage(rBitmap))
            {
                using (var br = new LinearGradientBrush(new Rectangle(0, 0, 600, 500),
                       Color.Red, Color.Gray, LinearGradientMode.Vertical))
                {
                    br.SetSigmaBellShape(0.0f, 1f);
                    g.FillRectangle(br, new Rectangle(0, 0, 700, 500));
                }
            }
            this.BackgroundImage = rBitmap;
        }

        #endregion

        private System.Windows.Forms.PictureBox tla;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipaDolNaVrh;
        private System.Windows.Forms.PictureBox pipaVrhNavzdol;
        public System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pipaDol2;
        private System.Windows.Forms.PictureBox pipaDol3;
        private System.Windows.Forms.PictureBox pipaVrh3;
        private System.Windows.Forms.PictureBox pipaVrh2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

