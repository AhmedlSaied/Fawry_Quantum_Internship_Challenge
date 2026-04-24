using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    class ElectronicEngine : IEngine
    {
        private int speed = 0;

        public void Increase()
        {
            speed++;
            Console.WriteLine("Electric engine speed: " + speed);
        }

        public void Decrease()
        {
            if (speed > 0) speed--;
            Console.WriteLine("Electric engine speed: " + speed);
        }

        public int GetSpeed() => speed;
    }
}
