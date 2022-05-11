using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboardgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                pacman.Left -= 5;
            }
            else if (e.KeyData == Keys.Right)
            {
                pacman.Left += 5;
            }
            else if (e.KeyData == Keys.Up)
            {
                pacman.Top -= 5;
            }
            else if (e.KeyData == Keys.Down)
            {
                pacman.Top += 5;
            }
            GameOver();
        }
        private void GameOver()
        {
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "ghost" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            MessageBox.Show("you lose");
                            break;
                        }    
                    }
                }
            }
        }
    }

}
