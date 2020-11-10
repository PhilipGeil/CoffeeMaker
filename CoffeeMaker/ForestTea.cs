using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Represents ForestTea, which obviously inherits from Beans - Or not.. - The idea is right though, it's just bad naming..
    /// </summary>
    class ForestTea : Beans
    {
        /// <summary>
        /// Default constructor - takes from it's base class.
        /// </summary>
        /// <param name="amount"></param>
        ForestTea(double amount) : base(amount) { }
    }
}
