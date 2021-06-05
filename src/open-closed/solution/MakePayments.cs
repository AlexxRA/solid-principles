using System;

namespace solid_principles.src.open_closed.solution
{
    class MakePayment
    {
        public IPayable Payment { get; set; }

        public MakePayment(IPayable payment)
        {
            Payment = payment;
        }

        public void Pay() {
            this.Payment.Pay();
        }
    }
}

/*Now we are using dependency injection on constructor in order to receive any type of payment*/