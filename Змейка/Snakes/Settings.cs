﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Settings
    {

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 40;
            Height = 40;
            directions = "left";
        }


    }
}
