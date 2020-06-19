namespace SodaMachineProject
{
    using System;
    using System.Collections.Generic;

    public class SodaMachine
    {
        // MEMBER VARIABLES (HAS A)
        public List<Coin> register;

        public List<Can> inventory;

        public string userChoice;

        public double registerTotalValue;

        // CONSTRUCTOR (SPAWNER)
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            AddCoinsToRegister();
            AddCansToSodaMachine();


            for (int i = 0; i < register.Count; i++)
            {
                registerTotalValue += register[i].Value;
            }
        }

        // MEMBER METHODS (CAN DO)


        // this method adds the coins to the register.
        public void AddCoinsToRegister()
        {

            for (int i = 0; i < 12; i++)
            {
                register.Add(new Quarter());
            }

            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }

            for (int i = 0; i < 10; i++)
            {
                register.Add(new Nickel());
            }

            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());

            }
        }

        // this method adds the Cans to the register.
        public void AddCansToSodaMachine()
        {
            for (int i = 0; i < 25; i++)
            {
                inventory.Add(new Pepsi());

            }

            for (int i = 0; i < 35; i++)
            {
                inventory.Add(new Fanta());

            }
            for (int i = 0; i < 35; i++)
            {
                inventory.Add(new RootBeer());

            }
        }

        // when this method called dispense soda from inventory
        public void DispenseSoda(Can can)
        {
            inventory.Remove(can);
        }

        // chooses a soda and dispense it as a can
        public Can ChooseASoda()
        {
            userChoice = StaticUserInterface.DisplaySodaOptions();

            Can can;
            switch (userChoice)
            {
                case "1":
                    can = inventory.Find(x => x.name == "Bundaberg Root Beer");

                    return can;
                case "2":
                    can = inventory.Find(x => x.name == "Pepsi");

                    return can;
                case "3":
                    can = inventory.Find(x => x.name == "Fanta");

                    return can;
                default:
                    Console.WriteLine("Please pick between 1-3");
                    return ChooseASoda();
            }
        }

        // Adds deposit to register
        public void AddDepositToRegister(List<Coin> deposit)
        {
            for (int i = 0; i < deposit.Count; i++)
            {
                register.Add(deposit[i]);
            }
        }

        // gives change to user and removes change from register
        public List<Coin> GiveChange(double changeToGive)
        {
            List<Coin> changeCoinList = new List<Coin>();
            while (changeToGive > 0)
            {
                if (changeToGive / 0.25 >= 1)
                {
                    if (changeToGive % 0.25 == 0)
                    {
                        for (int i = 0; i < changeToGive / 0.25; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Quarter");
                            if (coin == null)
                            {
                                break;
                            }
                            changeCoinList.Add(coin);
                            changeToGive -= coin.Value;
                            register.Remove(coin);
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.25);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Quarter");
                            if (coin == null)
                            {
                                break;
                            }
                            register.Remove(coin);
                            changeToGive -= coin.Value;
                            changeCoinList.Add(coin);
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }
                }
                else if (changeToGive / 0.10 >= 1)
                {
                    if (changeToGive % 0.10 == 0)
                    {
                        for (int i = 0; i < changeToGive / 0.10; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Dime");
                            if (coin == null)
                            {
                                break;
                            }
                            register.Remove(coin);
                            changeCoinList.Add(coin);
                            changeToGive -= coin.Value;
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.10);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Dime");
                            if (coin == null)
                            {
                                break;
                            }
                            register.Remove(coin);
                            changeCoinList.Add(coin);
                            changeToGive -= coin.Value;
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }
                }
                else if (changeToGive / 0.05 >= 1)
                {
                    if (changeToGive % 0.05 == 0)
                    {
                        for (int i = 0; i < changeToGive / 0.05; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Nickel");
                            if (coin == null)
                            {
                                break;
                            }
                            register.Remove(coin);
                            changeCoinList.Add(coin);
                            changeToGive -= coin.Value;
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.05);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Nickel");
                            if (coin == null)
                            {
                                break;
                            }
                            register.Remove(coin);
                            changeCoinList.Add(coin);
                            changeToGive -= coin.Value;
                            changeToGive = Math.Round(changeToGive, 2);
                        }
                    }

                }
                else if (changeToGive / 0.01 >= 1)
                {
                    double floor = Math.Floor(changeToGive / 0.01);
                    for (int i = 0; i < floor; i++)
                    {
                        Coin coin = register.Find(x => x.name == "Penny");
                        if (coin == null)
                        {
                            Console.WriteLine("Machine doesn't have enough money! Take your deposit!");
                            return null;
                        }
                        register.Remove(coin);
                        changeCoinList.Add(coin);
                        changeToGive -= coin.Value;
                        changeToGive = Math.Round(changeToGive, 2);
                    }
                }
            }
            return changeCoinList;
        }
    }
}
