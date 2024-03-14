namespace Hajós_teszt
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdesek; // alt: List<Kerdes> OsszesKerdesek = new List<Kerdes>();
        List<Kerdes> AktivKerdesek;// alt: List<Kerdes> AktivKerdesek = new List<Kerdes>();

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

            while (!sr.EndOfStream) // alt: while (sr.EndOfStream == false)
            {
                string sor = sr.ReadLine() ?? string.Empty; //beolvasunk egy sort. HA NEM, akkor visszaadunk egy string.empty-t
                string[] tomb = sor.Split("\t");
                if (tomb.Length != 7) continue; //ez a sor tök fölösleges

                Kerdes k = new Kerdes()
                {
                    KerdesSzoveg = tomb[1],
                    Valasz1 = tomb[2],
                    Valasz2 = tomb[3],
                    Valasz3 = tomb[4],
                    URL = tomb[5],
                };

                int.TryParse(tomb[6], out int jovalasz);
                k.HelyesValasz = jovalasz;

                kerdesek.Add(k);
                
                /* Tömb elemeinek kiírása - gyak
                
                string szoveg000 = "";
                for (int i = 0; i < tomb.Length; i++)
                {
                    szoveg000 += tomb[i].ToString()+"\n";
                }
                MessageBox.Show(szoveg000);
                
                */
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
                OsszesKerdesek.RemoveAt(i); //letöröljük: azé csináljuk hogy mégegyszer ne jelenjen meg ez a kérdés
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