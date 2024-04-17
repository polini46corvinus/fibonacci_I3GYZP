using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Hajós__minta_zh_
{
    public partial class Form1 : Form
    {
        BindingList<KerdesOsztaly> kerdesList = new BindingList<KerdesOsztaly>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                    var olvas = new CsvReader(sr, CultureInfo.InvariantCulture);
                    var csv = olvas.GetRecords<KerdesOsztaly>();
                    foreach (var item in csv)
                    {
                        kerdesList.Add(item);
                    }

                    sr.Close();
                    break;
                }
                catch
                {
                    MessageBox.Show("Hiba történt a fájl beolvasásakor.");
                }
            }
            kerdesOsztalyBindingSource.DataSource = kerdesList;
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var save = new StreamWriter(sfd.FileName))
                    using (var ment = new CsvWriter(save, CultureInfo.InvariantCulture))
                    {
                        ment.WriteRecords(kerdesOsztalyBindingSource);
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
            }
            catch
            {
                MessageBox.Show("Hiba történt a mentés során.");
            }
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            if (kerdesOsztalyBindingSource.Current == null) return;
            {
                if (MessageBox.Show("Valóban törölni akarod?", "Törlés menü", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    kerdesOsztalyBindingSource.RemoveCurrent();
                }

            }
        }

        public void hozzaadasButton_Click(object sender, EventArgs e)
        {
            BeviteliForm bf = new BeviteliForm();
            bf.kerdesosztaly = kerdesOsztalyBindingSource.Current as KerdesOsztaly;
            //bf.ShowDialog();

            if (bf.ShowDialog() == DialogResult.OK)
                {
                    kerdesList.Add(bf.kerdesosztaly2);
                }

            }
        }
    }