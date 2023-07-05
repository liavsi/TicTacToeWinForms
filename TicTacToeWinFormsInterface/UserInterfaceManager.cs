using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeLogicManager;

namespace TicTacToeWinFormsInterface
{
    public class UserInterfaceManager
    {
        private FormGameSettings m_GameSetting;
        private FormTicTacToeMisere m_BoardUserInterface;
        private LogicManager m_Logics;

        public UserInterfaceManager()
        {
        }

        public void SetSettings()
        {
            m_GameSetting = new FormGameSettings();
            m_GameSetting.ShowDialog();
            if (m_GameSetting.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                int boardSize = m_GameSetting.BoardSize;
                string player1Name = m_GameSetting.Player1Name;
                string player2Name = m_GameSetting.Player2Name;
                m_Logics = new LogicManager(boardSize, m_GameSetting.NumOfPlayers,
                   player1Name, player2Name);
                m_BoardUserInterface = new FormTicTacToeMisere(boardSize,player1Name, player2Name);
                m_Logics.SymbolePlacedOnBoard += m_BoardUserInterface.Symbole_Placed;
                m_Logics.TurnChanged += m_BoardUserInterface.CurrentPlayer_Changed;
                m_Logics.ScoreChanged += m_BoardUserInterface.Score_Changed;
                signAllButtons();
            }
        }

        
        private void signAllButtons()
        {
            ButtonWithIndex[,] boardOfButton = m_BoardUserInterface.ButtonBoard;
            for(int i = 0; i < m_Logics.BoardSize; i++)
            {
                for (int j = 0; j < m_Logics.BoardSize; j++)
                {
                    boardOfButton[i, j].Click += ButtonWithIndex_Clicked;
                }
            }
        }

        private void ButtonWithIndex_Clicked(object sender, EventArgs e)
        {
            ButtonWithIndex button = sender as ButtonWithIndex;
            m_Logics.PlayersMove(button.Row, button.Column);
            bool isAnotherTurn = checkWinning();
            if (m_Logics.Player2.IsBot && isAnotherTurn)
            {
                m_Logics.ComputersMove();
                checkWinning();
            }
        }

        private  bool checkWinning()
        {
            bool isAnotherTurn = true;

            if (m_Logics.WinningStatus(out eCellValue winnerSymbole))
            {
                bool isAnotherRound = gameEndInterface(winnerSymbole);
                if (isAnotherRound)
                {
                    m_Logics.ResetGame();
                }
                else
                {
                    m_BoardUserInterface.Close();
                }
                isAnotherTurn = false;
            }

            return isAnotherTurn;
        }
        private bool gameEndInterface(eCellValue i_WinnerSymbole)
        {
            string genericMessage = "\nWould you like to play another round?";
            string uniqeMessage;
            string messageBoxTitle;

            if (i_WinnerSymbole == eCellValue.Empty)
            {
                uniqeMessage = "Tie!";
                messageBoxTitle = "A Tie!";
            }
            else
            {
                uniqeMessage = $"The winner is {m_Logics.GetPlayerBySymbole(i_WinnerSymbole).Name}";
                messageBoxTitle = "A Win!";
            }
            DialogResult anotherRound = MessageBox.Show(uniqeMessage + genericMessage,messageBoxTitle, MessageBoxButtons.YesNo);

            return (anotherRound == DialogResult.Yes) ? true : false;
        }
        public void PlayGame()
        {
            m_BoardUserInterface.ShowDialog();
        }

        
    }
}
