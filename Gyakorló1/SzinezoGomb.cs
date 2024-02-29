using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Gyakorló1
{
    public class SzinezoGomb : Button
    {
        public SzinezoGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzinezoGomb_Click;
        }

        private void SzinezoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}