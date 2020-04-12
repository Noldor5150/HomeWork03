using System;
using System.Collections.Generic;



namespace HomeWork03.Game

{
    class Program
    {
        static void Main(string[] args)
        {
            GameScreen myGame = new GameScreen(30, 20);

            myGame.SetHero(new Hero(5, 5, "HERO"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            myGame.Render();

            myGame.MoveHeroLeft();
            myGame.MoveAllEnemiesDown();

            Enemy secondEnemy = myGame.GetEnemyById(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            myGame.Render();

            Console.ReadKey();

        }
    }
}
