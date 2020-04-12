using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui



{
    abstract class GuiObject
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;

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