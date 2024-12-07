using Chystiakov_ICM_M724a_Power_Plant.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chystiakov_ICM_M724a_Power_Plant.Entities.Sensors
{
    public class TemperatureSensor : Sensor
    {
        public override SensorType Type => SensorType.Temperature;

        public TemperatureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 350; //320 градусів є робочим значенням 
            Console.WriteLine($"{Name} Temperature: {Value} C");
        }
    }
}
