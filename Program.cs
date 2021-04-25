using System;

namespace _25._04._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0.12, 54);

            car.AddFuel(12);

            Console.WriteLine("Current Fuel: {0}, LocalKm: {1}, GlobalKm: {2}", car.CurrentFuel, car.LocalKm, car.GlobalKm);

            Console.WriteLine(car.Drive(20));
            Console.WriteLine(car.AddFuel(40));

            Console.WriteLine("Current Fuel: {0}, LocalKm: {1}, GlobalKm: {2}", car.CurrentFuel, car.LocalKm, car.GlobalKm);

            Console.WriteLine(car.Drive(150));
            car.ResetLocal();

            Console.WriteLine("Current Fuel: {0}, LocalKm: {1}, GlobalKm: {2}", car.CurrentFuel, car.LocalKm, car.GlobalKm);

            Console.WriteLine(car.AddFuel(30));
            Console.WriteLine(car.Drive(180));

            Console.WriteLine("Son Current Fuel: {0}, LocalKm: {1}, GlobalKm: {2}", car.CurrentFuel, car.LocalKm, car.GlobalKm);
        }
    }
}
