namespace Antipaso_Activity10_SimpleApp
{
    partial class FreeGame
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
            this.pnlStartingScreen = new System.Windows.Forms.Panel();
            this.bntExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.finalscore = new System.Windows.Forms.Label();
            this.lblscores = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.pnlbackground = new System.Windows.Forms.Panel();
            this.pnlenemy = new System.Windows.Forms.Panel();
            this.ptbfighterjet = new System.Windows.Forms.PictureBox();
            this.tmrCharracter = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.lblDiraGame = new System.Windows.Forms.Label();
            this.pnlStartingScreen.SuspendLayout();
            this.pnlbackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfighterjet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStartingScreen
            // 
            this.pnlStartingScreen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlStartingScreen.Controls.Add(this.bntExit);
            this.pnlStartingScreen.Controls.Add(this.btnStart);
            this.pnlStartingScreen.Controls.Add(this.finalscore);
            this.pnlStartingScreen.Location = new System.Drawing.Point(117, 67);
            this.pnlStartingScreen.Name = "pnlStartingScreen";
            this.pnlStartingScreen.Size = new System.Drawing.Size(230, 190);
            this.pnlStartingScreen.TabIndex = 14;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(12, 125);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(206, 62);
            this.bntExit.TabIndex = 2;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // finalscore
            // 
            this.finalscore.AutoSize = true;
            this.finalscore.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalscore.Location = new System.Drawing.Point(34, 14);
            this.finalscore.Name = "finalscore";
            this.finalscore.Size = new System.Drawing.Size(0, 42);
            this.finalscore.TabIndex = 1;
            // 
            // lblscores
            // 
            this.lblscores.AutoSize = true;
            this.lblscores.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscores.Location = new System.Drawing.Point(159, 16);
            this.lblscores.Name = "lblscores";
            this.lblscores.Size = new System.Drawing.Size(84, 27);
            this.lblscores.TabIndex = 13;
            this.lblscores.Text = "SCORE:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(249, 16);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(24, 27);
            this.lblscore.TabIndex = 12;
            this.lblscore.Text = "0";
            // 
            // pnlbackground
            // 
            this.pnlbackground.BackColor = System.Drawing.Color.Silver;
            this.pnlbackground.Controls.Add(this.lblscore);
            this.pnlbackground.Controls.Add(this.lblscores);
            this.pnlbackground.Controls.Add(this.pnlStartingScreen);
            this.pnlbackground.Controls.Add(this.pnlenemy);
            this.pnlbackground.Controls.Add(this.ptbfighterjet);
            this.pnlbackground.Location = new System.Drawing.Point(14, 25);
            this.pnlbackground.Name = "pnlbackground";
            this.pnlbackground.Size = new System.Drawing.Size(466, 336);
            this.pnlbackground.TabIndex = 15;
            // 
            // pnlenemy
            // 
            this.pnlenemy.BackColor = System.Drawing.Color.Black;
            this.pnlenemy.Location = new System.Drawing.Point(451, 126);
            this.pnlenemy.Name = "pnlenemy";
            this.pnlenemy.Size = new System.Drawing.Size(78, 28);
            this.pnlenemy.TabIndex = 16;
            // 
            // ptbfighterjet
            // 
            this.ptbfighterjet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbfighterjet.Image = global::Antipaso_Activity10_SimpleApp.Properties.Resources.fighter_jet_1_0;
            this.ptbfighterjet.Location = new System.Drawing.Point(7, 253);
            this.ptbfighterjet.Name = "ptbfighterjet";
            this.ptbfighterjet.Size = new System.Drawing.Size(120, 83);
            this.ptbfighterjet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfighterjet.TabIndex = 15;
            this.ptbfighterjet.TabStop = false;
            // 
            // tmrCharracter
            // 
            this.tmrCharracter.Enabled = true;
            this.tmrCharracter.Interval = 20;
            this.tmrCharracter.Tick += new System.EventHandler(this.mov);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 20;
            this.tmrEnemy.Tick += new System.EventHandler(this.EnemyMove);
            // 
            // lblDiraGame
            // 
            this.lblDiraGame.AutoSize = true;
            this.lblDiraGame.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiraGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDiraGame.Location = new System.Drawing.Point(148, -1);
            this.lblDiraGame.Name = "lblDiraGame";
            this.lblDiraGame.Size = new System.Drawing.Size(201, 23);
            this.lblDiraGame.TabIndex = 17;
            this.lblDiraGame.Text = "Dira Game Fighter Jet";
            // 
            // FreeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.lblDiraGame);
            this.Controls.Add(this.pnlbackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FreeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreeGame";
            this.Load += new System.EventHandler(this.FreeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FreeGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FreeGame_KeyUp);
            this.pnlStartingScreen.ResumeLayout(false);
            this.pnlStartingScreen.PerformLayout();
            this.pnlbackground.ResumeLayout(false);
            this.pnlbackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfighterjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStartingScreen;
        private System.Windows.Forms.Label finalscore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblscores;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Panel pnlbackground;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.PictureBox ptbfighterjet;
        private System.Windows.Forms.Timer tmrCharracter;
        private System.Windows.Forms.Panel pnlenemy;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Label lblDiraGame;
    }
}