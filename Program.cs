using Fawry_Quantum_Internship_Challenge;
using System;
class Program
{
    static void Main(string[] args)
    {
        CarFactory factory = new CarFactory();

        Console.WriteLine("=== Gas Car ===");
        Car gasCar = factory.CreateCar("gas");
        gasCar.Start();
        gasCar.Accelerate(); 
        gasCar.Accelerate(); 
        gasCar.Brake();      
        gasCar.Brake();      
        gasCar.Stop();

        Console.WriteLine("\n=== Electric Car ===");
        Car electricCar = factory.CreateCar("electric");
        electricCar.Start();
        electricCar.Accelerate(); 
        electricCar.Accelerate(); 
        electricCar.Stop();       

        Console.WriteLine("\n=== Hybrid Car ===");
        Car hybridCar = factory.CreateCar("hybrid");
        hybridCar.Start();
        hybridCar.Accelerate(); 
        hybridCar.Accelerate(); 
        hybridCar.Accelerate(); 
        hybridCar.Brake();      

        Console.WriteLine("\n=== Replace Engine ===");
        factory.ReplaceEngine(gasCar, "electric");
        gasCar.Start();
        gasCar.Accelerate();
    }
}
