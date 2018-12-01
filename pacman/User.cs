using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class User : Entity
    {
        int health = 1;
        public override char move()
        {
            throw new NotImplementedException();
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
