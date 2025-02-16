using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public class Rook: Piece
    {
        public override PieceType Type => PieceType.Rook;

        public override Player Color { get; }

        public Rook(Player Color)
        {
            this.Color = Color;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
