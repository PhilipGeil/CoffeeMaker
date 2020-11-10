using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// One of the two most popular sorts of Coffee Beans - apparently
    /// </summary>
    class AribacaBeans : Beans
    {
        /// <summary>
        /// Defualt constructor - takes from it's base class
        /// </summary>
        /// <param name="amount"></param>
        public AribacaBeans(double amount) : base(amount) { }
    }
}
