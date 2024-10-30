namespace Flappy_Bird
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
            this.puanText = new System.Windows.Forms.Label();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.altEngel = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.ustEngel = new System.Windows.Forms.PictureBox();
            this.oyunSuresi = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altEngel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustEngel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // puanText
            // 
            this.puanText.AutoSize = true;
            this.puanText.BackColor = System.Drawing.Color.SaddleBrown;
            this.puanText.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanText.Location = new System.Drawing.Point(26, 456);
            this.puanText.Name = "puanText";
            this.puanText.Size = new System.Drawing.Size(129, 43);
            this.puanText.TabIndex = 4;
            this.puanText.Text = "Puan: 0";
            // 
            // zemin
            // 
            this.zemin.Image = global::Flappy_Bird.Properties.Resources.unnamed;
            this.zemin.Location = new System.Drawing.Point(-3, 419);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(868, 105);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            this.zemin.Click += new System.EventHandler(this.zemin_Click);
            // 
            // altEngel
            // 
            this.altEngel.Image = global::Flappy_Bird.Properties.Resources.pipeBottom;
            this.altEngel.Location = new System.Drawing.Point(329, 284);
            this.altEngel.Name = "altEngel";
            this.altEngel.Size = new System.Drawing.Size(100, 355);
            this.altEngel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altEngel.TabIndex = 2;
            this.altEngel.TabStop = false;
            this.altEngel.Click += new System.EventHandler(this.altEngel_Click);
            // 
            // kus
            // 
            this.kus.Image = global::Flappy_Bird.Properties.Resources.flappyBird;
            this.kus.Location = new System.Drawing.Point(95, 250);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(41, 31);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 1;
            this.kus.TabStop = false;
            // 
            // ustEngel
            // 
            this.ustEngel.Image = global::Flappy_Bird.Properties.Resources.pipeTop;
            this.ustEngel.Location = new System.Drawing.Point(329, -106);
            this.ustEngel.Name = "ustEngel";
            this.ustEngel.Size = new System.Drawing.Size(100, 274);
            this.ustEngel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustEngel.TabIndex = 0;
            this.ustEngel.TabStop = false;
            this.ustEngel.Click += new System.EventHandler(this.ustEngel_Click);
            // 
            // oyunSuresi
            // 
            this.oyunSuresi.Enabled = true;
            this.oyunSuresi.Interval = 20;
            this.oyunSuresi.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_Bird.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(169, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Flappy_Bird.Properties.Resources.clouds2;
            this.pictureBox2.Location = new System.Drawing.Point(435, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(511, 508);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.ustEngel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.puanText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.altEngel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altEngel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustEngel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ustEngel;
        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox altEngel;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label puanText;
        private System.Windows.Forms.Timer oyunSuresi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

