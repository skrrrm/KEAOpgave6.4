using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave6._4
{
    public partial class Form1 : Form
    {
        Button[] buttonArray = new Button[9]; // array for button-objects
        public Form1()
        {
            InitializeComponent();

            // initializing buttons in array
            buttonArray[0] = button1;
            buttonArray[1] = button2;
            buttonArray[2] = button3;
            buttonArray[3] = button4;
            buttonArray[4] = button5;
            buttonArray[5] = button6;
            buttonArray[6] = button7;
            buttonArray[7] = button8;
            buttonArray[8] = button9;
        }

        // Clears everything for a new game
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                buttonArray[i].Text = "";
                buttonArray[i].Enabled = true;
            }
        }

        // Disabling all buttons
        private void disableAll()
        {
            for (int i = 0; i < 9; i++)
            {
                buttonArray[i].Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            button1.Enabled = false;
            Win();
            Computer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            button2.Enabled = false;
            Win();
            Computer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            button3.Enabled = false;
            Win();
            Computer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            button4.Enabled = false;
            Win();
            Computer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            button5.Enabled = false;
            Win();
            Computer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            button6.Enabled = false;
            Win();
            Computer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            button7.Enabled = false;
            Win();
            Computer();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            button8.Enabled = false;
            Win();
            Computer();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            button9.Enabled = false;
            Win();
            Computer();
        }

        // 3-dimensional array - one spot in the array contains the 3 numbers
        // for Win conditions in tic tac toe - numbers correlate with buttons
        static private int[,] winCondition = new int[,]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        // Mehtod to check if you won the game
        private void Win()
        {
            // Going through all win conditions
            for (int i = 0; i < 8; i++)
            {
                // variables
                int a = winCondition[i, 0], b = winCondition[i, 1], c = winCondition[i, 2]; // each int is a spot on the win condition array
                Button b1 = buttonArray[a], b2 = buttonArray[b], b3 = buttonArray[c]; // assigning buttons to variables with potential win conditions 

                if (b1.Text == "" || b2.Text == "" || b3.Text == "") // if one button is blank
                    continue; // there is no reason to go through them

                // if all 3 buttons are X
                if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == "X")
                {
                    MessageBox.Show("You won!", "Winner!", MessageBoxButtons.OK);
                    disableAll();
                }
                // if all 3 buttons are O
                else if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text == "O")
                {
                    MessageBox.Show("You lose!", "Loser!", MessageBoxButtons.OK);
                    disableAll();
                }
            }
        }

        // Creating random object for use in Computer()
        Random randObj = new Random();

        // Method for computer to set its O on the board
        private void Computer()
        {
            // variables
            int field;
            int fieldsChecked = 0;

            // counting fields checked
            for (int i = 0; i < 9; i++)
            {
                if (buttonArray[i].Enabled == false)
                    fieldsChecked++;
            }

            // if fields checked is below 8
            if (fieldsChecked < 8)
            {
                do
                {
                    field = randObj.Next(9); // setting field to a random number between 1-9

                } while (buttonArray[field].Enabled == false); 

                buttonArray[field].Text = "O"; // using the random number to set O on a button
                buttonArray[field].Enabled = false; // using the random number to disable a button
            }
        }
    }
}
