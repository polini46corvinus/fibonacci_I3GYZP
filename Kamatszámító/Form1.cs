namespace Kamatszámító
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitelosszeg = Decimal.Parse(hitelOsszegTextBox.Text);
            decimal kamatertek = Decimal.Parse(kamatTextBox.Text);
            decimal torleszto = Decimal.Parse(torlesztoTextBox.Text);

            decimal hatralek = hitelosszeg;
            decimal befizetes = 0;

            ushort honap = 0;

            List<Sor> lista = new List<Sor>();

            while(hatralek>0)
            {
                hatralek += hatralek * (kamatertek * 1 / 100m);
                hatralek -= torleszto;
                befizetes += torleszto;

                if (hatralek < 0) { break; };

                honap += 1;

                Sor ujSor = new Sor();
                ujSor.Honap = honap;
                ujSor.Hatralek = Math.Round(hatralek);
                
                lista.Add(ujSor);
            }

            dataGridView1.DataSource = lista;
            MessageBox.Show(Math.Round(befizetes+hatralek).ToString());
        }
    }
}