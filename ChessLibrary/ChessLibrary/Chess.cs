using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    /// <summary>
    /// Library for chess rules
    /// </summary>
    public class Chess
    {
        public string Fen { get; private set; }
        Board board;
        Moves moves;

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            Fen = fen;
            board = new Board(fen);
            moves = new Moves(board);
        }

        Chess (Board board)
        {
            this.board = board;
            this.Fen = board.fen;
            moves = new Moves(board);
        }

        public Chess Move(string move)// приймає хід в вигляді PE2E4  PE7E8
        {
            FigureMoving fm = new FigureMoving(move);
            if (!moves.CanMove(fm))
                return this;
            Board nextBoard = board.Move(fm);
            Chess nextCheess = new Chess(nextBoard);
            return nextCheess;
        }

        public char GetFigureAt(int x, int y)
        {
            Square square = new Square(x, y);
            Figure f = board.GetFigureAt(square);
            return f == Figure.none ? '.' : (char)f;
        }
    }
}
