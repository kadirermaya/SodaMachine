using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Peny : Coin
    {
        // MEMBER VARIABLES (HAS A)
        // CONSTRUCTOR (SPAWNER)
        public Peny()
        {
            name = "Peny";
            value = 0.01;
        }
        public Peny(double penyAmount)
        {
            value = 0.01 * penyAmount;
        }
        // MEMBER METHODS (CAN DO)
    }
}
