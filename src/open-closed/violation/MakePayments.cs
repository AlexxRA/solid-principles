using System;

namespace solid_principles.src.open_closed.violation
{
    class MakePayment
    {
        public Payment Payment { get; set; }

        public string PaymentType { get; set; }

        public MakePayment(string paymentType)
        {
            PaymentType = paymentType;
        }

        public void Pay() {
            if(this.PaymentType == "Paypal") {
                this.Payment.PaypalPayment();
            }
            else if(this.PaymentType == "Credit") {
                this.Payment.CreditPayment();
            }
        }
    }
}

/*The problem with this class is on the method Pay, which it only allows 2 payment types. If we need to add a WirePayment logic, it is necessary to modify this class and 
that violates the open-closed principle.*/