using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi06___Chess
{
    class Queen:Piece
    {
        public Queen(Square sq, PieceColor color)
        {
            if (color == PieceColor.White)
                _image = Resources.IMG_QUEEN_WHITE;
            else
                _image = Resources.IMG_QUEEN_BLACK;
        }
    }
}
