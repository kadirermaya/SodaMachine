using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class SodaMachine
    {
        // MEMBER VARIABLES (HAS A)
        public List<Coin> register;
        public List<Can> inventory;
        // CONSTRUCTOR (SPAWNER)
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
        }
        // MEMBER METHODS (CAN DO)
    }
}
