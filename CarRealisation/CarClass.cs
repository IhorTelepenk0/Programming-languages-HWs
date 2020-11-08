using System;
using System.Collections.Generic;
using System.Text;

namespace CarRealisation
{
    public class Car
    {
        private string _make;
        private int _yearOfProduction;
        private string _color;
        private float _petrolTankCapacity;
        private float _petrolUsagePer100Km;
        private float _kilometerCounter;
        private float _petrolLevel;
        private const float _maxKilometers = 200000f, _maxTermKilometers = 50000f;

        private float _kilometersNotCountedInLastTerm;

        public string Make => _make;
        public int YearOfProduction => _yearOfProduction;
        public string Color => _color;
        public float PetrolTankCapacity => _petrolTankCapacity; 
        public float PetrolUsagePer100Km => _petrolUsagePer100Km;

        public int KilometerCounter => Convert.ToInt32(Math.Truncate(_kilometerCounter));
        public int TermKilometerCounter => Convert.ToInt32(Math.Truncate(_kilometerCounter - _kilometersNotCountedInLastTerm));
        public float PetrolLevel => _petrolLevel;

        public Car(string make, string color, int yearOfProduction, float petrolTankCapacity, float petrolUsagePer100km)
        {
            if (string.IsNullOrEmpty(make))
                throw new ArgumentNullException("Make cannot be empty");

            if (string.IsNullOrEmpty(color))
                throw new ArgumentNullException("Colour cannot be empty");

            if (yearOfProduction < 2000 || yearOfProduction > DateTime.Now.Year)
                throw new ArgumentException("Year of production can be a number from 2000 to current year");

            if (petrolTankCapacity <= 0)
                throw new ArgumentException("Petrol tank capacity needs to be positive");

            if (petrolUsagePer100km < 0)
                throw new ArgumentException("Petrol usage needs to be not negative");

            _make = make;
            _color = color;
            _yearOfProduction = yearOfProduction;
            _petrolTankCapacity = petrolTankCapacity;
            _petrolUsagePer100Km = petrolUsagePer100km;
            _kilometersNotCountedInLastTerm = 0;
        }

        public void Tank(float litres)
        {
            if (litres < 0)
                throw new ArgumentException("Provide a positive value");

            if (_petrolLevel + litres > _petrolTankCapacity)
                _petrolLevel = _petrolTankCapacity;
            else
                _petrolLevel += litres;
        }

        public void Drive(float kilometers)
        {
            var range = _petrolLevel * 100 / _petrolUsagePer100Km;
            if (kilometers > range)
            {
                _kilometerCounter += range;
                _petrolLevel = 0;
            }
            else
            {
                _kilometerCounter += kilometers;
                _petrolLevel -= kilometers * PetrolUsagePer100Km / 100;
            }

            if(_kilometerCounter > _maxKilometers)
            {
                
                _kilometerCounter = _maxKilometers;

                if (TermKilometerCounter < _maxTermKilometers)
                {
                    _kilometersNotCountedInLastTerm = -(_kilometerCounter - _maxKilometers);
                }
                
            }

            if(TermKilometerCounter > _maxTermKilometers)
            {
                ResetTermKilometerCounter();
                
            }
        }

        public void Paint(string newColor)
        {
            _color = newColor;
        }

        public void ResetTermKilometerCounter()
        {
            _kilometersNotCountedInLastTerm = _kilometerCounter;
        }
    }

}
