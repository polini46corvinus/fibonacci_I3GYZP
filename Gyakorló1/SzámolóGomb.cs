using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorló1
{
    public class SzámolóGomb : Button
    {
        public int szám = 1;
        public SzámolóGomb()
        {
            Width = 20;
            Height = 20;
            Click += SzámolóGomb_Click;
            Text = szám.ToString();
        }

        public void SzámolóGomb_Click(object? sender, EventArgs e)
        {
            

            if (szám<6)
            {
                if (szám == 5)
                {
                    szám = 1;
                }
                else
                szám += 1;
            }
          
        
            Text = szám.ToString();
        }
    }
}
