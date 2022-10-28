using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BaiTapBuoi06___Chess
{
    public enum SquareColor { White, Black };
    class Square : PictureBox
    {
        protected SquareColor _color;
        public SquareColor color
        {
            get => _color;
            set
            {
                _color = value;
                if (_color == SquareColor.White)
                    this.BackColor = Color.White;
                else
                    this.BackColor = Color.Gray;
            }
        }
        protected Piece _piece;
        public Piece piece
        {
            get => _piece;
            set
            {
                _piece = value;
                if (_piece != null)
                    Image = _piece.image;
                else Image = null;
            }
        }
        protected Board _board;
        protected bool _selected;
        public bool selected
        {
            get => _selected;
            set
            {
                _selected = value;
                if (value)
                {
                    _board.selectedSquare = this;
                    BackColor = System.Drawing.Color.DarkGoldenrod;
                }
                else
                    color = _color;
            }
        }
        static void OnMouseClick(object sender, MouseEventArgs e)
        {
            Square sq = (Square)sender;
            if (e.Button == MouseButtons.Left)
                sq.selected = true;
            else 
                if (e.Button == MouseButtons.Right)
                {
                    Board b = sq._board;
                    if (b.selectedSquare != null)
                    {
                        sq.piece = b.selectedSquare.piece;
                        b.selectedSquare.piece = null;
                        sq.selected = true;
                    }
                }
        }
        public Square(SquareColor c, Board b, Piece p = null)
        {
            _board = b;
            _piece = p;
            color = c;
            SizeMode = PictureBoxSizeMode.StretchImage;
            MouseClick += new MouseEventHandler(OnMouseClick);
        }
    }
}
