using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DevExtremeAspNetCoreArf.ViewModels
{
    public class VerifyCheckBoxAttribute : ValidationAttribute, IClientModelValidator
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            System.Diagnostics.Debug.WriteLine("VerifyCheckBoxAttribute.IsValid");
            if (value != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessageString);
        }

		void IClientModelValidator.AddValidation(ClientModelValidationContext context)
		{
            System.Diagnostics.Debug.WriteLine("VerifyCheckBoxAttribute.AddValidation");
            context.Attributes.Add("data-val-custom-verifycheckbox", ErrorMessageString);
			context.Attributes.Add(
				"data-val-custom-verifycheckbox-validationcallback",
				$@"function(options) {{
                    return options.value && options.value != null;
                }}");
		}
	}
}