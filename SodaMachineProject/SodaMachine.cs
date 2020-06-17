using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class SodaMachine
    {
        // MEMBER VARIABLES (HAS A)
        public List<Coin> register;
        public List<Can> inventory;
        public string userChoice;

        // CONSTRUCTOR (SPAWNER)
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            AddCoinsToRegister();
            AddCansToSodaMachine();
        }

        // MEMBER METHODS (CAN DO)

        // this method adds the coins to the register.
        public void AddCoinsToRegister()
        {

            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter());
            }

            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }

            for (int i = 0; i < 20; i++)
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

       // displays welcome screen
        public void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Soda Machine. Would you like to buy Soda?");
        }

        // this method displays what the soda machine has!
        public void DisplayInventory()
        {
            Console.WriteLine($"\nI have:\nRoot Beer   $0.60  \nPepsi   $0.35\nFanta   $0.06");
            
            //Console.WriteLine("\nInsert money and pick one.");

        }

        // when this method called dispense soda from inventory
        public void DispenseSoda(Can can)
        {
            inventory.Remove(can);
        }


        // chooses a soda and dispense it as a can
        public Can ChooseASoda()
        {
            Console.WriteLine($"Which one would you like to buy?");
            Console.WriteLine("1 = Root Beer, 2 = Pepsi, 3 = Fanta");
            userChoice = Console.ReadLine();
            
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
                default :
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
        public List<Coin> GiveChange(double changeToGive)//double parameter?
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
                            changeCoinList.Add(coin);
                            changeToGive -= 0.25;
                            register.Remove(coin);
                        }

                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.25);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Quarter");
                            changeCoinList.Add(coin);
                            changeToGive -= 0.25;
                            register.Remove(coin);
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
                            changeCoinList.Add(coin);
                            changeToGive -= 0.10;
                            register.Remove(coin);
                        }

                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.10);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Dime");
                            changeCoinList.Add(coin);
                            changeToGive -= 0.10;
                            register.Remove(coin);
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
                            changeCoinList.Add(coin);
                            changeToGive -= 0.05;
                            register.Remove(coin);
                        }

                    }
                    else
                    {
                        double floor = Math.Floor(changeToGive / 0.05);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Nickel");
                            changeCoinList.Add(coin);
                            changeToGive -= 0.05;
                            register.Remove(coin);
                        }
                    }

                }
                else if (changeToGive / 0.01 >= 1)
                {
                    
                        double floor = Math.Floor(changeToGive / 0.01);
                        for (int i = 0; i < floor; i++)
                        {
                            Coin coin = register.Find(x => x.name == "Penny");
                            changeCoinList.Add(coin);
                            changeToGive -= 0.01;
                            register.Remove(coin);
                        }
                   
                    //look at parameter and turn it into a list of coins with that value
                }
            }   
                return changeCoinList;
        }
    }
}

            
        

    

        



    

