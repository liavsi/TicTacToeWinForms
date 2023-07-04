using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLogicManager
{
    public class Player
    {
        private readonly eCellValue r_Symbole;
        private int m_Score = 0;
        private readonly bool r_IsBot;
        private readonly string r_Name;



        public Player(eCellValue i_Symbole, bool i_IsBot, string i_PlayerName)
        {
            this.r_Symbole = i_Symbole;
            this.r_IsBot = i_IsBot;
            this.r_Name = i_PlayerName;
        }


        public void IncrementScore()
        {
            m_Score++;
        }
        public bool IsBot
        {
            get
            {
                return r_IsBot;
            }
        }
        public eCellValue Symbole
        {
            get
            {
                return r_Symbole;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }
        }

        public string Name
        {
            get
            {
                return r_Name;
            }

        }
        public override string ToString()
        {
            return $"Name: {Name} Score: {Score} Symbole: {Symbole} ";
        }
    }
}
