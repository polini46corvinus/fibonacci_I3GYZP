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
        public KerdesOsztaly kerdesosztaly = new KerdesOsztaly();
        public KerdesOsztaly kerdesosztaly2 = new KerdesOsztaly();
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
            kerdesosztaly2.Szam = int.Parse(szamTextBox.Text);
            kerdesosztaly2.Kerdes = kerdesTextBox.Text;
            kerdesosztaly2.V1 = v1TextBox.Text;
            kerdesosztaly2.V2 = v2TextBox.Text;
            kerdesosztaly2.V3 = v2TextBox.Text;
            kerdesosztaly2.Kep = kepTextBox.Text;
            kerdesosztaly2.HelyesValasz = int.Parse(helyesValaszTextBox.Text);
        }
    }
}
