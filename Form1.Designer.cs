namespace GameCaro
{
    partial class Form1

    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            ptcbAvatar = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            btnOut = new Button();
            btnReset = new Button();
            txbPlayerName = new TextBox();
            pctbMark = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptcbAvatar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.ActiveCaption;
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(753, 486);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(ptcbAvatar);
            panel2.Location = new Point(771, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 249);
            panel2.TabIndex = 1;
            // 
            // ptcbAvatar
            // 
            ptcbAvatar.Image = Properties.Resources.avt;
            ptcbAvatar.Location = new Point(3, 3);
            ptcbAvatar.Name = "ptcbAvatar";
            ptcbAvatar.Size = new Size(266, 243);
            ptcbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptcbAvatar.TabIndex = 0;
            ptcbAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 162);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 2;
            label1.Text = "5 in a line to win";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(btnOut);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(txbPlayerName);
            panel3.Controls.Add(pctbMark);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(771, 267);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 231);
            panel3.TabIndex = 3;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(0, 70);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(124, 31);
            btnOut.TabIndex = 7;
            btnOut.Text = "Exitgame";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click_1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(0, 32);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(124, 32);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.AccessibleName = "";
            txbPlayerName.Location = new Point(3, 3);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.Size = new Size(121, 23);
            txbPlayerName.TabIndex = 4;
            // 
            // pctbMark
            // 
            pctbMark.Image = Properties.Resources.avtnho;
            pctbMark.Location = new Point(130, 3);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(139, 131);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 3;
            pctbMark.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 551);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Game Caro";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptcbAvatar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private PictureBox ptcbAvatar;
        private Label label1;
        private Panel panel3;
        private TextBox txbPlayerName;
        private PictureBox pctbMark;
        private Button btnOut;
        private Button btnReset;
    }
}
