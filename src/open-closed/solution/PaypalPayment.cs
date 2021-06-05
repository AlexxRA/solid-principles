using System;

namespace solid_principles.src.open_closed.solution
{
    class PaypalPayment : IPayable
    {
        public void Pay()
        {
            Console.WriteLine("Paying with Paypal");
        }
    }
}