using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Simulation
    {
        // MEMBER VARIABLES (HAS A)
        public SodaMachine sodaMachine;
        public Customer customer;
        // CONSTRUCTOR (SPAWNER)
        public Simulation()
        {
            customer = new Customer();
            sodaMachine = new SodaMachine();
        }
    
        public void Run()
        {
            sodaMachine.WelcomeScreen();
            sodaMachine.DisplayInventory();
            customer.InsertMoney(customer.PickPayment());

            
        }
        // MEMBER METHODS (CAN DO)
    }
}
