using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork03.Game
{
    class Hero
    {
        private int x;
        private int y;
        private string name;

        public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Hero {name} is at {x}x{y}");
        }

       
    }
}
