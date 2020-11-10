using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// Represents the filter - primarily used in CoffeeMakers
    /// </summary>
    class Filter
    {
        private FilterSize size;
        /// <summary>
        /// Size of the filter - since certain machines takes different sizes
        /// </summary>
        public FilterSize Size
        {
            get { return size; }
            set { size = value; }
        }

        private Beans fill;
        /// <summary>
        /// The amount of Beans, that are in the filter.
        /// </summary>
        public Beans Fill
        {
            get { return fill; }
            set { fill = value; }
        }
        /// <summary>
        /// Default constructer - Because we always need to know the size - or we wouldn't know whether it fits or not.
        /// </summary>
        /// <param name="size"></param>
        public Filter(FilterSize size)
        {
            Size = size;
        }


    }
}
