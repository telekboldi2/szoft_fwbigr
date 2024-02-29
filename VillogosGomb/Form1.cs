namespace VillogosGomb
{
    public partial class Form1 : Form
    {
        int méret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    b.Height = méret;
                    b.Width = méret;
                    b.Left = sor*méret;
                    b.Top = oszlop*méret;
                    //b.Text = ((sor+1)*(oszlop+1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}