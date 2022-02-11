using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool turn = true;               // true = player1(X)    ,   false = plater2(O)
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the buttons to place your Mark \n( X or O ) on that button \n\nBy Umer Ahmed", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn_count++;
            turn = !turn;
            b.Enabled = false;
            check();
            if (turn_count == 9)
            {
                disable_b();
                MessageBox.Show("Draw !");
                Application.Restart();
            }
        }


        private void check()
        {
            bool Winner = false;

            if((b1.Text==b2.Text)&&(b2.Text == b3.Text)&&(!b1.Enabled)){
                Winner = true;
            }

            if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
            {
                Winner = true;
            }

            if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
            {
                Winner = true;
            }

            if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
            {
                Winner = true;
            }

            if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
            {
                Winner = true;
            }

            if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
            {
                Winner = true;
            }

            if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
            {
                Winner = true;
            }

            if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
            {
                Winner = true;
            }

            if (Winner)
            {
                disable_b();
                String winner = "";

                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }

                MessageBox.Show(winner + " wins !");
                Application.Restart();
            }
        }


        private void disable_b()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure that \n you want to start a \n new game", "New Game");
            Application.Restart();
        }
    }
}
