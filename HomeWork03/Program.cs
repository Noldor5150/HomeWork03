using System;
using System.Collections.Generic;
using HomeWork03.Units;
using HomeWork03.Gui;



namespace HomeWork03.Game

{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();

            Console.ReadKey();
            /*GameController myGame = new GameController();
            myGame.StartGame();*/
        }
    }
}
