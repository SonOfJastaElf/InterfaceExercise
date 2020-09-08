using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public string FuelType { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
