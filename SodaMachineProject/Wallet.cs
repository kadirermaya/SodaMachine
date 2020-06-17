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
        private void AddCoinsToWallet()
        {
            for (int i = 0; i < 11; i++)
            {
            coins.Add(new Quarter());  //3 Dollars

            }
            for (int i = 0; i < 9; i++)
            {
            coins.Add(new Dime());    //1 Dollars

            }
            for (int i = 0; i < 9; i++)
            {
            coins.Add(new Nickel());  //50 cents

            }
            for (int i = 0; i < 50; i++)
            {
            coins.Add(new Peny());    //50 cents

            }
        }
    }
}
