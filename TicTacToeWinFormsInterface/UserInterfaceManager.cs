using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                m_Logics.SymbolePlaced += m_BoardUserInterface.Symbole_Placed;
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
        }

        public void PlayGame()
        {
            m_BoardUserInterface.ShowDialog();
        }

        
    }
}
