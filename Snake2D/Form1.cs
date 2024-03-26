namespace Snake2D
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 0;
        int irány_y = 1;
        int lépésszám = 0;
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
            lépésszám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (KígyóElem item in Controls)
            {
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

            KígyóElem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) 
            {
                irány_x= 0;
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
    }
}