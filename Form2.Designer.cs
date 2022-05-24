namespace Project_MIP
{
    partial class Form2
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
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.Game_menu = new System.Windows.Forms.GroupBox();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.lyf_1 = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lyf_2 = new System.Windows.Forms.PictureBox();
            this.lyf_3 = new System.Windows.Forms.PictureBox();
            this.Game_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_score.Location = new System.Drawing.Point(12, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(151, 41);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score: 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Elephant", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_over.Location = new System.Drawing.Point(83, 283);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(287, 56);
            this.lbl_over.TabIndex = 6;
            this.lbl_over.Text = "Game Over!";
            // 
            // Game_menu
            // 
            this.Game_menu.BackColor = System.Drawing.Color.Black;
            this.Game_menu.Controls.Add(this.lbl_quit);
            this.Game_menu.Controls.Add(this.lbl_restart);
            this.Game_menu.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_menu.ForeColor = System.Drawing.Color.Fuchsia;
            this.Game_menu.Location = new System.Drawing.Point(36, 122);
            this.Game_menu.Name = "Game_menu";
            this.Game_menu.Size = new System.Drawing.Size(407, 149);
            this.Game_menu.TabIndex = 8;
            this.Game_menu.TabStop = false;
            this.Game_menu.Text = "Menu";
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quit.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quit.ForeColor = System.Drawing.Color.Red;
            this.lbl_quit.Location = new System.Drawing.Point(85, 89);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(235, 45);
            this.lbl_quit.TabIndex = 7;
            this.lbl_quit.Text = "Quit game";
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restart.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.ForeColor = System.Drawing.Color.Red;
            this.lbl_restart.Location = new System.Drawing.Point(97, 28);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(200, 45);
            this.lbl_restart.TabIndex = 6;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click_1);
            // 
            // lyf_1
            // 
            this.lyf_1.Location = new System.Drawing.Point(350, 9);
            this.lyf_1.Name = "lyf_1";
            this.lyf_1.Size = new System.Drawing.Size(29, 28);
            this.lyf_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lyf_1.TabIndex = 9;
            this.lyf_1.TabStop = false;
            // 
            // ship
            // 
            this.ship.Image = global::Project_MIP.Properties.Resources.ship_gif;
            this.ship.Location = new System.Drawing.Point(320, 89);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(50, 27);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // alien
            // 
            this.alien.Image = global::Project_MIP.Properties.Resources.alien_gif;
            this.alien.Location = new System.Drawing.Point(52, 56);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(60, 60);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::Project_MIP.Properties.Resources.player_img;
            this.player.Location = new System.Drawing.Point(192, 323);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(46, 45);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_MIP.Properties.Resources.Stars_img;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_MIP.Properties.Resources.Stars_img;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lyf_2
            // 
            this.lyf_2.Image = global::Project_MIP.Properties.Resources.life;
            this.lyf_2.Location = new System.Drawing.Point(385, 9);
            this.lyf_2.Name = "lyf_2";
            this.lyf_2.Size = new System.Drawing.Size(29, 28);
            this.lyf_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lyf_2.TabIndex = 10;
            this.lyf_2.TabStop = false;
            // 
            // lyf_3
            // 
            this.lyf_3.Image = global::Project_MIP.Properties.Resources.life;
            this.lyf_3.Location = new System.Drawing.Point(420, 9);
            this.lyf_3.Name = "lyf_3";
            this.lyf_3.Size = new System.Drawing.Size(29, 28);
            this.lyf_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lyf_3.TabIndex = 11;
            this.lyf_3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.lyf_3);
            this.Controls.Add(this.lyf_2);
            this.Controls.Add(this.lyf_1);
            this.Controls.Add(this.Game_menu);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.Game_menu.ResumeLayout(false);
            this.Game_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.GroupBox Game_menu;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.PictureBox lyf_1;
        private System.Windows.Forms.PictureBox lyf_2;
        private System.Windows.Forms.PictureBox lyf_3;
    }
}