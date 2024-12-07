using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chystiakov_ICM_M724a_Power_Plant.Entities.Systems
{
    public class PowerSystem
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Reactor turned on");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Reactor turned off");
        }
    }
}
