using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kígyós_játék
{
    internal class KígyóElem : PictureBox
    {
        public static int Méret = 20;

        public KígyóElem()
        {
            Width = Méret;
            Height = Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
