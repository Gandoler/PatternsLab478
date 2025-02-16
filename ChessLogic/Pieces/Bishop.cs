using ChessLogic.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Bishop: Piece
    {
        public override PieceType Type => PieceType.Bishop;

        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.
        };


        public Bishop(Player Color)
        {
            this.Color = Color;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
