using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Quarter : Coin
    {
        // MEMBER VARIABLES (HAS A)
        // CONSTRUCTOR (SPAWNER)
        public Quarter()
        {
            name = "Quarter";
            value = 0.25;
        }

        public Quarter(double quarterAmount)
        {
            value = 0.25 * quarterAmount;
        }
        // MEMBER METHODS (CAN DO)
    }
}
