namespace Kígyós_játék
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám = 0;

        int hossz = 5;

        List<KígyóElem> kígyólista = new List<KígyóElem>();
        List<Alma> almalista = new List<Alma>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (KígyóElem item in kígyólista)
            {
                if (item is KígyóElem)
                {
                    if (item.Top == fej_y && item.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            
            foreach(Alma alma1 in almalista)
            {
                if (alma1 is Alma)
                {
                    if (alma1.Top == fej_y && alma1.Left == fej_x)
                    {
                        hossz++;
                        return;
                    }
                }
            }


            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (lépésszám % 2 == 0) ke.BackColor = Color.Black; //nekem így jobban tetszik na :(
            Controls.Add(ke);
            kígyólista.Add(ke);

            if (kígyólista.Count > hossz)
            {
                KígyóElem levágandó = kígyólista[0];
                kígyólista.RemoveAt(0);
                Controls.Remove(levágandó);
            }
            
            if (lépésszám % 5 == 0)
            {
                Random rnd = new Random();
                int randomszam = rnd.Next(10);
                Alma ujalma = new Alma();
                ujalma.Top = randomszam*20;
                ujalma.Left = randomszam*20;
                Controls.Add(ujalma);
                almalista.Add(ujalma);
            }

        }

        private void lefele(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { irány_y = -1; irány_x = 0; }
            if (e.KeyCode == Keys.Down) { irány_y = 1; irány_x = 0; }
            if (e.KeyCode == Keys.Left) { irány_y = 0; irány_x = -1; }
            if (e.KeyCode == Keys.Right) { irány_y = 0; irány_x = 1; }
        }
    }
}