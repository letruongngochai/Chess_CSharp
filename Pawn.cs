using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi06___Chess
{
    class Pawn:Piece
    {
        public Pawn(Square sq, PieceColor color)
        {
            if (color == PieceColor.White)
                _image = Resources.IMG_PAWN_WHITE;
            else
                _image = Resources.IMG_PAWN_BLACK;
        }
    }
}
