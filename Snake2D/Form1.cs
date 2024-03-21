namespace Snake2D
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�ssz�m;
        int hossz = 10;

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

            //fejn�veszt�s
            List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;
            K�gy�Elem ke = new K�gy�Elem();
            k�gy�.Add(ke);
            Controls.Add(ke);

            foreach (K�gy�Elem item in Controls)
            {
                //Ha vannak m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }
            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }


            ke.Top = fej_y;
            ke.Left = fej_x;
            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;
            Controls.Add(ke);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_x = 0;
                ir�ny_y = -1;
            }
            if (e.KeyCode == Keys.Left)
            {
                ir�ny_x = -1;
                ir�ny_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                ir�ny_x = 1;
                ir�ny_y = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                ir�ny_x = 0;
                ir�ny_y = 1;
            }
        }
    }
}