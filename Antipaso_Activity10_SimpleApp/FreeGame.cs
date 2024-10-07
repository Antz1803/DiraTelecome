using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antipaso_Activity10_SimpleApp
{
    public partial class FreeGame : Form
    {
        // variable of my fields to make a method
        public bool up, down, hit, startGame;
        public Point start = new Point(554, 132);
        public Point end = new Point(-25, 0);
        public int speed;
        public Random rStart = new Random();
        public FreeGame()
        {
            InitializeComponent();
        }

        #region Button Start and Exit
        private void btnStart_Click(object sender, EventArgs e)
        {
            startGame = true;
            pnlStartingScreen.Visible = false;
            pnlStartingScreen.Enabled = false;
        }
        private void bntExit_Click(object sender, EventArgs e)
        {
            frmDiraHome diraHome = new frmDiraHome();
            diraHome.Show();
            this.Close();
        }
        #endregion

        #region movement of Fighter jet 
        // Move of the Fighter Jet
        private void mov(object sender, EventArgs e)
        {
            if (up && ptbfighterjet.Top > 10)
                ptbfighterjet.Top -= 10;
            if (down && ptbfighterjet.Top < 244)
                ptbfighterjet.Top += 10;
        }

        // fighter jet arrow keys
        private void FreeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up = !false;
            if (e.KeyCode == Keys.Down)
                down = !false;
        }
        private void FreeGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
        }
        #endregion

        // The form have an methods
        private void FreeGame_Load(object sender, EventArgs e)
        {
            up = false; down = false;
            hit = false; speed = 15;
            pnlStartingScreen.Visible = true;
            startGame = false;
        }

        #region movement of the enemy 
        private void EnemyMove(object sender, EventArgs e)
        {
            if (startGame == true)
            {
                int scr = Convert.ToInt32(lblscore.Text);
                if (hit)
                {
                    pnlStartingScreen.Enabled = true;
                    finalscore.Text = $"SCORE: {scr}";
                    pnlStartingScreen.Visible = true;
                    hit = false;
                    startGame = false;
                    scr = 0;
                    lblscore.Text = "0";
                    Point Y = new Point(start.X, rStart.Next(10, 300));
                    pnlenemy.Location = Y;

                }
                //Parts of the code to detect the object collision  
                if (pnlenemy.Left > -21 && hit == false)
                {
                    pnlenemy.Left -= speed;
                    if ((pnlenemy.Location.Y + 15) >= (ptbfighterjet.Location.Y) && (pnlenemy.Location.Y - 45) <= (ptbfighterjet.Location.Y)
                        && (pnlenemy.Location.X + 15) >= (ptbfighterjet.Location.X) && (pnlenemy.Location.X - 15) <= (ptbfighterjet.Location.X))
                        hit = true;
                }
                //If the enemy passes to the wall, the character have a score
                if (pnlenemy.Location.X < 1)
                {
                    scr += 1;
                    Point Y = new Point(start.X, rStart.Next(10, 300));
                    pnlenemy.Location = Y;
                    lblscore.Text = scr.ToString();
                }
                if (scr < 9)
                    speed = 15;
                if (scr > 9)
                    speed = 25;
                if (scr > 14)
                    speed = 30;
                if (scr > 19)
                    speed = 40;
            }
        }
        #endregion
    }
}
