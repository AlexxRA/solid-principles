using System;

namespace solid_principles.src.interface_segregation.violation
{
    public class Boat : Vehicle
    {
        public override string GetMotorType()
        {
            return "The motor is...";
        }

        public override string GetNumberOfWheels()
        {
            throw new NotSupportedException();
        }
    }
}