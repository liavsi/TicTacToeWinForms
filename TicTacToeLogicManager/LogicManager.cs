using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLogicManager
{
    public class LogicManager
    {
        private Player m_Player1, m_Player2;
        private Player m_CurrentPlayer;
        private TicTacToeBoard m_Board;
        public event Action<int, int, eCellValue> SymbolePlacedOnBoard;
        public event Action<Player> TurnChanged;
        public event Action<Player> ScoreChanged;

        public LogicManager(int i_sizeOfBoard, int i_numOfPlayers, string i_Player1Name, string i_Player2Name = "Computer")
        {
            m_Board = new TicTacToeBoard(i_sizeOfBoard);
            m_Board.SymbolePlaced += this.OnSymbolePlaced;
            const bool v_isNotBot = false;

            if (i_numOfPlayers == 1)
            {
                m_Player1 = new Player(eCellValue.X, v_isNotBot, i_Player1Name);
                m_Player2 = new Player(eCellValue.O, !v_isNotBot, i_Player2Name);
            }
            else
            {
                m_Player1 = new Player(eCellValue.X, v_isNotBot, i_Player1Name);
                m_Player2 = new Player(eCellValue.O, v_isNotBot, i_Player2Name);
            }
            m_CurrentPlayer = m_Player1;
        }
        public Player CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }
            set
            {
                m_CurrentPlayer = value;
            }
        }
        public Player Player1
        {
            get
            {
                return m_Player1;
            }
        }
        public Player Player2
        {
            get
            {
                return m_Player2;
            }
        }
        public TicTacToeBoard BoardState
        {
            get
            {
                return m_Board;
            }
        }
        public int BoardSize
        {
            get
            {
                return m_Board.Size;
            }
        }
        public Player GetPlayerBySymbole(eCellValue i_symbole)
        {
            Player player = null;

            if (i_symbole == eCellValue.X)
            {
                player = m_Player1;
            }
            else if (i_symbole == eCellValue.O)
            {
                player = m_Player2;
            }

            return player;
        }
        public bool PlayersMove(int i_iIndex, int i_jIndex)
        {
            bool isSymbolePlaced = m_Board.PlaceSymbole(m_CurrentPlayer.Symbole, i_iIndex, i_jIndex);

            if (isSymbolePlaced)
            {
                if (m_CurrentPlayer == m_Player1)
                {
                    m_CurrentPlayer = m_Player2;
                }
                else
                {
                    m_CurrentPlayer = m_Player1;
                }
                OnTurnChange();
            }

            return isSymbolePlaced;
        }
        protected virtual void OnSymbolePlaced(int i_iIndex, int i_jIndex, eCellValue i_Symbole)
        {
            SymbolePlacedOnBoard?.Invoke(i_iIndex, i_jIndex, i_Symbole);
        }
        protected virtual void OnTurnChange()
        {
            TurnChanged?.Invoke(m_CurrentPlayer);
        }
        protected virtual void OnScoreChange(Player i_Winner)
        {
            ScoreChanged?.Invoke(i_Winner);
        }
        public bool ComputersMove()
        {
            bool validTurn = false;
            int row, col;
            Random random = new Random();

            while (!validTurn)
            {
                row = random.Next(m_Board.Size);
                col = random.Next(m_Board.Size);
                if (m_Board.IsPlaceOnBoard())
                {
                    validTurn = PlayersMove(row, col);
                }
            }

            return validTurn;
        }
        public bool WinningStatus(out eCellValue o_WinnerSymbole)
        {
            bool isGameOver = false;
            Player winner;
            o_WinnerSymbole = m_Board.GetWinner();

            if (o_WinnerSymbole == eCellValue.Empty)
            {
                isGameOver = !m_Board.IsPlaceOnBoard();
                // no winner and no place on the board = its a tie
            }
            else
            {
                isGameOver = true;
                winner = GetPlayerBySymbole(o_WinnerSymbole);
                winner.IncrementScore();
                OnScoreChange(winner);
                // o_WinnerSymbole = X or O -> gameover
            }

            return isGameOver;
        }
        public void ResetGame()
        {
            m_CurrentPlayer = m_Player1;
            m_Board.ResetBoard();
        }


    }
}
