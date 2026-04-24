using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    class CarFactory
    {
        public Car CreateCar(string engineType)
        {
            return new Car(BuildEngine(engineType));
        }

        public void ReplaceEngine(Car car, string engineType)
        {
            car.SetEngine(BuildEngine(engineType));
        }

        private IEngine BuildEngine(string engineType)
        {
            return engineType.ToLower() switch
            {
                "gas" => new GasolineEngine(),
                "electric" => new ElectronicEngine(),
                "hybrid" => new MixedHybridEngine(),
                _ => throw new ArgumentException("Unknown engine type: " + engineType)
            };
        }
    }
}
