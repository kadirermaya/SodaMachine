using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Customer
    {
        // MEMBER VARIABLES (HAS A)
        public Wallet wallet;
        public Backpack backpack;
        // CONSTRUCTOR (SPAWNER)
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
        }
        // MEMBER METHODS (CAN DO)
    }
}
