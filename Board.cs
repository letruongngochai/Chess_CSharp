using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BaiTapBuoi06___Chess
{
    class Board
    {
        public const int DEFAULT_SQUARE_WIDTH = 64;
        public const int DEFAULT_SQUARE_HEIGHT = 64;

        protected Square[,] _squares;
        protected int _squareWidth;
        protected int _squareHeight;

        protected Square _selectedSquare;
        public Square selectedSquare
        {
            get => _selectedSquare;
            set
            {
                if (_selectedSquare != null) 
                    _selectedSquare.selected = false;
                _selectedSquare = value;
            }
        }

        protected Form ParentForm { get; set; }
        public Board(Form parent, int width = DEFAULT_SQUARE_WIDTH, int height = DEFAULT_SQUARE_HEIGHT)
        {
            _squares = new Square[8, 8];
            ParentForm = parent;
            _squareWidth = width;
            _squareHeight = height;
            _init();
        }
        public void _init()
        {
            int left = 0;
            int top = 0;

            SquareColor c = SquareColor.White;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square sq = new Square(c, this)
                    {
                        Width = _squareWidth,
                        Height = _squareHeight,
                        Left = left,
                        Top = top,
                    };

                    _squares[i, j] = sq;
                    left += _squareWidth;
                    if (c == SquareColor.White)
                        c = SquareColor.Black;
                    else c = SquareColor.White;

                    ParentForm.Controls.Add(sq);
                }
                left = 0;
                top += _squareHeight;
                if (c == SquareColor.White)
                    c = SquareColor.Black;
                else c = SquareColor.White;
            }
            Initialize();
        }
        public Piece this[int i, int j]
        {
            get { return _squares[i, j].piece; }
            set { _squares[i, j].piece = value; }
        }
        public void Initialize()
        {
            //Initialize Pawns
            for (int i = 0; i < 8; i++)
            {
                this[1, i] = new Pawn(_squares[1, i], PieceColor.Black);
            }

            for (int i = 0; i < 8; i++)
            {
                this[6, i] = new Pawn(_squares[6, i], PieceColor.White);
            }

            //Initialize Rooks
            this[0, 0] = new Rook(_squares[0, 0], PieceColor.Black);
            this[0, 7] = new Rook(_squares[0, 7], PieceColor.Black);

            this[7, 0] = new Rook(_squares[7, 0], PieceColor.White);
            this[7, 7] = new Rook(_squares[7, 7], PieceColor.White);

            //Initialize Knights
            this[0, 1] = new Knight(_squares[0, 1], PieceColor.Black);
            this[0, 6] = new Knight(_squares[0, 6], PieceColor.Black);

            this[7, 1] = new Knight(_squares[7, 1], PieceColor.White);
            this[7, 6] = new Knight(_squares[7, 6], PieceColor.White);

            //Initialize Bishops
            this[0, 2] = new Bishop(_squares[0, 2], PieceColor.Black);
            this[0, 5] = new Bishop(_squares[0, 5], PieceColor.Black);

            this[7, 2] = new Bishop(_squares[7, 2], PieceColor.White);
            this[7, 5] = new Bishop(_squares[7, 5], PieceColor.White);

            //Initialize Queens
            this[0, 3] = new Queen(_squares[0, 3], PieceColor.Black);
            this[7, 3] = new Queen(_squares[7, 3], PieceColor.White);

            //Initialize Kings
            this[0, 4] = new King(_squares[0, 4], PieceColor.Black);
            this[7, 4] = new King(_squares[7, 4], PieceColor.White);
        }
    }
}
