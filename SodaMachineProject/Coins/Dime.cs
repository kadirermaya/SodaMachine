﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Dime : Coin
    {
        // MEMBER VARIABLES (HAS A)

        // CONSTRUCTOR (SPAWNER)
        public Dime()
        {
            name = "Dime";
            value = 0.10;
        }

        public Dime(double dimeAmount)
        {
            value = 0.10 * dimeAmount;
        }
        // MEMBER METHODS (CAN DO)
    }
}
