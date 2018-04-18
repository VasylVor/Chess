using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    class FigureOnSqure
    {
        public Figure figure { get; private set; }
        public Square square { get; private set; }

        public FigureOnSqure(Figure figure, Square square)
        {
            this.figure = figure;
            this.square = square;
        }
    }
}
