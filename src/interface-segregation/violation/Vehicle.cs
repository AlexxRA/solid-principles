using System;

namespace solid_principles.src.interface_segregation.violation
{
    public class Vehicle
    {
        public virtual string GetMotorType()
        {
            return "Motor type is...";
        }

        public virtual string GetNumberOfWheels()
        {
            return "Number of wheels ...";
        }
    }
}