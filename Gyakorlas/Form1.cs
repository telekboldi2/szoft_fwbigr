namespace Gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m�ret = 40;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor<10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    VillogoGomb b = new VillogoGomb();
                    Controls.Add(b);
                    b.Width = m�ret;
                    b.Height = m�ret;
                    b.Top = m�ret*sor;
                    b.Left = m�ret*oszlop;
                    b.Text = ((oszlop + 1) * (sor + 1)).ToString();
                }
            }
        }
    }
}
