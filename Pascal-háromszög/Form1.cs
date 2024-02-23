namespace Pascal_háromszög
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int sor = 0; sor <= 10; sor++)
            {
                for (int oszlop = 0; oszlop <= 10; oszlop++)
                {
                    Button b = new Button();
                    b.Top = 50 + sor * 50;
                    b.Left = 400 + sor*25 - oszlop * 50;
                    b.Height = 50;
                    b.Width = 50;

                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    b.Text = p.ToString();
                    if (p > 0)
                        {
                            if ((sor==0 && oszlop==1)==false) this.Controls.Add(b);
                        }
                }
            }
            int Faktorialis(int n)
            {
                int eredmény = 1;
                for (int i = 1; i <= n; i++) eredmény *= i;
                return eredmény;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }
        }
    }