using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            X,O 
        }

        Player currentPlayer;

        Random rand = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;



        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {

            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                CheckGame();
                CPUtimer.Stop();


            }





        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Green;
            buttons.Remove(button);
            CheckGame();
            CPUtimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if(button1.Text=="X" && button2.Text=="X" && button3.Text=="X"||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                CPUtimer.Stop();
                MessageBox.Show("Player Wins");
                playerWinCount++;
                label1.Text = "Player Wins:" + playerWinCount;
                RestartGame();
            }

            else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                CPUtimer.Stop();
                MessageBox.Show("Cpu Wins");
                CPUWinCount++;
                label2.Text = "Cpu Wins:" + CPUWinCount;
                RestartGame();
            }
        }

        private void RestartGame()
        {
             buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            
            foreach(Button x in buttons)
            {
                x.Enabled = true;
                x.Text ="?";
                x.BackColor = DefaultBackColor;

            }


        }
    }
}
