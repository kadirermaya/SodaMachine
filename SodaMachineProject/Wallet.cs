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
            AddCoinsToWallet();
        }
        // MEMBER METHODS (CAN DO)

        // this method adds 5 dollars in a wallet
        public void AddCoinsToWallet()
        {
            coins.Add(new Quarter(12));  //3 Dollars
            coins.Add(new Dime(10));    //1 Dollars
            coins.Add(new Nickel(10));  //50 cents
            coins.Add(new Peny(50));    //50 cents
        }
    }
}
