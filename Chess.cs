using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BaiTapBuoi06___Chess
{
    class Chess
    {
        static Form f = new Form()
        {
            Size = new Size(768, 768),
        };
        static void Main(string[] args)
        {
            Board b = new Board(f);
            Application.Run(f);
        }
    }
}
