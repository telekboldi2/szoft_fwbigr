using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogosGomb
{
    internal class SzámolóGomb : Button
    {
        int szám=0;
        public SzámolóGomb()
        {
            Width = 20;
            Height = 20;
            MouseClick += SzámolóGomb_MouseClick;
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szám == 5)
            {
                szám = 0;
                Text = szám.ToString();
            }
            else
            {
                szám++;
                Text = szám.ToString();
            }
            
        }
    }
}
