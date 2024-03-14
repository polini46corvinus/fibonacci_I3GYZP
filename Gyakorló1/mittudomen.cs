using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorló1
{
    internal class mittudomen : Button
    {
        public int szám = 0;

        public mittudomen()
        {
            Height = 50;
            Width = 50;
            Click += Mittudomen_Click;
        }

        private void Mittudomen_Click(object? sender, EventArgs e)
        {
            szám++;
            if (szám%2==0)
            { 
                BackColor = Color.Cyan;
            }
            else BackColor = Color.Red;
        }
    }
}
