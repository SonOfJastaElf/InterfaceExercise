using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int Wheels { get; set; } = 4;
        public string FuelType { get; set; } = "Diesel";
        public string Model { get; set; } = "Escape";
        public int Year { get; set; } = 2008;

        public string Name { get; set; } = "Ford";
        public string Country { get; set; } = "USA";

        public int CargoSpace { get; set; } = 30;
        public int Seats { get; set; } = 7;
    }
}
