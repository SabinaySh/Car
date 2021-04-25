using System;
using System.Collections.Generic;
using System.Text;

namespace _25._04._21
{
    class Car
    {
        private double _fuelCapacity;
        public double FuelCapacity => _fuelCapacity;

        private double _fuelUsage;
        public double FuelUsage => _fuelUsage;

        private double _currentFuel;
        public double CurrentFuel => _currentFuel;

        private double _localKm;
        public double LocalKm => _localKm;

        private double _globalKm;
        public double GlobalKm => _globalKm;


        public Car(double FuelUsage, double FuelCapacity)
        {
            _fuelUsage = FuelUsage;
            _fuelCapacity = FuelCapacity;

            _currentFuel = _fuelCapacity * 0.2;
        }

        public bool Drive(double km)
        {
            if (km > _currentFuel / _fuelUsage)
            {
                return false;
            }

            _localKm += km;
            _globalKm += km;

            _currentFuel -= km * _fuelUsage;
            return true;
        }

        public bool AddFuel(double litr)
        {
            if (_currentFuel + litr > _fuelCapacity)
            {
                return false;
            }

            _currentFuel += litr;
            return true;
        }

        public bool AddFuel(int amount)
        {
            double litr = amount * 1.1;

            if (_currentFuel + litr > _fuelCapacity)
            {
                return false;
            }

            _currentFuel += litr;
            return true;
        }

        public void ResetLocal()
        {
            _localKm = 0;
        }
    }
}
