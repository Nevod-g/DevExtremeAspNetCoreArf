using System.ComponentModel.DataAnnotations;

namespace DevExtremeAspNetCoreArf.Models
{
    public class Arf
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Language is required")]
        public int Language { get; set; } = 0;

        [Required(ErrorMessage = "Apps Lab is required")]
        [Range(1, 100, ErrorMessage = "Apps Lab is required")]
        public int AppsLab { get; set; }

        [Display(Name = "Classified/Controlled")]
        //[Compare(true, ErrorMessage = "sss111")]
        //[Remote("VerifyCheckBox", "Validation", ErrorMessage = "Determine the value of 'Classified/Controlled'", HttpMethod = "POST")]
        //[Required (ErrorMessage = "Determine the value of 'Classified/Controlled'")]
        [Range(0, 1, ErrorMessage = "Determine the value of 'Classified/Controlled'")]
        public bool? ClassifiedOrControlled { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'ITAR'")]
        public bool? ITAR { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Are the parts test samples/coupons'")]
        public bool? ArePartsTest { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Is this a part for use in manufacturing'")]
        public bool? UsedInManufacturing { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'New Customer'")]
        public bool? IsNewCustomer { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Print Attached'")]
        public bool? PrintAttached { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'MSDS/SDS Attached'")]
        public bool? MsdsSdsAttached { get; set; }

        public bool NoExistingProcess { get; set; } = false;

        [Range(0, 1, ErrorMessage = "Determine the value of 'Fixturing Provided'")]
        public bool? FixturingProvided { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Return completed Samples'")]
        public bool? NeedReturnCompletedSamples { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Return all submitted Parts'")]
        public bool? NeedReturnSubmittedParts { get; set; }

        [Range(0, 1, ErrorMessage = "Determine the value of 'Scrap  unused Sample'")]
        public bool? SampleScrapUnused { get; set; }



        public string? PartsNumber { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Contact Name is required")]
        [RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Contact Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        //[RegularExpression(@"^[^0-9]+$", ErrorMessage = "Do not use digits in the Company Name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Name must have at least 2 symbols")]
        public string? CompanyName { get; set; }

        public string? PhoneNumber { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "The phone must have a correct phone format")]
        public string? MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\d\w._-]+@[\d\w._-]+\.[\w]+$", ErrorMessage = "Email is invalid")]
        //[Remote("CheckEmailAddress", "Validation", ErrorMessage = "Email is already registered", HttpMethod = "POST")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }

        public string? Description { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "Street must have at least 2 symbols")]
        public string? Street { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 1, ErrorMessage = "House Number must have at least 1 symbols")]
        public string? HouseNumber { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "Do not use letters in the Postal Code.")]
        [StringLength(int.MaxValue, MinimumLength = 4, ErrorMessage = "Postal Code must have at least 4 symbols")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "City is required")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Do not use digits in the City name.")]
        [StringLength(int.MaxValue, MinimumLength = 2, ErrorMessage = "City must have at least 2 symbols")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Opportunity is required")]
        public string? Opportunity { get; set; }

        [Required(ErrorMessage = "Process Type is required")]
        public string? ProcessType { get; set; }
        public string? OtherProcessType { get; set; }

        [Display(Name = "Description")]
        public string? ApplicationDescription { get; set; }
        public string? InternalNotes { get; set; }
        public string? Material1 { get; set; }
        public string? Material1Description { get; set; }
        public string? Material2 { get; set; }
        public string? Material2Description { get; set; }
        public string? MaterialComments { get; set; }
        public string? ShippingCompany { get; set; }
        public string? AccountNumber { get; set; }

        [Display(Name = "Process")]
        public string? CurrentProcess { get; set; }
        [Display(Name = "Throughput")]
        public string? CurrentThroughput { get; set; }

        [Display(Name = "Reason for considering fiber laser vs existing process:")]
        [Required(ErrorMessage = "Description Reason for considering is required")]
        public string? DescriptionReasonConsidering { get; set; }
        public string? Laser { get; set; }
        public string? Wavelength { get; set; }
        public string? ProcessGas { get; set; }
        public string? OtherConditions { get; set; }
        public string? Quality { get; set; }
        public string? Throughput { get; set; }

        [Display(Name = "Other concerns (specify)")]
        public string? OtherConcerns { get; set; }
    }
}
