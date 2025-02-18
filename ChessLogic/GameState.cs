using ChessLogic.Moves;
using ChessLogic.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; set; }
        public Player currentPalyer { get; private set; }

        public GameState(Player player, Board board)
        {
            currentPalyer = player;
            Board = board;
        }


        public IEnumerable<Move> LegalMovesForPiece(Position pos)
        {
            if (Board.isEmpty(pos) || Board[pos].Color != currentPalyer)
            {
                return Enumerable.Empty<Move>();
            }

            Piece piece = Board[pos];
            IEnumerable<Move> moveCandidates = piece.GetMoves(pos, Board);
            return moveCandidates.Where(move => move.IsLegal(Board));
        }

        public void MakeMove(Move move)
        {
            move.Execute(Board);
            currentPalyer = currentPalyer.Opponent();
        }


    }
}
