﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2D
{
    internal class Alma : PictureBox
    {
        public static int Méret = 20;
        public Alma()
        {
            Width = Alma.Méret;
            Height = Alma.Méret;
            BackColor = Color.Red;
        }
    }
}
