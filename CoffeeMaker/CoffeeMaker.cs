using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// This is the CoffeMaker class - it represents all machines that brews coffee based on water, filter and coffee beans
    /// </summary>
    class CoffeeMaker : Machine, IBrew
    {
        private WaterContainer waterContainer;
        /// <summary>
        /// Instance of WaterContainer - used for checking if it needs refilling, and or how much coffee can be made.
        /// </summary>
        public WaterContainer WaterContainer
        {
            get { return waterContainer; }
            set { waterContainer = value; }
        }

        private Pot pot;
        /// <summary>
        /// Instance of Pot, this is the pot where the coffee is being poured into, once the machine has finished the brewing.
        /// </summary>
        public Pot Pot
        {
            get { return pot; }
            set { pot = value; }
        }

        private Filter filter;
        /// <summary>
        /// Instance of filter, the place you put the Beans, and makes the coffee alot smoother and nicer.
        /// </summary>
        public Filter Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public void Brew()
        {
            //Start the brewing, where the water would be heated, and then inserted to the filter, and then combined with the beans, 
            // end up in the pot, ready to drink
        }



    }
}
