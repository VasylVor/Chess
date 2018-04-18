using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary;

namespace DemoChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess chess = new Chess();
            while (true)
            {
                Console.WriteLine(chess.Fen);
                string move = Console.ReadLine();
                if (move == "") break;
                chess = chess.Move(move);
            }
        }
    }
}
