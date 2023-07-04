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
    public partial class FormTicTacToeMisere : Form
    {
        public FormTicTacToeMisere(int i_size)
        {
            InitializeComponent();
            tableLayoutPanel.RowCount = i_size;
            tableLayoutPanel.ColumnCount = i_size;

            //foreach (RowStyle style in tableLayoutPanel.RowStyles)
            //{
              //  tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / i_size));
            //}
        }

        
    }
}
