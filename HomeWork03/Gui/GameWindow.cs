using HomeWork03.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui
{
    sealed class GameWindow : Window
    {
   
        private TextBlock titleTextBlock;
        private List<Button> buttons;


        public GameWindow() : base(0, 0, 120, 30, '<')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Hyper Turbo Game", "Created by C# Wizzards Guild", "Made in Minas Tirith" });
            this.buttons = new List<Button>
            {
                new Button(20, 13, 18, 5, ButtonNames.StartButton),
                new Button(50, 13, 18, 5, ButtonNames.CreditsButton),
                new Button(80, 13, 18, 5, ButtonNames.QuitButton)
            };

            this.buttons[0].SetActive();
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            foreach (Button button in this.buttons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public void SetPreviousButtonActive()
        {
            Button button = this.buttons.Where(x => x.isActive == true).Single();
            int index = this.buttons.IndexOf(button);
            buttons[index].SetNotActive();
            if(index == 0)
            {
                index = this.buttons.Count() - 1;
            }
            else
            {
                index = index - 1;
            }

            buttons[index].SetActive();
        }

        public void SetNextButtonActive()
        {
            Button button = this.buttons.Where(x => x.isActive == true).Single();
            int index = this.buttons.IndexOf(button);
            buttons[index].SetNotActive();
            if (index == this.buttons.Count() - 1)
            {
                index = 0;
            }
            else
            {
                index = index + 1;
            }

            buttons[index].SetActive();
        }

        public Button returnActiveButton()
        {
            return this.buttons.Where(x => x.isActive == true).Single();
        }
    }
}