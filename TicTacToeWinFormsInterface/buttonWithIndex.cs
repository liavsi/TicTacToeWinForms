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
    public partial class ButtonWithIndex : Button
    {
        private int m_Row;
        private int m_Column;
        public ButtonWithIndex()
        {
            InitializeComponent();
        }

        public int Row { get { return m_Row; } set { m_Row = value; } }
        public int Column { get { return m_Column; } set { m_Column = value; } }
    }
}
