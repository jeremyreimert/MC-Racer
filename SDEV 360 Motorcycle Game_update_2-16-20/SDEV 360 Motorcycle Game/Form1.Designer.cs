namespace SDEV_360_Motorcycle_Game
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
            this.timerAcceleration = new System.Windows.Forms.Timer(this.components);
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.timerBackGround = new System.Windows.Forms.Timer(this.components);
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.timerDeceleration = new System.Windows.Forms.Timer(this.components);
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.picBoulder2 = new PictureBoxEx();
            this.picBike = new PictureBoxEx();
            this.picBoulder12 = new PictureBoxEx();
            this.picBoulder11 = new PictureBoxEx();
            this.picBoulder10 = new PictureBoxEx();
            this.picBoulder9 = new PictureBoxEx();
            this.picBoulder8 = new PictureBoxEx();
            this.picBoulder7 = new PictureBoxEx();
            this.picBoulder6 = new PictureBoxEx();
            this.picBoulder5 = new PictureBoxEx();
            this.picBoulder4 = new PictureBoxEx();
            this.picBoulder3 = new PictureBoxEx();
            this.picBoulder1 = new PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAcceleration
            // 
            this.timerAcceleration.Interval = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(57, 26);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(125, 50);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Start";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(188, 26);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(125, 50);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Pause";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerAnimate
            // 
            this.timerAnimate.Enabled = true;
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(93, 174);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(0, 0);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(12, 174);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(0, 0);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // timerBackGround
            // 
            this.timerBackGround.Interval = 1;
            this.timerBackGround.Tick += new System.EventHandler(this.timerBackGround_Tick);
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.ForeColor = System.Drawing.Color.Navy;
            this.lblYouWin.Location = new System.Drawing.Point(265, 267);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(360, 91);
            this.lblYouWin.TabIndex = 11;
            this.lblYouWin.Text = "You Win!";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Navy;
            this.lblGameOver.Location = new System.Drawing.Point(467, 148);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(472, 91);
            this.lblGameOver.TabIndex = 10;
            this.lblGameOver.Text = "Game Over!";
            // 
            // picBackGround
            // 
            this.picBackGround.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.background3;
            this.picBackGround.Location = new System.Drawing.Point(401, 81);
            this.picBackGround.Margin = new System.Windows.Forms.Padding(4);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(4800, 462);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 14;
            this.picBackGround.TabStop = false;
            // 
            // timerSpeed
            // 
            this.timerSpeed.Interval = 10000;
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Lime;
            this.txtScore.Location = new System.Drawing.Point(1111, 23);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(248, 53);
            this.txtScore.TabIndex = 26;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(925, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 48);
            this.label1.TabIndex = 27;
            this.label1.Text = "SCORE";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(319, 26);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 50);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picBoulder2
            // 
            this.picBoulder2.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoulder2.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder2.Location = new System.Drawing.Point(707, 332);
            this.picBoulder2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder2.Name = "picBoulder2";
            this.picBoulder2.Size = new System.Drawing.Size(100, 103);
            this.picBoulder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder2.TabIndex = 7;
            this.picBoulder2.TabStop = false;
            // 
            // picBike
            // 
            this.picBike.BackColor = System.Drawing.Color.Transparent;
            this.picBike.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.sprite_bike_01;
            this.picBike.Location = new System.Drawing.Point(31, 265);
            this.picBike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBike.Name = "picBike";
            this.picBike.Size = new System.Drawing.Size(147, 185);
            this.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBike.TabIndex = 17;
            this.picBike.TabStop = false;
            // 
            // picBoulder12
            // 
            this.picBoulder12.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder12.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder12.Location = new System.Drawing.Point(904, 162);
            this.picBoulder12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder12.Name = "picBoulder12";
            this.picBoulder12.Size = new System.Drawing.Size(100, 103);
            this.picBoulder12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder12.TabIndex = 25;
            this.picBoulder12.TabStop = false;
            // 
            // picBoulder11
            // 
            this.picBoulder11.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder11.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder11.Location = new System.Drawing.Point(773, 162);
            this.picBoulder11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder11.Name = "picBoulder11";
            this.picBoulder11.Size = new System.Drawing.Size(100, 103);
            this.picBoulder11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder11.TabIndex = 24;
            this.picBoulder11.TabStop = false;
            // 
            // picBoulder10
            // 
            this.picBoulder10.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder10.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder10.Location = new System.Drawing.Point(645, 162);
            this.picBoulder10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder10.Name = "picBoulder10";
            this.picBoulder10.Size = new System.Drawing.Size(100, 103);
            this.picBoulder10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder10.TabIndex = 23;
            this.picBoulder10.TabStop = false;
            // 
            // picBoulder9
            // 
            this.picBoulder9.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder9.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder9.Location = new System.Drawing.Point(525, 162);
            this.picBoulder9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder9.Name = "picBoulder9";
            this.picBoulder9.Size = new System.Drawing.Size(100, 103);
            this.picBoulder9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder9.TabIndex = 22;
            this.picBoulder9.TabStop = false;
            // 
            // picBoulder8
            // 
            this.picBoulder8.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder8.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder8.Location = new System.Drawing.Point(400, 162);
            this.picBoulder8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder8.Name = "picBoulder8";
            this.picBoulder8.Size = new System.Drawing.Size(100, 103);
            this.picBoulder8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder8.TabIndex = 21;
            this.picBoulder8.TabStop = false;
            // 
            // picBoulder7
            // 
            this.picBoulder7.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder7.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder7.Location = new System.Drawing.Point(1184, 353);
            this.picBoulder7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder7.Name = "picBoulder7";
            this.picBoulder7.Size = new System.Drawing.Size(100, 103);
            this.picBoulder7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder7.TabIndex = 20;
            this.picBoulder7.TabStop = false;
            // 
            // picBoulder6
            // 
            this.picBoulder6.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder6.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder6.Location = new System.Drawing.Point(1319, 199);
            this.picBoulder6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder6.Name = "picBoulder6";
            this.picBoulder6.Size = new System.Drawing.Size(100, 103);
            this.picBoulder6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder6.TabIndex = 19;
            this.picBoulder6.TabStop = false;
            // 
            // picBoulder5
            // 
            this.picBoulder5.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder5.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder5.Location = new System.Drawing.Point(904, 366);
            this.picBoulder5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder5.Name = "picBoulder5";
            this.picBoulder5.Size = new System.Drawing.Size(100, 103);
            this.picBoulder5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder5.TabIndex = 18;
            this.picBoulder5.TabStop = false;
            // 
            // picBoulder4
            // 
            this.picBoulder4.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder4.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder4.Location = new System.Drawing.Point(1333, 345);
            this.picBoulder4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder4.Name = "picBoulder4";
            this.picBoulder4.Size = new System.Drawing.Size(85, 103);
            this.picBoulder4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder4.TabIndex = 9;
            this.picBoulder4.TabStop = false;
            // 
            // picBoulder3
            // 
            this.picBoulder3.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder3.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder3.Location = new System.Drawing.Point(1028, 388);
            this.picBoulder3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder3.Name = "picBoulder3";
            this.picBoulder3.Size = new System.Drawing.Size(100, 103);
            this.picBoulder3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder3.TabIndex = 8;
            this.picBoulder3.TabStop = false;
            // 
            // picBoulder1
            // 
            this.picBoulder1.BackColor = System.Drawing.Color.Transparent;
            this.picBoulder1.Image = global::SDEV_360_Motorcycle_Game.Properties.Resources.boulder;
            this.picBoulder1.Location = new System.Drawing.Point(400, 382);
            this.picBoulder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoulder1.Name = "picBoulder1";
            this.picBoulder1.Size = new System.Drawing.Size(100, 103);
            this.picBoulder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoulder1.TabIndex = 6;
            this.picBoulder1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1443, 558);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picBoulder2);
            this.Controls.Add(this.picBike);
            this.Controls.Add(this.picBoulder12);
            this.Controls.Add(this.picBoulder11);
            this.Controls.Add(this.picBoulder10);
            this.Controls.Add(this.picBoulder9);
            this.Controls.Add(this.picBoulder8);
            this.Controls.Add(this.picBoulder7);
            this.Controls.Add(this.picBoulder6);
            this.Controls.Add(this.picBoulder5);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.picBoulder4);
            this.Controls.Add(this.picBoulder3);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.picBoulder1);
            this.Controls.Add(this.picBackGround);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1461, 605);
            this.MinimumSize = new System.Drawing.Size(1461, 605);
            this.Name = "Form1";
            this.Text = "Motorcycle Racer";
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoulder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGo;
        public System.Windows.Forms.Timer timerAcceleration;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        public System.Windows.Forms.Timer timerBackGround;
        //private System.Windows.Forms.PictureBox pictureBoxEx2;
        //private System.Windows.Forms.PictureBox pictureBoxEx1;
        //private System.Windows.Forms.PictureBox pictureBoxEx4;
        //private System.Windows.Forms.PictureBox pictureBoxEx3;
        private PictureBoxEx picBoulder1;
        private PictureBoxEx picBoulder2;
        private PictureBoxEx picBoulder3;
        private PictureBoxEx picBoulder4;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox picBackGround;
        //public System.Windows.Forms.PictureBox picBike;
        public System.Windows.Forms.Timer timerDeceleration;
        private PictureBoxEx picBike;
        private PictureBoxEx picBoulder5;
        private PictureBoxEx picBoulder6;
        private PictureBoxEx picBoulder7;
        private PictureBoxEx picBoulder8;
        private PictureBoxEx picBoulder9;
        private PictureBoxEx picBoulder10;
        private PictureBoxEx picBoulder11;
        private PictureBoxEx picBoulder12;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}

