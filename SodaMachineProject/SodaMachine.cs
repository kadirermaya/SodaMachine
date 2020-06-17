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
                register.Add(new Peny());

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
        
    }
}
        



    

