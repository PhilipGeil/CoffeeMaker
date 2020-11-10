using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    /// <summary>
    /// This is Machine class - this represents all machine that are electrical and therefore has a powerstate.
    /// </summary>
    public abstract class Machine
    {
        private PowerState powerState;

        public PowerState PowerState
        {
            get { return powerState; }
            set { powerState = value; }
        }
        /// <summary>
        /// Default constructor for when object is being instantiated - It sets the PowerState to Off as default 
        /// </summary>
        public Machine()
        {
            this.PowerState = PowerState.Off;
        }
        /// <summary>
        /// Switch the PowerState - if Off then turn it On - if On then turn it Off.
        /// </summary>
        public void SwitchPowerState()
        {
            if (powerState == PowerState.Off)
            {
                this.PowerState = PowerState.On;
            } else
            {
                this.PowerState = PowerState.Off;
            }
        }

    }
}
