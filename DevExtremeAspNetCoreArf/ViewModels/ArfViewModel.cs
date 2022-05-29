using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DevExtremeAspNetCoreArf.ViewModels
{
    public class ArfViewModel
    {
        [Display(Name = "Classified/Controlled")]
        //[VerifyCheckBox(ErrorMessage = "Determine the value of 'Classified/Controlled'")]
        //[Compare("IsNull", ErrorMessage = "sss111")]
        //[Remote("VerifyCheckBox", "RemoteValidation", ErrorMessage = "Determine the value of 'Classified/Controlled'", HttpMethod = "POST")]
        public bool? ClassifiedOrControlled { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'ITAR'")]
        public bool? ITAR { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Are the parts test samples/coupons'")]
        public bool? ArePartsTest { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Is this a part for use in manufacturing'")]
        public bool? UsedInManufacturing { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'New Customer'")]
        public bool? IsNewCustomer { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Print Attached'")]
        public bool? PrintAttached { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'MSDS/SDS Attached'")]
        public bool? MsdsSdsAttached { get; set; }

        public bool NoExistingProcess { get; set; } = true;

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Fixturing Provided'")]
        public bool? FixturingProvided { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Return completed Samples'")]
        public bool? NeedReturnCompletedSamples { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Return all submitted Parts'")]
        public bool? NeedReturnSubmittedParts { get; set; }

        [DevExtremeRequired(ErrorMessage = "Determine the value of 'Scrap  unused Sample'")]
        public bool? SampleScrapUnused { get; set; }



        public string PartsNumber { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Contact Name is required")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Contact Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string ContactName { get; set; } = "dsdfasdf";
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
        public string City { get; set; } = "Test City";

        public string Opportunity { get; set; }

        [Required(ErrorMessage = "Process Type is required")]
        public string ProcessType { get; set; }
        public string OtherProcessType { get; set; }

        [Display(Name = "Description")]
        public string ApplicationDescription { get; set; }
        public string InternalNotes { get; set; }
        public string Material1 { get; set; }
        public string Material1Description { get; set; }
        public string Material2 { get; set; }
        public string Material2Description { get; set; }
        public string MaterialComments { get; set; }
        public string ShippingCompany { get; set; }
        public string AccountNumber { get; set; }

        [Display(Name = "Process")]
        public string CurrentProcess { get; set; }
        [Display(Name = "Throughput")]
        public string CurrentThroughput { get; set; }

        [Display(Name = "Reason for considering fiber laser vs existing process:")]
        [Required(ErrorMessage = "Description Reason for considering is required")]
        public string DescriptionReasonConsidering { get; set; }
        public string Laser { get; set; }
        public string Wavelength { get; set; }
        public string ProcessGas { get; set; }        
        public string OtherConditions { get; set; }
        public string Quality { get; set; }
        public string Throughput { get; set; }

        [Display(Name = "Other concerns (specify)")]
        public string OtherConcerns { get; set; }
    }
}
