using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// The Beans class, represents the beans that are used to make the given hot beverage - often it will probably be coffee
    /// </summary>
    public abstract class Beans
    {
        /// <summary>
        /// The amount of Beans that should be simulated in this particular instance of Beans
        /// </summary>
        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        /// <summary>
        /// Default constructor - Because we will ALWAYS need to know how many Beans.
        /// </summary>
        /// <param name="amount"></param>
        public Beans(double amount)
        {
            Amount = amount;
        }

    }
}
