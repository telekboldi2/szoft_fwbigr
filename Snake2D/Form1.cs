namespace Snake2D
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 0;
        int ir�ny_y = 1;
        int l�p�ssz�m = 0;
        int hossz = 1;
        

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;


            //�tk�z�svizsg�lat
            foreach (object item in Controls)
            {

                if (item is K�gy�Elem) //Az�rt kell hogy csak akkor vizsg�ljon �tk�z�st, ha az item az K�gy�elem 
                {
                    K�gy�Elem k = (K�gy�Elem)item;
                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                if (item is Alma)
                {
                    Alma a = (Alma)item;
                    if (a.Top == fej_y && a.Left == fej_x)
                    {
                        Controls.Remove(a);
                        hossz++;
                    }
                }
            }


            //Lev�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            K�gy�Elem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke);
            Controls.Add(ke);
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ir�ny_x = 0;
                ir�ny_y = 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                ir�ny_x = 0;
                ir�ny_y = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_x = 1;
                ir�ny_y = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_x = -1;
                ir�ny_y = 0;
            }
        }

        private void almatimer_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                Random rnd = new Random();
                Alma a = new Alma();
                a.Top = rnd.Next(0, 30) * K�gy�Elem.M�ret;
                a.Left = rnd.Next(0, 50) * K�gy�Elem.M�ret;
                Controls.Add(a);
            }
        }
    }
}