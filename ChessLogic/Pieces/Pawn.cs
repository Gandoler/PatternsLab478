using ChessLogic.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Pawn : Piece
    {
        public override PieceType Type => PieceType.Pawn;

        public override Player Color { get; }

        private static readonly Direction forward;

        public Pawn(Player Color)
        {
            this.Color = Color;
            if (Color == Player.White)
            {
                forward = Direction.North;
            }
            else if (Color == Player.Black)
            {
                forward = Direction.South;
            }
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved=HasMoved;
            return copy;
        }


        private static bool CanMoveTo(Position pos, Board board)
        {
            return Board.IsInside(pos) && board.isEmpty(pos);
        }


        private bool CanCaptureAt(Position pos, Board board)
        {
            if(!Board.IsInside(pos)|| board.isEmpty(pos)){
                return false;
            }

            return board[pos].Color != Color;    
        }

        private IEnumerable<Move> ForwardMoves(Position from, Board board)
        {

        }
    }
}
