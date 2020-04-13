using HomeWork03.Game;
using HomeWork03.Gui.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork03.Gui
{
    class GuiController : IGuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;
        private GameController gameController;

        public GuiController()
        {
            this.gameWindow = new GameWindow();
            this.creditWindow = new CreditWindow();
            this.gameController = new GameController();
        }

        public void ShowMenu()
        {
            Console.Clear();
            this.gameWindow.Render();
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey();
                int hashCode = pressedChar.Key.GetHashCode();

                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        Button button = this.gameWindow.returnActiveButton();
                        if(button.buttonName == "Start")
                        {
                            this.gameController.StartGame();
                        }
                        else if (button.buttonName == "Credits")
                        {
                            this.creditWindow.Render();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        this.gameWindow.SetNextButtonActive();
                        break;
                    case ConsoleKey.LeftArrow:
                        this.gameWindow.SetPreviousButtonActive();
                        break;
                }

                this.gameWindow.Render();

            } while (true);
        }
    }
}
