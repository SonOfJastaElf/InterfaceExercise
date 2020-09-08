using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int Wheels { get; set; } = 4;
        public string FuelType { get; set; } = "Gasoline";
        public string Model { get; set; } = "Beetle";
        public int Year { get; set; } = 1998;

        public string Name { get; set; } = "Volkswagen";
        public string Country { get; set; } = "Germany";

        public bool HasTrunk { get; set; } = true;
        public int Doors { get; set; } = 2;
    }
}
