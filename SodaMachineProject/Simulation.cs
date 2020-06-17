using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Simulation
    {
        // MEMBER VARIABLES (HAS A)
        public SodaMachine sodaMachine;
        public Customer customer;
        public bool addMoreMoney;
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
            if (choosenSoda.Cost <= customer.depositAmount)
            {
                sodaMachine.DispenseSoda(choosenSoda);
                customer.AddCansToBackpack(choosenSoda);
                sodaMachine.AddDepositToRegister(customer.deposit);
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
        


