using System;

namespace solid_principles.src.interface_segregation.violation
{
    public class Bicycle : Vehicle
    {
        public override string GetMotorType()
        {
            throw new NotSupportedException();
        }

        public override string GetNumberOfWheels()
        {
            return "This has 2 wheels...";
        }
    }
}