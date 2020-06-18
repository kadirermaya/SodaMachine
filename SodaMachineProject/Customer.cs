namespace SodaMachineProject
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        // MEMBER VARIABLES (HAS A)
        public Wallet wallet;

        public Backpack backpack;

        public List<Coin> deposit;

        public double depositAmount;

        public string userInput;

        // CONSTRUCTOR (SPAWNER)
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            deposit = new List<Coin>();
            depositAmount = 0;
        }

        // MEMBER METHODS (CAN DO)

        //
        public Coin PickPayment()
        {
            Console.WriteLine("\nInsert a coin!");
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
                Coin coin = new Penny();
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
                    if (coin != null)
                    {
                        deposit.Add(coin);
                        CalculateDeposit();
                        RemoveCoinFromWallet(coin);
                        return coin;
                    }
                    StaticUserInterface.Display($"You don't have Quarter in your wallet! Pick another one!");
                    return InsertMoney(PickPayment());

                case "2":
                    coin = wallet.coins.Find(x => x.name == "Dime");
                    if (coin != null)
                    {
                        deposit.Add(coin);
                        CalculateDeposit();
                        RemoveCoinFromWallet(coin);
                        return coin;
                    }
                    StaticUserInterface.Display($"You don't have Dime in your wallet! Pick another one!");
                    return InsertMoney(PickPayment());

                case "3":
                    coin = wallet.coins.Find(x => x.name == "Nickel");
                    if (coin != null)
                    {
                        deposit.Add(coin);
                        CalculateDeposit();
                        RemoveCoinFromWallet(coin);
                        return coin;
                    }
                    StaticUserInterface.Display($"You don't have Nickel in your wallet! Pick another one!");
                    return InsertMoney(PickPayment());

                case "4":
                    coin = wallet.coins.Find(x => x.name == "Penny");
                    if (coin != null)
                    {
                        deposit.Add(coin);
                        CalculateDeposit();
                        RemoveCoinFromWallet(coin);
                        return coin;
                    }
                    StaticUserInterface.Display($"You don't have Penny in your wallet! Pick another one!");
                    return InsertMoney(PickPayment());

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

        // calculates deposit
        public double CalculateDeposit()
        {
            depositAmount = 0;
            for (int i = 0; i < deposit.Count; i++)
            {

                depositAmount += deposit[i].Value;

            }



            return depositAmount;
        }
    }
}
//else
//{
//    StaticUserInterface.Display($"You don't have more {deposit[i].name} Pick another money!");
//    break;
//}