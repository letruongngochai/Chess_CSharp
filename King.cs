using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BaiTapBuoi06___Chess
{
    class King:Piece
    {
        public King(Square sq, PieceColor color)
        {
            if (color == PieceColor.White)
                _image = Resources.IMG_KING_WHITE;
            else
                _image = Resources.IMG_KING_BLACK;
        }
    }
}
