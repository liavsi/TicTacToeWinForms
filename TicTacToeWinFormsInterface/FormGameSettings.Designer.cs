namespace TicTacToeWinFormsInterface
{
    partial class FormGameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(142, 67);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer1.TabIndex = 2;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(142, 109);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2.TabIndex = 3;
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(55, 109);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(61, 17);
            this.checkBoxPlayer2.TabIndex = 4;
            this.checkBoxPlayer2.Text = "Player2";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(86, 231);
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownLeft.TabIndex = 5;
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(236, 228);
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownRight.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cols:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(55, 317);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(263, 71);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownRight);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "FormGameSettings";
            this.Text = "FormGameSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
    }
}