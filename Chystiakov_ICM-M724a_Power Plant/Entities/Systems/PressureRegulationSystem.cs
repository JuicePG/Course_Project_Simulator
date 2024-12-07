
using Chystiakov_ICM_M724a_Power_Plant.Entities.Sensors;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chystiakov_ICM_M724a_Power_Plant.Entities.Systems
{
    public class PressureRegulationSystem
    {
        public bool Reg { get; private set; }

        public void RegulateUp()
        {
            Reg = true;
            Console.WriteLine("Regulator is increasing the pressure.");
        }
        public void RegulateDown()
        {
            Reg = false;
            Console.WriteLine("Regulator is reducing the pressure.");
        }
    }
}
