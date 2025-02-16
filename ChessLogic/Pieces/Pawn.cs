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

        public Pawn(Player Color)
        {
            this.Color = Color;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.HasMoved=HasMoved;
            return copy;
        }
    }
}
