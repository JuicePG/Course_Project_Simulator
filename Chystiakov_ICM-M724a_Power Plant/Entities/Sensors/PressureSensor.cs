using Chystiakov_ICM_M724a_Power_Plant.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chystiakov_ICM_M724a_Power_Plant.Entities.Sensors
{
    public class PressureSensor : Sensor
    {
        public override SensorType Type => SensorType.Pressure;

        public PressureSensor(string name, string description)
            : base (name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 20; //15.7 МПа є робочим значенням
            Console.WriteLine($"{Name} Pressure: {Value} MPa");
        }
    }
}