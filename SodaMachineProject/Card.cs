using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Card
    {
        // MEMBER VARIABLES (HAS A)
        protected double availableFunds;
        public double AvailableFunds
        {
            get 
            {
                return availableFunds;
            }
           
        }
        // CONSTRUCTOR (SPAWNER)
        public Card()
        {
            availableFunds = 2000;
        }

        // MEMBER METHODS (CAN DO)


    }
}
