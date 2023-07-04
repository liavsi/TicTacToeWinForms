using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeLogicManager;

namespace TicTacToeWinFormsInterface
{
    public partial class FormTicTacToeMisere : Form
    {
        private TableLayoutPanel m_TableLayoutPanel;
        ButtonWithIndex[,] m_Buttons;

        public FormTicTacToeMisere(int i_size, string i_Player1Name, string i_Player2Name)
        {
            InitializeComponent();
            this.SuspendLayout();
            this.m_TableLayoutPanel = new TableLayoutPanel();
            this.m_TableLayoutPanel.ColumnCount = i_size;
            this.m_TableLayoutPanel.RowCount = i_size;
            float rowColPrecetage = 100f / i_size;
            m_Buttons = new ButtonWithIndex[i_size,i_size];
            for(int i = 0; i < i_size; i++)
            {
                this.m_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowColPrecetage));
                this.m_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, rowColPrecetage));
                for (int j = 0; j < i_size; j++)
                {
                    ButtonWithIndex button = new ButtonWithIndex();
                    button.Name = $"button{i},{j}"; 
                    button.Dock = DockStyle.Fill;
                    button.Row = i;
                    button.Column = j;
                    button.TabIndex = i* i_size +j;
                    m_Buttons[i,j] = button;
                    
                    this.m_TableLayoutPanel.Controls.Add(button,i, j);
                }
            }
            this.m_TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.m_TableLayoutPanel.Size = this.splitContainer.Panel1.ClientSize;
            this.m_TableLayoutPanel.Dock =DockStyle.Fill;
            this.m_TableLayoutPanel.Location = new Point(0, 0);
            this.m_TableLayoutPanel.Name = "tableLayoutPanel";
            this.m_TableLayoutPanel.TabIndex = 0;
            this.splitContainer.Panel1.Controls.Add(m_TableLayoutPanel);
            this.labelPlayer1Name.Text = $"{i_Player1Name}:";
            this.labelPlayer2Name.Text = $"{i_Player2Name}:";

            //todo make this more oop style
            this.labelPlayer1Score.Text = "0";
            this.labelPlayer2Score.Text = "0";

        }

        internal void Score_Changed(Player i_Winner)
        {
            if (i_Winner.Symbole == TicTacToeLogicManager.eCellValue.X)
            {
                labelPlayer1Score.Text = i_Winner.Score.ToString();
            }
            else
            {
                labelPlayer2Score.Text = i_Winner.Score.ToString();
            }
        }

        public ButtonWithIndex[,] ButtonBoard
        {
            get
            {
                return m_Buttons;
            }
        }

        public void Symbole_Placed(int i_iIndex, int i_jIndex, TicTacToeLogicManager.eCellValue i_Symbole)
        {
            if (i_Symbole == TicTacToeLogicManager.eCellValue.Empty)
            {
                m_Buttons[i_iIndex, i_jIndex].Enabled = true;
                m_Buttons[i_iIndex, i_jIndex].Text = "";
            }
            else
            {
                m_Buttons[i_iIndex, i_jIndex].Text = i_Symbole.ToString();
                m_Buttons[i_iIndex, i_jIndex].Enabled = false;
            }
        }

        public void CurrentPlayer_Changed(TicTacToeLogicManager.Player i_CurrentPlayer)
        {
            if (i_CurrentPlayer.Symbole == TicTacToeLogicManager.eCellValue.X)
            {
                labelPlayer1Name.Font = new Font(labelPlayer1Name.Font,FontStyle.Bold);
                labelPlayer1Score.Font = new Font(labelPlayer1Score.Font,FontStyle.Bold);
                labelPlayer2Name.Font = new Font(labelPlayer2Name.Font,FontStyle.Regular);
                labelPlayer2Score.Font = new Font(labelPlayer2Score.Font, FontStyle.Regular);
            }
            else
            {
                labelPlayer2Name.Font = new Font(labelPlayer1Name.Font, FontStyle.Bold);
                labelPlayer2Score.Font = new Font(labelPlayer1Score.Font, FontStyle.Bold);
                labelPlayer1Name.Font = new Font(labelPlayer2Name.Font, FontStyle.Regular);
                labelPlayer1Score.Font = new Font(labelPlayer2Score.Font, FontStyle.Regular);
            }
        }


    }
}
