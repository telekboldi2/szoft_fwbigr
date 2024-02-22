namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40; //gombm�ret    
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    Button b = new Button();
                    Controls.Add(b);
                    b.Width = m;
                    b.Height = m;
                    b.Top = m*sor;
                    b.Left = m * oszlop ;
                    int x = Factorial(sor) / (Factorial(oszlop) *(Factorial(sor-oszlop)));
                    b.Text = x.ToString();
                }
            }
        }

        int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n*Factorial(n-1);

        }
    }
}