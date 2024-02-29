using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogosGomb
{
    internal class SzineződőGomb : Button
    {
        public SzineződőGomb()
        {
            MouseClick += SzineződőGomb_MouseClick;
        }

        private void SzineződőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (BackColor != Color.Fuchsia)
            {
                BackColor = Color.Fuchsia;
            }
            else
            {
                BackColor = SystemColors.ButtonFace;
            }
            
        }
    }
}
