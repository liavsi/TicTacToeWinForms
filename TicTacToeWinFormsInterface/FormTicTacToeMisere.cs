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
        private TableLayoutPanel m_TableLayoutPanel;

        public FormTicTacToeMisere(int i_size, string i_Player1Name, string i_Player2Name)
        {
            InitializeComponent();
            this.SuspendLayout();
            this.m_TableLayoutPanel = new TableLayoutPanel();
            this.m_TableLayoutPanel.ColumnCount = i_size;
            this.m_TableLayoutPanel.RowCount = i_size;
            float rowColPrecetage = 100f / i_size;
            for(int i = 0; i < i_size; i++)
            {
                this.m_TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowColPrecetage));
                this.m_TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, rowColPrecetage));
                for (int j = 0; j < i_size; j++)
                {
                    Button button = new Button();
                    button.Name = $"button{i},{j}"; 
                    button.Dock = DockStyle.Fill;
                    button.BackColor = Color.Transparent;
                    this.m_TableLayoutPanel.Controls.Add(button,i, j);
                }
            }
            this.m_TableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.m_TableLayoutPanel.Size = this.splitContainer1.Panel1.ClientSize;
            this.m_TableLayoutPanel.Dock =DockStyle.Top;
            this.m_TableLayoutPanel.Location = new Point(0, 0);
            this.m_TableLayoutPanel.Name = "tableLayoutPanel";
            this.m_TableLayoutPanel.TabIndex = 0;
            this.splitContainer1.Panel1.Controls.Add(m_TableLayoutPanel);
            this.labelPlayer1Name.Text = $"{i_Player1Name}:";
            this.labelPlayer2Name.Text = $"{i_Player2Name}:";
            //todo make this more oop style
            this.labelPlayer1Score.Text = "0";
            this.labelPlayer2Score.Text = "0";

        }


    }
}
