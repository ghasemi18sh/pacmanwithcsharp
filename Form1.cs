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
        int y = 0;

        public Form1()
        {
            InitializeComponent();
            snake.BackColor = Color.Transparent;
            apple1.BackColor = Color.Transparent;
            apple2.BackColor = Color.Transparent;
            apple3.BackColor = Color.Transparent;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                snake.Left -= 5;
            }
            else if (e.KeyData == Keys.Right)
            {
                snake.Left += 5;
            }
            else if (e.KeyData == Keys.Up)
            {
                snake.Top -= 5;
            }
            else if (e.KeyData == Keys.Down)
            {
                snake.Top += 5;
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

                        if (snake.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            MessageBox.Show("You Got it");
                            y += 1;
                            if (y == 3)
                            {
                                MessageBox.Show("You Win");

                            }
                            break;
                      
                        }    
                     
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
