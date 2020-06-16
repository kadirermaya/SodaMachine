using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public abstract class Coin
    {
        // MEMBER VARIABLES (HAS A)
        protected double value;
        public string name;
        public double Value 
        { 
        get
            {
                return value;
            }
        
        set
            {
                Value = value;
            }
        
        }
        // CONSTRUCTOR (SPAWNER)
        // MEMBER METHODS (CAN DO)
    }
}
