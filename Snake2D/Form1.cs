namespace Snake2D
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 0;
        int ir�ny_y = 1;
        int l�p�ssz�m = 0;
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

            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (K�gy�Elem item in Controls)
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

            K�gy�Elem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) 
            {
                ir�ny_x= 0;
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
    }
}