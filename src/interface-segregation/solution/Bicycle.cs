using System;

namespace solid_principles.src.interface_segregation.solution
{
    public class Bicyle : IWheelVehicle
    {
        public string GetNumberOfWheels()
        {
            return "number of wheels are...";
        }
    }
}