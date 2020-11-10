using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Interface for those machines which brews something
    /// </summary>
    interface IBrew
    {
        /// <summary>
        /// Method for acutally brewing.
        /// </summary>
        void Brew();
    }
}
