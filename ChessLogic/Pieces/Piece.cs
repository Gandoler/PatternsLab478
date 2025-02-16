﻿using ChessLogic.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Pieces
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Color { get; }

        public bool HasMoved { get; set; } = false;

        public abstract Piece Copy();
        public abstract IEnumerable<Move> GetMoves(Position from, Board board);

        protected IEnumerable<Position> MovePositionsInDir(Position from, Board board, Direction direction)
        {
            for(Position pos = from + direction; Board.IsInside(pos); pos += direction)
            {
                if (board.isEmpty(pos)) {
                    yield return pos;
                    continue;
                }
                Piece piece = board[pos];

                if(piece.Color != Color)
                {
                    yield return pos;
                }
                yield break;
            }
        }


        protected IEnumerable<Position> MovePositionsInDirs(Position from, Board board, Direction[] directions)
        {
            return directions.SelectMany(dir => MovePositionsInDir(from, board, dir));
        }
    }
}
