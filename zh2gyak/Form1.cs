using CsvHelper;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;

namespace zh2gyak
{
    public partial class Form1 : Form
    {
        BindingList<lekepezes> bemenet = new();
        public Form1()
        {
            InitializeComponent();
            lekepezesBindingSource.DataSource = bemenet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<lekepezes>();

                foreach (var item in tömb)
                {
                    bemenet.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(bemenet);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lekepezesBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva sor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Biztos törölni kívánja az alábbi sort?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lekepezesBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Add = new Form2();

            if (Add.ShowDialog() == DialogResult.OK)
            {
                bemenet.Add(Add.lekepezes);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lekepezesBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva sor", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormEdit edit = new FormEdit();
            edit.lekepezes = lekepezesBindingSource.Current as lekepezes;
            edit.Show();
        }

        private void USA_Click(object sender, EventArgs e)
        {
            double min = int.MaxValue;
            string minnev= null;
            int count = 0;
            foreach(var item in bemenet)
            {
                if (item.Nemzetiseg=="USA")
                {
                    count++;
                }
                if (item.EredmenyPerc < min)
                {
                    min = item.EredmenyPerc;
                    minnev = item.Nev;
                }
            }
            MessageBox.Show($"Az USA-ból {count} versenyzõ érkezett, és a legjobb idõt {minnev} futotta");
        }
    }
}
