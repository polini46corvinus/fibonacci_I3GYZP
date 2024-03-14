using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajós_teszt
{
    public class ValaszGomb: TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;

            Click += ValaszGomb_Click;


        }

        private void ValaszGomb_Click(object? sender, EventArgs e)
        {
            /*if () //rossz válasz
            {
                BackColor = Color.Red;
            };
            if () //jó válasz
            {
                BackColor = Color.Green;
            };*/


        }

        private void ValaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void ValaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
