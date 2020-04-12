using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork03.Units
{
    class Hero : Unit
    {
    

        public Hero(int x, int y, string name) : base( x, y, name)
        {
         
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }
        public int GetX()
        {
            return x;
        }



    }
}
