
using System.Drawing.Drawing2D;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);

            ChessBoard.DrawChessBoard();
        }


        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ChessBoard.DrawChessBoard();
        }


        private void btnOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
