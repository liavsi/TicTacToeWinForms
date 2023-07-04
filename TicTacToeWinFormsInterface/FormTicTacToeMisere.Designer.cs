namespace TicTacToeWinFormsInterface
{
    partial class FormTicTacToeMisere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPlayer2Score = new System.Windows.Forms.Label();
            this.labelPlayer1Score = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelPlayer2Score);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlayer1Score);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlayer2Name);
            this.splitContainer1.Panel2.Controls.Add(this.labelPlayer1Name);
            this.splitContainer1.Size = new System.Drawing.Size(548, 423);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelPlayer2Score
            // 
            this.labelPlayer2Score.AutoSize = true;
            this.labelPlayer2Score.Location = new System.Drawing.Point(377, 32);
            this.labelPlayer2Score.Name = "labelPlayer2Score";
            this.labelPlayer2Score.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer2Score.TabIndex = 3;
            this.labelPlayer2Score.Text = "Score";
            // 
            // labelPlayer1Score
            // 
            this.labelPlayer1Score.AutoSize = true;
            this.labelPlayer1Score.Location = new System.Drawing.Point(197, 32);
            this.labelPlayer1Score.Name = "labelPlayer1Score";
            this.labelPlayer1Score.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer1Score.TabIndex = 2;
            this.labelPlayer1Score.Text = "Score";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Location = new System.Drawing.Point(301, 32);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(70, 13);
            this.labelPlayer2Name.TabIndex = 1;
            this.labelPlayer2Name.Text = "Player2Name";
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Location = new System.Drawing.Point(121, 32);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(70, 13);
            this.labelPlayer1Name.TabIndex = 0;
            this.labelPlayer1Name.Text = "Player1Name";
            // 
            // FormTicTacToeMisere
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormTicTacToeMisere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeMisere";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Score;
        private System.Windows.Forms.Label labelPlayer1Score;
    }
}