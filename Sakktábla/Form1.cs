namespace Sakktábla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i%2==0 && j%2==1)||(i%2==1 && j%2==0))
                    {
                        Button b = new Button();
                        b.Top = 50 + j * 50;
                        b.Left = 50 + i * 50;
                        b.Width = 50;
                        b.Height = 50;
                        b.BackColor = Color.Black;
                        Controls.Add(b);
                    }
                    else continue;
                }
            }

        }
    }
}
