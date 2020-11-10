using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Represents the WaterContainer of the given machine - this is the container which you pour the water into, and the machine uses to make the beverage.
    /// </summary>
    class WaterContainer
    {
        private double capacity;
        /// <summary>
        /// How big the capacity is for the given WaterContainer
        /// </summary>
        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        /// <summary>
        /// Default constructor, becasue we will always want to know the capacity.
        /// </summary>
        /// <param name="capacity"></param>
        public WaterContainer(double capacity)
        {
            Capacity = capacity;
        }

    }
}
