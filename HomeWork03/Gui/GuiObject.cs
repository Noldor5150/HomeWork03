﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui
{
    abstract class GuiObject
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public GuiObject(int x, int y, int width, int height)
        {
            this.x= x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        abstract public void Render();
    }
}