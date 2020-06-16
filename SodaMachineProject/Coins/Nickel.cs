using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Nickel : Coin
    {
        // MEMBER VARIABLES (HAS A)
        // CONSTRUCTOR (SPAWNER)
        public Nickel()
        {
            name = "Nickel";
            value = 0.05;
        }

        public Nickel(double nickelAmout)
        {
            value = 0.05 * nickelAmout;
        }
        // MEMBER METHODS (CAN DO)
    }
}
