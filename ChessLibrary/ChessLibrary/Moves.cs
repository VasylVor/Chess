using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    class Moves
    {
        FigureMoving fm;
        Board board;

        public Moves(Board board)
        {
            this.board = board;
        }

        public bool CanMove(FigureMoving fm)
        {
            this.fm = fm;
            return
                CanMoveFrom() &&
                CanMoveTo() &&
                CanFigureMove();
        }

        private bool CanFigureMove()
        {
            switch (fm.figure)
            {
                case Figure.whiteKing:
                case Figure.blackKing:
                    break;

                case Figure.whiteQueen:
                case Figure.blackQueen:
                    break;

                case Figure.whiteRook:
                case Figure.blackRook:
                    break;

                case Figure.whiteBishop:
                case Figure.blackBishop:
                    break;

                case Figure.whiteKnight:
                case Figure.blackKnight:
                    return CanKnightMove();

                case Figure.whitePawn:
                case Figure.blackPawn:
                    break;
                   
                default: return false;
            }
        }

        private bool CanKnightMove()
        {

        }

        private bool CanMoveTo()
        {
            return fm.to.OnBoard() &&
                   board.GetFigureAt(fm.to).GetColor() != board.moveColor;
        }

        private bool CanMoveFrom()
        {
            return fm.from.OnBoard() &&
                   fm.figure.GetColor() == board.moveColor;
        }
    }
}
