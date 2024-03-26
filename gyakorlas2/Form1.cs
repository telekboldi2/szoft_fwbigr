namespace gyakorlas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            else
            {
                return Fibonacci(n-1)+Fibonacci(n-2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sorszam = int.Parse(textBox1.Text);

            List<int> sorok = new List<int>();
            Random rnd = new Random();



        }
    }
}
