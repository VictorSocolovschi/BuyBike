﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace BuyBikeShop.ViewModels
{

    public class CustomerPaymentDetailsVM
    {
        public CustomerPaymentDetailsVM()
        {


        }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "First name should be between 2 - 20 letters.")]
        [RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "First name must contain only letters.")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Last name should be between 2 - 20 letters.")]
        [RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "Last name must contain only letters")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Address should be between 2 - 20 letters.")]

 

        public string address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "City must contain only letters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "City name should be between 2 - 20 letters.")]
        public string city { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [RegularExpression(@"^[A-Za-z\s]*$", ErrorMessage = "Country must contain only letters")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Country should be between 4  - 30 letters.")]
        public string country { get; set; }


        [Required(ErrorMessage = "Zip/Postal Code is required")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Zip Code must be exactly 5 digits.")]
        public string zip_code { get; set; }

        [Required(ErrorMessage = "   Phone Number is required")]
        [RegularExpression(@"^05\d{8}$", ErrorMessage = "Phone Number must start with '05' and consist of another 8 digits.")]
        public string phone_number { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email_address { get; set; }

        public bool saveDetails {  get; set; }



        [Required(ErrorMessage = "Credit Card Type is required")]
        public int CreditCardType { get; set; }

        [Required(ErrorMessage = "Credit Card Number is required")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Invalid Credit Card Number")]
        public string car_number { get; set; }

        [Required(ErrorMessage = "CVV is required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Invalid CVV, should contain exactly 3 digits")]
        public string car_code { get; set; }

        [Required(ErrorMessage = "Expiration Month is required")]
        
        public int ExpirationMonth { get; set; } 

        [Required(ErrorMessage = "Expiration Year is required")]
        
        public int ExpirationYear { get; set; } 
    }

    
   
}
