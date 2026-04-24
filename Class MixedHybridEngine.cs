using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    class MixedHybridEngine : IEngine
    {
        private GasolineEngine gasEngine = new GasolineEngine();
        private ElectronicEngine electricEngine = new ElectronicEngine();
        private int carSpeed = 0;

        public void SetCarSpeed(int carSpeed)
        {
            this.carSpeed = carSpeed;
        }

        private IEngine GetActiveEngine()
        {
            return carSpeed < 50 ? electricEngine : gasEngine;
        }

        public void Increase() => GetActiveEngine().Increase();
        public void Decrease() => GetActiveEngine().Decrease();
        public int GetSpeed() => GetActiveEngine().GetSpeed();
    }
}
