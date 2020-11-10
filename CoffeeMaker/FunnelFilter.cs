using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// A certain sort of coffee filters - no idea if Funnel Filter is a real thing, but if translated directly to danish, it is.
    /// </summary>
    class FunnelFilter : Filter
    {
        /// <summary>
        /// Default constructor - takes from it's base class.
        /// </summary>
        public FunnelFilter(FilterSize size) : base(size)
        {
        }
    }
}
