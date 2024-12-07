using Chystiakov_ICM_M724a_Power_Plant.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chystiakov_ICM_M724a_Power_Plant.Entities
{
    public class NuclearPowerPlant
    {
        public List<Sensors.Sensor> Sensors { get; set; }

        public PowerSystem Power { get; set; }
        public PressureRegulationSystem Regulator { get; set; }

        public NuclearPowerPlant()
        {
            Sensors = new List<Sensors.Sensor>();
            Power = new PowerSystem();
            Regulator = new PressureRegulationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors)
            {
                sensor.ReadValue();
            }
        }
    }
}
