using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeWinFormsInterface
{
    public partial class FormGameSettings : Form
    {
        const string c_DefaultPlayer2Name = "Computer";
        public FormGameSettings()
        {
            InitializeComponent();
            textBoxPlayer2.Text = $"[{c_DefaultPlayer2Name}]";
            numericUpDownLeft.Minimum = 4;
            numericUpDownLeft.Maximum = 10;
            numericUpDownLeft.Value = 4;
        }

        public string Player1Name
        {
            get { return textBoxPlayer1.Text; }
        }

        public string Player2Name
        {
            get
            {
                string player2Name;
                if (checkBoxPlayer2.Checked)
                {
                    player2Name = textBoxPlayer2.Text;
                }
                else
                {
                    player2Name = c_DefaultPlayer2Name;
                }
                return player2Name;
            }
        }

        public int BoardSize
        {
            get
            {
                return (int)numericUpDownLeft.Value;
            }
        }

        public int NumOfPlayers
        {
            get
            {
                return checkBoxPlayer2.Checked ? 2 : 1;
            }
        }

        private void numericUpDownRight_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownLeft.Value = numericUpDownRight.Value;
        }



        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer2.Text = "";
                textBoxPlayer2.BackColor = Color.White;
            }
            else
            {
                textBoxPlayer2.Enabled = false;
                textBoxPlayer2.Text = $"[{c_DefaultPlayer2Name}]";
                textBoxPlayer2.BackColor = Color.LightGray;
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Validator.isValidLoginInfo(sender);
            this.DialogResult = DialogResult.OK;
        }

        private void numericUpDownLeft_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRight.Value = numericUpDownLeft.Value;
        }
    }
}
