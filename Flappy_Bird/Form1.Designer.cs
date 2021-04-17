
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeButtom = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-1, 373);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(800, 80);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipeButtom
            // 
            this.pipeButtom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeButtom.Location = new System.Drawing.Point(559, 239);
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(100, 135);
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 0;
            this.pipeButtom.TabStop = false;
            this.pipeButtom.Click += new System.EventHandler(this.pipeButtom_Click);
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeUp.Location = new System.Drawing.Point(559, 0);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(87, 148);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 0;
            this.pipeUp.TabStop = false;
            this.pipeUp.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(192, 129);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(69, 60);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(9, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(98, 25);
            this.scoreText.TabIndex = 1;
            this.scoreText.Tag = "";
            this.scoreText.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.pipeButtom);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeButtom;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

