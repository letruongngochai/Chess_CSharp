using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BaiTapBuoi06___Chess
{
    public enum PieceColor { White, Black };
    class Piece
    {
        protected Image _image;
        public Image image
        {
            get => _image;
        }
        protected PieceColor _color;
        public PieceColor color
        {
            get => _color;
        }

        public bool IsOutOfBoard()
        {
            
            return false;
        }

        protected Square[] _validSquare;
        public Square[] validSquare { get => _validSquare; set => _validSquare = value; }
        public virtual Square[] ValidSquare() { return null; }
    }
}
