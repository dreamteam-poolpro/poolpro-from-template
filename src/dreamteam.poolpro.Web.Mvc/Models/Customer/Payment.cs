using System;
namespace dreamteam.poolpro.Web.Models.Customer
{
    public class Payment
    {

        //primary key
        public int PaymentID { get; set; }

        //foreign keys
        public int CustomerID { get; set; }
        public int InvoiceID { get; set; }

        // type of payment
        public enum Type
        {
            Cash, CreditCard, DebitCard, PersonalCheck, CashiersCheck, MoneyOrder, PalPay,
        }

        // refernce, for check number, money order number, paypal transcation number etc...
        public string Reference { get; set; }

        //the date the payment was received
        public DateTime Received { get; set; }

        //total amount of payment
        public double AmountPaid { get; set; }
        
    }
}