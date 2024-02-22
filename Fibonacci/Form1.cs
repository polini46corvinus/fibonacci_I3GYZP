namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Elem> lista = new List<Elem>();

            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);

                Elem ujSor = new Elem();
                ujSor.Sorszám = i;
                ujSor.Érték = Fibonacci(i);

                lista.Add(ujSor);

            }
            dataGridView1.DataSource = lista;
        }
        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}