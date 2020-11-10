using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Represents a Pot - It is the end station for the beverage when the machine is done with it, and it is meant to hold a certain amount of something liquid
    /// </summary>
    public abstract class Pot
    {
        private double capacity;
        /// <summary>
        /// The capacity of the Pot
        /// </summary>
        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private double keepWarmDuration;
        /// <summary>
        /// How long it can keep warm
        /// </summary>
        public double KeepWarmDuration
        {
            get { return keepWarmDuration; }
            set { keepWarmDuration = value; }
        }
        /// <summary>
        /// Default constructor for Pot - because we always wants to know the capacity and the keepWarmDuration.
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="keepWarmDuration"></param>
        public Pot(double capacity, double keepWarmDuration)
        {
            Capacity = capacity;
            KeepWarmDuration = keepWarmDuration;
        }


    }
}
