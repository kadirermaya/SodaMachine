using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Wallet
    {
        // MEMBER VARIABLES (HAS A)
        public List<Coin> coins;
        public Card card;
        // CONSTRUCTOR (SPAWNER)
        public Wallet()
        {
            coins = new List<Coin>();
            card = new Card();
        }
        // MEMBER METHODS (CAN DO)
    }
}
