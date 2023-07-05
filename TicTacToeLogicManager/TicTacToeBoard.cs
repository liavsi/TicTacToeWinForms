using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLogicManager
{
    public enum eCellValue
    {
        Empty,
        X,
        O
    }
    public class TicTacToeBoard
    {
        private eCellValue[,] m_Board;
        private int m_size;
        public event Action<int, int, eCellValue> SymbolePlaced;

        public TicTacToeBoard(int i_size)
        {
            m_size = i_size;
            m_Board = new eCellValue[m_size, m_size];
            ResetBoard();
        }
        protected virtual void onSymbolePlaced(int i_iIndex, int i_jIndex, eCellValue i_Symbole)
        {
            SymbolePlaced?.Invoke(i_iIndex, i_jIndex, i_Symbole);
        }
        public int Size
        {
            get
            {
                return m_size;
            }
        }
        // Method to reset the board to empty cells
        public void ResetBoard()
        {
            for (int i = 0; i < m_size; i++)
            {
                for (int j = 0; j < m_size; j++)
                {
                    onSymbolePlaced(i,j,eCellValue.Empty);
                    m_Board[i, j] = eCellValue.Empty;
                }
            }
        }
        public bool PlaceSymbole(eCellValue i_symbol, int i_iIndex, int i_jIndex)
        {
            bool isPlacedSuccessfully = false;
            if (m_Board[i_iIndex, i_jIndex] == eCellValue.Empty)
            {
                m_Board[i_iIndex, i_jIndex] = i_symbol;
                isPlacedSuccessfully = true;
                onSymbolePlaced(i_iIndex,i_jIndex, i_symbol);
            }
            else
            {
                isPlacedSuccessfully = false;
            }

            return isPlacedSuccessfully;
        }




        public bool IsPlaceOnBoard()
        {
            bool isNotFull = false;

            foreach (eCellValue cell in m_Board)
            {
                if (cell == eCellValue.Empty)
                {
                    isNotFull = true;
                }
            }

            return isNotFull;
        }
        public eCellValue GetWinner()
        {
            eCellValue rows, cols, leftToRight,rightToLeft, symbolOfWinner;
            // Check rows
            rows = CheckWinnInARow();
            cols = CheckWinnInAColumn();
            leftToRight = CheckWinnCrossLeftToRight();
            rightToLeft = CheckWinnCrossRightToLeft();
            HashSet<eCellValue> symboleSet = new HashSet<eCellValue>();
            symboleSet.Add(rows);
            symboleSet.Add(cols);    
            symboleSet.Add(leftToRight);
            symboleSet.Add(rightToLeft);
            if(symboleSet.Contains(eCellValue.X))
            {
                symbolOfWinner = eCellValue.X;
            }
            else if(symboleSet.Contains(eCellValue.O))
            {
                symbolOfWinner = eCellValue.O;
            }
            else
            {
                symbolOfWinner = eCellValue.Empty;
            }
            // X = x is the winner | O = o is the winner | Empty = no winner
            return symbolOfWinner;
        }
        private eCellValue CheckWinnInARow()
        {
            eCellValue winnerSymbole = eCellValue.Empty;
            int counterX = 0, counterO = 0;
            bool isWinner = false;
            for (int i = 0; i < m_size && !isWinner; i++)
            {
                for (int j = 0; j < m_size; j++)
                {
                    if (m_Board[i, j] == eCellValue.X)
                    {
                        counterX++;
                    }
                    else if (m_Board[i, j] == eCellValue.O)
                    {
                        counterO++;
                    }
                }
                if (counterO == m_size)
                {
                    isWinner = true;
                    winnerSymbole = eCellValue.X;
                }
                else if (counterX == m_size)
                {
                    isWinner = true;
                    winnerSymbole = eCellValue.O;
                }
                counterO = counterX = 0;
            }

            return winnerSymbole;
        }
        private eCellValue CheckWinnCrossLeftToRight()
        {
            eCellValue winnerSymbole = eCellValue.Empty;
            int counterX = 0, counterO = 0;
            for (int i = 0; i < m_size ; i++)
            {

                if (m_Board[i, i] == eCellValue.X)
                {
                    counterX++;
                }
                else if (m_Board[i, i] == eCellValue.O)
                {
                    counterO++;
                }
            }
            if (counterX == m_size)
            {
                winnerSymbole = eCellValue.O;
            }
            else if (counterO == m_size)
            {
                winnerSymbole = eCellValue.X;
            }

            return winnerSymbole;
        }
        private eCellValue CheckWinnCrossRightToLeft()
        {
            eCellValue winnerSymbole = eCellValue.Empty;
            int counterX = 0, counterO = 0;
            for (int i = 0; i < m_size; i++)
            {

                if (m_Board[i, m_size - i - 1] == eCellValue.X)
                {
                    counterX++;
                }
                else if (m_Board[i, m_size - i - 1] == eCellValue.O)
                {
                    counterO++;
                }
            }
            if (counterO == m_size)
            {
                winnerSymbole = eCellValue.X;
            }
            else if (counterX == m_size)
            {
                winnerSymbole = eCellValue.O;
            }

            return winnerSymbole;
        }
        private eCellValue CheckWinnInAColumn()
        {

            eCellValue winnerSymbole = eCellValue.Empty;
            int counterX = 0, counterO = 0;
            bool isWinner = false;
            for (int i = 0; i < m_size && !isWinner; i++)
            {
                for (int j = 0; j < m_size; j++)
                {
                    if (m_Board[j, i] == eCellValue.X)
                    {
                        counterX++;
                    }
                    else if (m_Board[j, i] == eCellValue.O)
                    {
                        counterO++;
                    }
                }
                if (counterO == m_size)
                {
                    isWinner = true;
                    winnerSymbole = eCellValue.X;
                }
                else if (counterX == m_size)
                {
                    isWinner = true;
                    winnerSymbole = eCellValue.O;
                }
                counterO = counterX = 0;
            }
            return winnerSymbole;
        }
    }
}
