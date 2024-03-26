namespace Snake2D
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 0;
        int irány_y = 1;
        int lépésszám = 0;
        int hossz = 1;
        

        List<KígyóElem> kígyó = new List<KígyóElem>();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;


            //Ütközésvizsgálat
            foreach (object item in Controls)
            {

                if (item is KígyóElem) //Azért kell hogy csak akkor vizsgáljon ütközést, ha az item az Kígyóelem 
                {
                    KígyóElem k = (KígyóElem)item;
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


            //Levágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            KígyóElem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                irány_x = 0;
                irány_y = 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                irány_x = 0;
                irány_y = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_x = 1;
                irány_y = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_x = -1;
                irány_y = 0;
            }
        }

        private void almatimer_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                Random rnd = new Random();
                Alma a = new Alma();
                a.Top = rnd.Next(0, 30) * KígyóElem.Méret;
                a.Left = rnd.Next(0, 50) * KígyóElem.Méret;
                Controls.Add(a);
            }
        }
    }
}