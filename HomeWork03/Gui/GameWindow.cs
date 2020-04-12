using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03.Gui
{
    class GameWindow : Window
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;


        public GameWindow() : base(0, 0, 120, 30, '<')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Hyper Turbo Game", "Created by C# Wizzards Guild", "Made in Minas Tirith" });

            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.SetActive();

            creditsButton = new Button(50, 13, 18, 5, "Credits");

            quitButton = new Button(80, 13, 18, 5, "Quit");
        }

        public void Render()
        {
            base.Render();

            titleTextBlock.Render();

            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}