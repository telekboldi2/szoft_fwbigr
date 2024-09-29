using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szofteng.Data;
using Szofteng.Models;

namespace Szofteng
{
    public partial class UgyfelForm : Form
    {
        private RendelesDbContext _context;
        public UgyfelForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();
        }

        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();
        }

        private void New_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
            _context.Ugyfel.Add(ujUgyfel);
            _context.SaveChanges();
            LoadData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var torlendougyfel = dataGridView1.CurrentRow.DataBoundItem as Ugyfel;
                if (torlendougyfel != null)
                {
                    _context.Ugyfel.Remove(torlendougyfel);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadData();
        }
    }
}
