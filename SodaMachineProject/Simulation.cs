using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Simulation
    {
        // MEMBER VARIABLES (HAS A)
        public SodaMachine sodaMachine;
        public Customer customer;
        public bool addMoreMoney;
        public List<Coin> change;
        
        // CONSTRUCTOR (SPAWNER)
        public Simulation()
        {
            customer = new Customer();
            sodaMachine = new SodaMachine();
            addMoreMoney = true;
        }

        public void Run()
        {
            sodaMachine.WelcomeScreen();
            sodaMachine.DisplayInventory();
            while (addMoreMoney)
            {
                customer.InsertMoney(customer.PickPayment());
                Console.WriteLine($"Your deposit: {customer.depositAmount}");
                Console.WriteLine($"Would you like to add more money? Type Yes or No");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "no")
                {
                    addMoreMoney = false;
                    Console.WriteLine("");
                }
            }
            Can choosenSoda = sodaMachine.ChooseASoda();
           
            // this statement gives deposit back if there is no soda in the machine
            if (choosenSoda == null)
            {
                Console.WriteLine($"I don't have {choosenSoda.name}. Get your deposit back!");
                AddDepositToWallet();

            }
            // this statement checks register total value if there is enough money for change
            else if (sodaMachine.registerTotalValue < customer.depositAmount)
            {
                Console.WriteLine($"I don't have enough money for change. Get your deposit back!");
                AddDepositToWallet();
            }

            else if (choosenSoda.Cost == customer.depositAmount)
            {
                
                sodaMachine.DispenseSoda(choosenSoda);
                customer.AddCansToBackpack(choosenSoda);
                sodaMachine.AddDepositToRegister(customer.deposit);
                // make the deposit empty
                customer.deposit = new List<Coin>();
            }
            else if (choosenSoda.Cost < customer.depositAmount)
            {
            // we need to add GiveChange to list
                sodaMachine.DispenseSoda(choosenSoda);
                customer.AddCansToBackpack(choosenSoda);
                sodaMachine.AddDepositToRegister(customer.deposit);
                double changeAmount = Math.Round(CalculateTheChange(choosenSoda), 2);
                change = sodaMachine.GiveChange(changeAmount);
                AddChangeToWallet();
            }
            else 
            {
             // if not enough money passed in don`t complete the transaction.
                Console.WriteLine("You don't have enough money! Get your deposit back!");
                AddDepositToWallet();
            }


        }
        // MEMBER METHODS (CAN DO)

        // this methods adds deposits back to user wallet if transaction doesn't complete
        public void AddDepositToWallet()
        {
            for (int i = 0; i < customer.deposit.Count; i++)
            {
            customer.wallet.coins.Add(customer.deposit[i]);
            }
        }

        // Adds changes to wallet
        public void AddChangeToWallet()
        {
            for (int i = 0; i < change.Count; i++)
            {
                customer.wallet.coins.Add(change[i]);
            }
            change = new List<Coin>();
        }

        
        
        //this method calculates the change
        public double CalculateTheChange(Can soda)
        {
            double calculatedChange = customer.depositAmount - soda.Cost;
            return calculatedChange;
        }

        //else if (choosenSoda.Cost >= customer.depositAmount)
        //{
        //    Console.WriteLine("You don't have enough money!");
        //    while (choosenSoda.Cost != customer.depositAmount || choosenSoda.Cost < customer.depositAmount)
        //    {
        //        Console.WriteLine($"Would you like to add more money? Type Yes or No");
        //        string userInput = Console.ReadLine().ToLower();
        //        if(userInput == "no")
        //        {
        //            if (choosenSoda.Cost == customer.depositAmount || choosenSoda.Cost < customer.depositAmount)
        //            {

        //            }


        //            else 
        //            { 
        //            Console.WriteLine("Get your deposit back!");
        //            break;
        //            }
        //        }
        //        else 
        //        { 
        //        customer.InsertMoney(customer.PickPayment());
        //        }
        //    }
        //}

    }
}
        


