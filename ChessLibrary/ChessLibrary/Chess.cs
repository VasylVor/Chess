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

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            Fen = fen;
        }

        public Chess Move(string move)// приймає хід в вигляді PE2E4  PE7E8
        {
            Chess nextCheess = new Chess(Fen);
            return nextCheess;
        }

        public char GetFigureAt(int x, int y)
        {
            return '.';
        }
    }
}
