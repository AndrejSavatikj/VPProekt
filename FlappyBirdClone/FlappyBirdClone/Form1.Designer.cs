namespace FlappyBirdClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbGameOver = new System.Windows.Forms.Label();
            this.grass1 = new System.Windows.Forms.PictureBox();
            this.pipeTopPb = new System.Windows.Forms.PictureBox();
            this.birdPb = new System.Windows.Forms.PictureBox();
            this.groundPb = new System.Windows.Forms.PictureBox();
            this.pipeBottomPb = new System.Windows.Forms.PictureBox();
            this.cloud = new System.Windows.Forms.PictureBox();
            this.grass4 = new System.Windows.Forms.PictureBox();
            this.grass5 = new System.Windows.Forms.PictureBox();
            this.lbGameOver2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Coral;
            this.lbScore.Font = new System.Drawing.Font("Macedonian Tms", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(12, 542);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(121, 24);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Rezultat: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.Font = new System.Drawing.Font("Macedonian Tms", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.White;
            this.lbGameOver.Location = new System.Drawing.Point(80, 226);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(0, 43);
            this.lbGameOver.TabIndex = 5;
            // 
            // grass1
            // 
            this.grass1.Image = global::FlappyBirdClone.Properties.Resources.grass__1_;
            this.grass1.Location = new System.Drawing.Point(16, 453);
            this.grass1.Name = "grass1";
            this.grass1.Size = new System.Drawing.Size(55, 50);
            this.grass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass1.TabIndex = 10;
            this.grass1.TabStop = false;
            // 
            // pipeTopPb
            // 
            this.pipeTopPb.Image = global::FlappyBirdClone.Properties.Resources.pipeTop;
            this.pipeTopPb.Location = new System.Drawing.Point(312, -33);
            this.pipeTopPb.Name = "pipeTopPb";
            this.pipeTopPb.Size = new System.Drawing.Size(100, 188);
            this.pipeTopPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopPb.TabIndex = 1;
            this.pipeTopPb.TabStop = false;
            // 
            // birdPb
            // 
            this.birdPb.Image = global::FlappyBirdClone.Properties.Resources.bird;
            this.birdPb.Location = new System.Drawing.Point(88, 147);
            this.birdPb.Name = "birdPb";
            this.birdPb.Size = new System.Drawing.Size(57, 54);
            this.birdPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdPb.TabIndex = 0;
            this.birdPb.TabStop = false;
            // 
            // groundPb
            // 
            this.groundPb.Image = global::FlappyBirdClone.Properties.Resources.ground;
            this.groundPb.Location = new System.Drawing.Point(-11, 502);
            this.groundPb.Name = "groundPb";
            this.groundPb.Size = new System.Drawing.Size(496, 179);
            this.groundPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundPb.TabIndex = 3;
            this.groundPb.TabStop = false;
            // 
            // pipeBottomPb
            // 
            this.pipeBottomPb.Image = global::FlappyBirdClone.Properties.Resources.pipeBottom;
            this.pipeBottomPb.Location = new System.Drawing.Point(312, 329);
            this.pipeBottomPb.Name = "pipeBottomPb";
            this.pipeBottomPb.Size = new System.Drawing.Size(100, 193);
            this.pipeBottomPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomPb.TabIndex = 2;
            this.pipeBottomPb.TabStop = false;
            // 
            // cloud
            // 
            this.cloud.BackColor = System.Drawing.Color.Transparent;
            this.cloud.Image = global::FlappyBirdClone.Properties.Resources.cloud6;
            this.cloud.Location = new System.Drawing.Point(88, -33);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(202, 95);
            this.cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud.TabIndex = 6;
            this.cloud.TabStop = false;
            // 
            // grass4
            // 
            this.grass4.Image = global::FlappyBirdClone.Properties.Resources.grass__1_;
            this.grass4.Location = new System.Drawing.Point(235, 452);
            this.grass4.Name = "grass4";
            this.grass4.Size = new System.Drawing.Size(55, 50);
            this.grass4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass4.TabIndex = 11;
            this.grass4.TabStop = false;
            // 
            // grass5
            // 
            this.grass5.Image = global::FlappyBirdClone.Properties.Resources.grass__1_;
            this.grass5.Location = new System.Drawing.Point(425, 452);
            this.grass5.Name = "grass5";
            this.grass5.Size = new System.Drawing.Size(55, 50);
            this.grass5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass5.TabIndex = 14;
            this.grass5.TabStop = false;
            // 
            // lbGameOver2
            // 
            this.lbGameOver2.AutoSize = true;
            this.lbGameOver2.Font = new System.Drawing.Font("Macedonian Tms", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver2.ForeColor = System.Drawing.Color.White;
            this.lbGameOver2.Location = new System.Drawing.Point(12, 282);
            this.lbGameOver2.Name = "lbGameOver2";
            this.lbGameOver2.Size = new System.Drawing.Size(0, 34);
            this.lbGameOver2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 575);
            this.Controls.Add(this.lbGameOver2);
            this.Controls.Add(this.grass5);
            this.Controls.Add(this.grass4);
            this.Controls.Add(this.grass1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.pipeTopPb);
            this.Controls.Add(this.birdPb);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.groundPb);
            this.Controls.Add(this.pipeBottomPb);
            this.Controls.Add(this.cloud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Весела птица";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox birdPb;
        private System.Windows.Forms.PictureBox pipeTopPb;
        private System.Windows.Forms.PictureBox pipeBottomPb;
        private System.Windows.Forms.PictureBox groundPb;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.PictureBox cloud;
        private System.Windows.Forms.PictureBox grass1;
        private System.Windows.Forms.PictureBox grass4;
        private System.Windows.Forms.PictureBox grass5;
        private System.Windows.Forms.Label lbGameOver2;
    }
}

