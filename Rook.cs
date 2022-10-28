using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi06___Chess
{
    class Rook:Piece
    {
        public Rook(Square sq, PieceColor color)
        {
            if (color == PieceColor.White)
                _image = Resources.IMG_ROOK_WHITE;
            else
                _image = Resources.IMG_ROOK_BLACK;
        }
        public override Square[] ValidSquare()
        {
            return base.ValidSquare();
        }
    }
}
