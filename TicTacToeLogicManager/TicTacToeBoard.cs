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
        public TicTacToeBoard(int i_size)
        {
            m_size = i_size;
            m_Board = new eCellValue[m_size, m_size];
            ResetBoard();
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
                    m_Board[i, j] = eCellValue.Empty;
                }
            }
        }
        public bool PlaceSymbole(eCellValue i_symbol, int i_iIndex, int i_jIndex)
        {
            bool isPlacedSuccessfully = false;
            if (GetCell(i_iIndex, i_jIndex) == eCellValue.Empty)
            {
                m_Board[i_iIndex, i_jIndex] = i_symbol;
                isPlacedSuccessfully = true;
            }
            else
            {
                isPlacedSuccessfully = false;
            }

            return isPlacedSuccessfully;
        }


        public bool PlaceEmptySymbole(eCellValue i_symbol, int i_iIndex, int i_jIndex)
        {
            bool isPlacedSuccessfully = false;
            if (GetCell(i_iIndex, i_jIndex) != eCellValue.Empty)
            {
                m_Board[i_iIndex, i_jIndex] = i_symbol;
                isPlacedSuccessfully = true;
            }
            else
            {
                isPlacedSuccessfully = false;
            }

            return isPlacedSuccessfully;
        }
        public eCellValue GetCell(int i_iIndex, int i_jIndex)
        {
            return m_Board[i_iIndex, i_jIndex];
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
            eCellValue symbolOfWinner = eCellValue.Empty;
            bool isWinner = false;
            int counterX = 0, counterO = 0;
            // Check rows
            CheckWinnInARow(ref isWinner, ref counterX, ref counterO, ref symbolOfWinner);
            //check columns
            CheckWinnInAColumn(ref isWinner, ref counterX, ref counterO, ref symbolOfWinner);
            // Check diagonal top-left to bottom-right
            CheckWinnCrossRightToLeft(ref isWinner, ref counterX, ref counterO, ref symbolOfWinner);
            //check diagonal top-right to bottom-left
            CheckWinnCrossLeftToRight(ref isWinner, ref counterX, ref counterO, ref symbolOfWinner);

            // X = x is the winner | O = o is the winner | Empty = no winner
            return symbolOfWinner;
        }
        private void CheckWinnInARow(ref bool io_isWinner, ref int io_counterX, ref int io_counterO, ref eCellValue io_symbolOfWinner)
        {
            for (int i = 0; i < m_size && !io_isWinner; i++)
            {
                for (int j = 0; j < m_size; j++)
                {
                    if (m_Board[i, j] == eCellValue.X)
                    {
                        io_counterX++;
                    }
                    else if (m_Board[i, j] == eCellValue.O)
                    {
                        io_counterO++;
                    }
                }
                if (io_counterO == m_size)
                {
                    io_isWinner = true;
                    io_symbolOfWinner = eCellValue.X;
                }
                else if (io_counterX == m_size)
                {
                    io_isWinner = true;
                    io_symbolOfWinner = eCellValue.O;
                }
                io_counterO = io_counterX = 0;
            }
        }
        private void CheckWinnCrossRightToLeft(ref bool io_isWinner, ref int io_counterX, ref int io_counterO, ref eCellValue io_symbolOfWinner)
        {
            for (int i = 0; i < m_size && !io_isWinner; i++)
            {

                if (m_Board[i, i] == eCellValue.X)
                {
                    io_counterX++;
                }
                else if (m_Board[i, i] == eCellValue.O)
                {
                    io_counterO++;
                }
            }
            if (io_counterO == m_size)
            {
                io_isWinner = true;
                io_symbolOfWinner = eCellValue.X;
            }
            else if (io_counterX == m_size)
            {
                io_isWinner = true;
                io_symbolOfWinner = eCellValue.O;
            }
            io_counterO = io_counterX = 0;
        }
        private void CheckWinnCrossLeftToRight(ref bool io_isWinner, ref int io_counterX, ref int io_counterO, ref eCellValue io_symbolOfWinner)
        {
            for (int i = m_size - 1; i >= 0 && !io_isWinner; i--)
            {

                if (m_Board[i, i] == eCellValue.X)
                {
                    io_counterX++;
                }
                else if (m_Board[i, i] == eCellValue.O)
                {
                    io_counterO++;
                }
            }
            if (io_counterO == m_size)
            {
                io_isWinner = true;
                io_symbolOfWinner = eCellValue.X;
            }
            else if (io_counterX == m_size)
            {
                io_isWinner = true;
                io_symbolOfWinner = eCellValue.O;
            }
            io_counterO = io_counterX = 0;
        }
        private void CheckWinnInAColumn(ref bool io_isWinner, ref int io_counterX, ref int io_counterO, ref eCellValue io_symbolOfWinner)
        {
            for (int i = 0; i < m_size && !io_isWinner; i++)
            {
                for (int j = 0; j < m_size; j++)
                {
                    if (m_Board[j, i] == eCellValue.X)
                    {
                        io_counterX++;
                    }
                    else if (m_Board[j, i] == eCellValue.O)
                    {
                        io_counterO++;
                    }
                }
                if (io_counterO == m_size)
                {
                    io_isWinner = true;
                    io_symbolOfWinner = eCellValue.X;
                }
                else if (io_counterX == m_size)
                {
                    io_isWinner = true;
                    io_symbolOfWinner = eCellValue.O;
                }
                io_counterO = io_counterX = 0;
            }
        }
        public eCellValue[,] BoardState
        {
            get
            {
                return m_Board;
            }
        }
    }
}
