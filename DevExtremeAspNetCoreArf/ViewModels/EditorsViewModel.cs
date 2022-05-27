using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DevExtremeAspNetCoreArf.ViewModels
{
    public class EditorsViewModel
    {
        public bool ClassifiedOrControlled { get; set; }
        public string PartsNumber { get; set; }
        public bool ITAR { get; set; }
        public bool ArePartsTest { get; set; }
        public bool UsedInManufacturing { get; set; }

        [Required(ErrorMessage = "Contact Name is required")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Contact Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Company Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string CompanyName { get; set; }
        
        public string PhoneNumber { get; set; }
        [RegularExpression(@"^[02-9]\d{9}$", ErrorMessage = "The phone must have a correct phone format")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\d\w._-]+@[\d\w._-]+\.[\w]+$", ErrorMessage = "Email is invalid")]
        [Remote("CheckEmailAddress", "RemoteValidation", ErrorMessage = "Email is already registered", HttpMethod = "POST")]
        public string Email { get; set; }        

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public string Description { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Street must have at least 2 symbols")]
        public string Street { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "House Number must have at least 1 symbols")]
        public string HouseNumber { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "Do not use letters in the Postal Code.")]
        [StringLength(int.MaxValue, MinimumLength = 4, ErrorMessage = "Postal Code must have at least 4 symbols")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "City is required")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Do not use digits in the City name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "City must have at least 2 symbols")]
        public string City { get; set; }




        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "'Password' and 'Confirm Password' do not match.")]
        public string ConfirmPassword { get; set; }        

        public string Extension { get; set; }

        

        public int Age { get; set; }

        public string Drink { get; set; }

        

        public IEnumerable<string> Colors { get; set; }

        public IEnumerable<string> SelectedColors { get; set; }

        public string Color { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Date of birth is required")]
        [VerifyAge(21, ErrorMessage = "You must be at least {1} years old")]
        public DateTime? Date { get; set; }

        [DevExtremeRequired(ErrorMessage = "You must agree to the Terms and Conditions")]
        public bool Accepted { get; set; }

    }
}