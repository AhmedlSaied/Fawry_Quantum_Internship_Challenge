using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    class Car
    {
        private int speed = 0;
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        private void NotifyEngine()
        {
            if (engine is MixedHybridEngine hybrid)
            {
                hybrid.SetCarSpeed(speed);
            }
        }

        public void Start()
        {
            speed = 0;
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            if (speed == 0)
                Console.WriteLine("Car stopped.");
            else
                Console.WriteLine("Can't stop! Current speed: " + speed + " km/h");
        }

        public void Accelerate()
        {
            if (speed < 200)
            {
                for (int i = 0; i < 20; i++)
                {
                    speed++;
                    NotifyEngine();
                    engine.Increase();
                }
                Console.WriteLine("Car speed: " + speed + " km/h");
            }
            else
            {
                Console.WriteLine("Already at max speed: 200 km/h");
            }
        }

        public void Brake()
        {
            if (speed > 0)
            {
                int steps = Math.Min(20, speed);
                for (int i = 0; i < steps; i++)
                {
                    speed--;
                    NotifyEngine();
                    engine.Decrease();
                }
                Console.WriteLine("Car speed: " + speed + " km/h");
            }
            else
            {
                Console.WriteLine("Car is already stopped.");
            }
        }

        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
            Console.WriteLine("Engine replaced successfully.");
        }

        public int GetSpeed() => speed;
    }
}
