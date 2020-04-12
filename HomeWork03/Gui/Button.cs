using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui
{
    class Button : GuiObject
    {
        private Frame notActiveFrame;
        private Frame activeFrame;

        private bool isActive = false;
        private TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            this.notActiveFrame = new Frame(x, y, width, height, '+');
            this.activeFrame = new Frame(x, y, width, height, '-');

            this.textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void SetActive()
        {
            isActive = true;
        }
    }
}