using ChessLogic;
using ChessLogic.Pieces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessLogic.Moves;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Image[,] pieceImages = new Image[8, 8];
        private readonly Rectangle[,] highlights = new Rectangle[8, 8];
        private readonly Dictionary<Position, Move> moveCache = new();
        
        private GameState gameState;
        private Position selectedPos = null;
        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            gameState = new GameState(Player.White, Board.initial());
            DrawBoard(gameState.Board);
        }

        private void InitializeBoard()
        {
            for(int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Image image = new Image();
                    pieceImages[r, c] = image;
                    PieceGrid.Children.Add(image);


                    Rectangle highlight = new Rectangle();
                    highlight[r,c] = highlight;
                    HiglightGrid.Children.Add(highlight);
                }
            }
        }


        private void DrawBoard(Board board)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c];
                    pieceImages[r,c].Source = Images.GetImage(piece);
                }
            }
        }


        private void BoardGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }


        private void CacheMoves(IEnumerable<Move> moves)
        {
            moveCache.Clear();

            foreach (var VARIABLE in moves)
            {
                moveCache[moves.ToPos] = VARIABLE;
            }
        }

        private void ShowHighlights()
        {
            Color color =Color.FromRgb(150,125,255,125);
            foreach (var VARIABLE in moveCache.Keys)
            {
                highlights[VARIABLE.Row,VARIABLE.Column] = new SolidColorBrush(color);
            }
            
        }
        private void HideHighlights()
        {
            
            foreach (var VARIABLE in moveCache.Keys)
            {
                highlights[VARIABLE.Row,VARIABLE.Column] = Brushes.Transparent;
            }
            
        }
        
        
        
    }
}