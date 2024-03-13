namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button b = new Button();
                    b.Text = (i * j).ToString();
                    b.Left = 40 * i;
                    b.Top = 40 * j;

                    b.Width = 40;
                    b.Height = 40;

                    Controls.Add(b);
                    //Merci
                }
            }
        }
    }
}