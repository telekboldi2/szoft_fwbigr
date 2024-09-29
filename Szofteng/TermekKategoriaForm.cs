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
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();
        }

        private void LoadData()
        {
            //összes kategória betöltése
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();
            treeViewKategoriak.Nodes.Clear();
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoria == null
                               select k;
            foreach (var fokategoria in fokategoriak)
            {
                var node = CreateTreeNode(fokategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }

        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;
            foreach (var gyermekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyermekKategoria, osszeKategoria));
            }

            return node;
        }
    }
}
