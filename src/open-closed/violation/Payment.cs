using System;

namespace solid_principles.src.open_closed.violation
{
    class Payment
    {
        public void PaypalPayment () {
            Console.WriteLine("Paying with Paypal");
        }
        
        public void CreditPayment () {
            Console.WriteLine("Paying with credit");
        }

    }
}