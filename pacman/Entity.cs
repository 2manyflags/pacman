﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    abstract class Entity
    {
        public abstract char move();
        public abstract bool isalive();
        public abstract void kill();
    }
}
