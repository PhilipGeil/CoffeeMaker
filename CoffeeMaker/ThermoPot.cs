using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Represents a ThermoPot, that is meant for holding a certain amount of some hot liquid - and keeping it hot for an amount of time.
    /// </summary>
    class ThermoPot : Pot
    {
        /// <summary>
        /// Uses it's base class' default constructor 
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="keepWarmDuration"></param>
        public ThermoPot(double capacity, double keepWarmDuration) : base(capacity, keepWarmDuration) { }
    }
}
