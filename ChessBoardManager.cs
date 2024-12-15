using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        private List<Player> player;
        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }
        private int currentPlayer;
        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }
        private TextBox playerName;
        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }  
        }

        public List<List<Button>> Matrix 
        {
            get { return  matrix; }
            set { matrix = value; } 
        }

        public object Controls { get; internal set; }

        private List<List<Button>> matrix;
        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox playerMark)
        {
            this.chessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;

            this.player = new List<Player>()
    {
            new Player("Cường", Image.FromFile(Application.StartupPath + "\\Resources\\X.png")),
            new Player("Hoàng", Image.FromFile(Application.StartupPath + "\\Resources\\O.png"))
    };
            CurrentPlayer = 0;
            ChangePlayer();

        }

        private Panel pnlChessBoard;

        public ChessBoardManager(Panel pnlChessBoard)
        {
            this.pnlChessBoard = pnlChessBoard; // Lưu tham chiếu của panel
        }

        #endregion
        #region Methods
        public void DrawChessBoard()
        {
            if (chessBoard == null)
                throw new ArgumentNullException(nameof(chessBoard), "ChessBoard không được khởi tạo.");

            chessBoard.Controls.Clear();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };

            // Khởi tạo ma trận để lưu các nút trên bàn cờ
            Matrix = new List<List<Button>>();

            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                List<Button> row = new List<Button>();
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() // Gán Tag để xác định tọa độ hàng
                    };

                    // Đăng ký sự kiện Click
                    btn.Click += Btn_Click;

                    chessBoard.Controls.Add(btn);
                    row.Add(btn);
                    oldButton = btn;
                }

                Matrix.Add(row);
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }




        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.BackgroundImage != null)
                return; // Nếu ô đã được đánh dấu, không làm gì cả.

            Mark(btn);
            ChangePlayer();

            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            MessageBox.Show($"{Player[CurrentPlayer].Name} Chiến thắng!");
           
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        private Point GetChessPoint(Button btn)
        {
            

            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X - 1; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countLeft++;
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countRight++;
                else
                    break;
            }

            return countLeft + countRight + 1 >= 5; // Thêm 1 vì bao gồm vị trí hiện tại
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countUp = 0;
            for (int i = point.Y - 1; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countUp++;
                else
                    break;
            }

            int countDown = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countDown++;
                else
                    break;
            }

            return countUp + countDown + 1 >= 5;
        }


        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countUpLeft = 0;
            for (int i = 1; point.X - i >= 0 && point.Y - i >= 0; i++)
            {
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countUpLeft++;
                else
                    break;
            }

            int countDownRight = 0;
            for (int i = 1; point.X + i < Cons.CHESS_BOARD_WIDTH && point.Y + i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countDownRight++;
                else
                    break;
            }

            return countUpLeft + countDownRight + 1 >= 5;
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countUpRight = 0;
            for (int i = 1; point.X + i < Cons.CHESS_BOARD_WIDTH && point.Y - i >= 0; i++)
            {
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countUpRight++;
                else
                    break;
            }

            int countDownLeft = 0;
            for (int i = 1; point.X - i >= 0 && point.Y + i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countDownLeft++;
                else
                    break;
            }

            return countUpRight + countDownLeft + 1 >= 5;
        }


        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;             
            }
        
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        


        #endregion

    }
}
