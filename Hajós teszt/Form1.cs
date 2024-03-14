namespace Hajós_teszt
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdesek;
        List<Kerdes> AktivKerdesek;

        int AktivKerdes = 0;

        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(KerdesBeolvasas().Count.ToString());
        }
        private List<Kerdes> KerdesBeolvasas()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty; //beolvasunk egy sort. HA NEM, akkor visszaadunk egy string.empty-t
                string[] tomb = sor.Split("\t");
                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes()
                {
                    KerdesSzoveg = tomb[1],
                    Valasz1 = tomb[2],
                    Valasz2 = tomb[3],
                    Valasz3 = tomb[4],
                    URL = tomb[5]
                };

                int.TryParse(tomb[6], out int jovalasz);
                k.HelyesValasz = jovalasz;

                kerdesek.Add(k);


            }
            return kerdesek;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AktivKerdesek = new List<Kerdes>();
            OsszesKerdesek = KerdesBeolvasas();

            for (int i = 0; i < 7; i++)
            {
                AktivKerdesek.Add(OsszesKerdesek[i]);
                OsszesKerdesek.RemoveAt(0); //letöröljük: azé csináljuk hogy mégegyszer ne jelenjen meg ez a kérdés
            }

            dataGridView1.DataSource = AktivKerdesek;

            KerdesMegjelenites(AktivKerdesek[AktivKerdes]);
        }

        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Valasz1;
            valaszGomb2.Text = kerdes.Valasz2;
            valaszGomb3.Text = kerdes.Valasz3;

            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void kovetkezoGomb_Click(object sender, EventArgs e)
        {
            if (AktivKerdes < 7)
            {
                AktivKerdes++;
            }
            if (AktivKerdes == 7)
            {
                AktivKerdes = 0;
            }

            KerdesMegjelenites(AktivKerdesek[AktivKerdes]);
        }

    }
}