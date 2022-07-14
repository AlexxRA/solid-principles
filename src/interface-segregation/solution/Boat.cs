using System;

namespace solid_principles.src.interface_segregation.solution
{
    public class Boat : IMotorVehicle
    {
        public string GetMotorType()
        {
            return "The motor type is...";
        }
    }
}