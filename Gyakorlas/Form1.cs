namespace Gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int méret = 40;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor<10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    VillogoGomb b = new VillogoGomb();
                    Controls.Add(b);
                    b.Width = méret;
                    b.Height = méret;
                    b.Top = méret*sor;
                    b.Left = méret*oszlop;
                    b.Text = ((oszlop + 1) * (sor + 1)).ToString();
                }
            }
        }
    }
}
