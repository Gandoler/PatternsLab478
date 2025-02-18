using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    internal class PieceFactory
    {
        public static Piece CreatePiece(PieceType type, Player color)
        {
            return type switch
            {
                PieceType.Pawn => new Pawn(color),
                PieceType.Knight => new Knight(color),
                PieceType.Bishop => new Bishop(color),
                PieceType.Rook => new Rook(color),
                PieceType.Queen => new Queen(color),
                PieceType.King => new King(color),
                _ => throw new ArgumentException("Неизвестный тип фигуры")
            };
        }
    }
}
