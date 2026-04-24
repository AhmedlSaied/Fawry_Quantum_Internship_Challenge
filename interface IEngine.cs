using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    interface IEngine
    {
        void Increase();
        void Decrease();
        int GetSpeed();
    }
}