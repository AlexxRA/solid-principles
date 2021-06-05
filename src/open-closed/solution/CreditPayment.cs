using System;

namespace solid_principles.src.open_closed.solution
{
    class CreditPayment : IPayable
    {
        public void Pay()
        {
            Console.WriteLine("Paying with credit");
        }
    }
}