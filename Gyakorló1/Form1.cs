namespace Gyakorló1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    SzámolóGomb uj = new SzámolóGomb();
                    //uj.Width = 100;
                    //uj.Height = 50;

                    uj.Left = i * 20;
                    uj.Top = j * 20;

                    //uj.Text = (i*j).ToString();

                    Controls.Add(uj);
                }
            }*/

            /*
            // SZÍNES GOMBOK
            
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int randomszam1 = rnd.Next(0, 255);
                int randomszam2 = rnd.Next(0, 255);
                int randomszam3 = rnd.Next(0, 255);

                SzámolóGomb uj2 = new SzámolóGomb();
                uj2.Width = randomszam1;
                uj2.Height = randomszam1;
                uj2.Left = randomszam2;
                uj2.Top = randomszam2;
                uj2.BackColor = Color.FromArgb(randomszam1, randomszam2, randomszam3);
                Controls.Add(uj2);
            }
            */


            /*
            // HÁROMSZÖG
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i < j)
                    {
                        SzámolóGomb uj3 = new SzámolóGomb();
                        uj3.Left = i * 20;
                        uj3.Top = j * 20;
                        Controls.Add(uj3);
                    }
                    
            }
            }*/




            // KARÁCSONYFA

            /*for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i < j)
                    {
                        SzámolóGomb uj4 = new SzámolóGomb();
                        uj4.Left = ClientRectangle.Width / 2 + i * 20 - j * 10;
                        uj4.Top = j * 20;
                        uj4.Width = 20;
                        uj4.Height = 20; // eleve ennyi volt az osztály miatt loooool
                        Controls.Add(uj4);
                    }
                    
                }
            }*/

            // TESZT

            for (int i = 0; i < 5; i++)
            {
                mittudomen anyad = new mittudomen();
                anyad.Top = i * 50;
                Controls.Add(anyad);
            }
            
        }
    }
}