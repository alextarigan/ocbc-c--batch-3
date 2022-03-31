using System;
using System.ComponentModel.DataAnnotations;
namespace PaymentAPI.Models

{
    public class Payment
    {
        [Key]
        public int paymentDetailId {get; set;}
        public string cardOwnerName {get; set;}
        public string cardNumber {get; set;}
        public DateTime expirationDate {get; set;}
        public string securityCode{get; set;}
    }
}