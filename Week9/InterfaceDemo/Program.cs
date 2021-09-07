using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {


        interface ICar
        {
            void Drive();

            void AddGas(int amount);
        }

        class CompactCar : ICar
        {
            int GasAmount;
            public void Drive()
            {
                Console.WriteLine("I'm Driving");
            }

            public void AddGas(int amount)
            {
                GasAmount = amount;
                Console.WriteLine($"I'm Adding Gas. Now have {GasAmount}");
            }
        }

        class HighPerfCar : ICar
        {
            int GasAmount;
            public void Drive()
            {
                Console.WriteLine("I'm Driving Fast");
            }

            public void AddGas(int amount)
            {
                GasAmount = amount;
                Console.WriteLine($"I'm Adding High-Octane Fuel. Now have {GasAmount}");
            }
        }

        static void Main(string[] args)
        {
            CompactCar car1 = new CompactCar();
            car1.Drive();
            car1.AddGas(5);

            HighPerfCar car2 = new HighPerfCar();
            car2.Drive();
            car2.AddGas(5);

            List<ICar> cars = new List<ICar>();
            cars.Add(car1);
            cars.Add(car2);

            //ICar test = new CompactCar(); //Advanced topic. Look into later on
        }
    }
}
