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
            StaticUserInterface.WelcomeScreen();
            StaticUserInterface.DisplayProducts();
            while (addMoreMoney)
            {
                customer.InsertMoney(customer.PickPayment());
                Console.Clear();
                StaticUserInterface.WelcomeScreen();
                StaticUserInterface.DisplayProducts();
                Console.WriteLine($"\nYour deposit: {customer.depositAmount}");
                string userInput = StaticUserInterface.DisplayAskAddMoreMoney();
                if (userInput == "no")
                {
                    addMoreMoney = false;
                    Console.WriteLine("");
                    Console.Clear();
                    StaticUserInterface.WelcomeScreen();
                    StaticUserInterface.DisplayProducts();
                    Console.WriteLine($"\nYour deposit: {customer.depositAmount}");
                }
            }

            Can choosenSoda = sodaMachine.ChooseASoda();
           
            // this statement gives deposit back if there is no soda in the machine
            if (choosenSoda == null)
            {
                Console.WriteLine($"I don't have {choosenSoda.name}. Get your deposit back!");
                AddDepositToWallet();
            }
             
            else if (choosenSoda.Cost == customer.depositAmount)
            {
                
                sodaMachine.AddDepositToRegister(customer.deposit);
                sodaMachine.DispenseSoda(choosenSoda);
                Console.WriteLine($"Enjoy with your {choosenSoda.name}");
                customer.AddCansToBackpack(choosenSoda);
                // make the deposit empty
                customer.deposit = new List<Coin>();
            }

            else if (choosenSoda.Cost < customer.depositAmount)
            {
                sodaMachine.AddDepositToRegister(customer.deposit);
                double changeAmount = Math.Round(CalculateTheChange(choosenSoda), 2);
                change = sodaMachine.GiveChange(changeAmount);
                if (change == null)
                {
                    AddDepositToWallet();
                    StaticUserInterface.DisplayRegisterHasNoChange();
                    
                } else
                {
                    sodaMachine.DispenseSoda(choosenSoda);
                    Console.WriteLine($"Enjoy with your {choosenSoda.name}");
                    customer.AddCansToBackpack(choosenSoda);
                    AddChangeToWallet();
                }
                                
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
        public double  CalculateTheChange(Can soda)
        {
            double calculatedChange = customer.depositAmount - soda.Cost;
            Console.WriteLine($"\nYour change {calculatedChange}");
            return calculatedChange;
        }

        
    }
}
        


