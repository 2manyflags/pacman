using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class Ghost4 : Entity
    {
        char dir = 'W';
        Random rand;
        int direction;
        int health = 1;
        public override char move()
        {
            rand = new Random();
            direction = rand.Next(1, 5);
            if (direction == 1)
                return 'D';
            else if (direction == 2)
                return 'S';
            else if (direction == 3)
                return 'A';
            else
                return 'W';
        }
        public override bool isalive()
        {
            if (health == 0)
                return false;
            else
                return true;
        }
        public override void kill()
        {
            health = 0;
        }
    }
}
