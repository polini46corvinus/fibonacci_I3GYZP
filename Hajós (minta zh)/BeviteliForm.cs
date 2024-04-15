using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hajós__minta_zh_
{
    public partial class BeviteliForm : Form
    {
        public KerdesOsztaly kerdesosztaly;

        BindingList<KerdesOsztaly> kerdesosztalyList2 = new BindingList<KerdesOsztaly>();
        public BeviteliForm()
        {
            InitializeComponent();
        }

        private void BeviteliForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = kerdesosztaly;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok teszt");
            KerdesOsztaly lista = new KerdesOsztaly();
            lista.Szam = int.Parse(szamTextBox.Text);
            lista.Kerdes = kerdesTextBox.Text;
            lista.V1 = v1TextBox.Text;
            lista.V2 = v2TextBox.Text;
            lista.V3 = v3TextBox.Text;
            lista.Kep = kepTextBox.Text;
            lista.HelyesValasz = int.Parse(helyesValaszTextBox.Text);

            kerdesosztalyList2.Add(lista);
        }
    }
}
