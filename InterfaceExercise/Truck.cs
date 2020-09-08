using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int Wheels { get; set; } = 4;
        public string FuelType { get; set; } = "Gasoline";
        public string Model { get; set; } = "Ram";
        public int Year { get; set; } = 2011;

        public string Name { get; set; } = "Dodge";
        public string Country { get; set; } = "USA";

        public int BedLength { get; set; } = 12;
        public int CabCapacity { get; set; } = 4;
    }
}
