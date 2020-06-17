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
        public List<Coin> deposit;
        public string userInput;
        // CONSTRUCTOR (SPAWNER)
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            deposit = new List<Coin>();
        }
        // MEMBER METHODS (CAN DO)
        
        // 
        public Coin PickPayment()
        {
            Console.WriteLine("Insert a coin to pick your soda!");
            Console.WriteLine("1: Quarter \n2: Dime \n3: Nickel \n4: Penny");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Coin coin = new Quarter();
                return coin;
            }
            else if (userInput == "2")
            {
                Coin coin = new Dime();
                return coin;
            }
            else if (userInput == "3")
            {
                Coin coin = new Nickel();
                return coin;
            }
            else if (userInput == "4")
            {
                Coin coin = new Nickel();
                return coin;
            }
            else
            {
                return PickPayment();
            }
            
        }


        //this method adds cans to the backpack
        public void AddCansToBackpack(Can can)
        {
            backpack.cans.Add(can);
        }

      

        // method takes the coin from wallet and adds to deposit
        public Coin InsertMoney(Coin coin)
        {
            switch (userInput)
            {
                case "1": 
                    coin = wallet.coins.Find(x => x.name == "Quarter");
                    deposit.Add(coin);
                    RemoveCoinFromWallet(coin);
                    Console.WriteLine($"You inserted {wallet.coins.Find(x => x.name == "Quarter").Value}");
                    return coin;
                case "2":
                    coin = wallet.coins.Find(x => x.name == "Dime");
                    deposit.Add(coin);
                    RemoveCoinFromWallet(coin);
                    Console.WriteLine($"You inserted {wallet.coins.Find(x => x.name == "Dime").Value}");
                    return coin;
                case "3":
                    coin = wallet.coins.Find(x => x.name == "Nickel");
                    deposit.Add(coin);
                    RemoveCoinFromWallet(coin);
                    Console.WriteLine($"You inserted {wallet.coins.Find(x => x.name == "Nickel").Value}");
                    return coin;
                case "4":
                    coin = wallet.coins.Find(x => x.name == "Peny");
                    deposit.Add(coin);
                    RemoveCoinFromWallet(coin);
                    Console.WriteLine($"You inserted {wallet.coins.Find(x => x.name == "Peny").Value}");
                    return coin;

                default:
                    Console.WriteLine("Please pick money to deposit.");
                    return InsertMoney(coin);
            }
            
        }

       // removes coin from the wallet
        public void RemoveCoinFromWallet(Coin coin)
        {
            wallet.coins.Remove(coin);
        }
    }
}

