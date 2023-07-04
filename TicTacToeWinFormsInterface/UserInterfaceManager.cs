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
        //private FormGameBoard m_BoardUserInterface;
        private LogicManager m_Logics;

        public UserInterfaceManager()
        {
            m_GameSetting = new FormGameSettings();
        }

        public void SetSettings()
        {
            m_GameSetting.ShowDialog();
            if (m_GameSetting.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                m_Logics = new LogicManager(m_GameSetting.BoardSize, m_GameSetting.NumOfPlayers,
                   m_GameSetting.Player1Name, m_GameSetting.Player2Name);
            }


        }
    }
}
