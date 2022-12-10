using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBlazorDemoApp.Shared;

public class SupplierValidationAttribute : ValidationAttribute
{
    public string ValidSupplierValue { get; set; }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var lowerValue = value.ToString().ToLower();
        if (lowerValue.Equals(ValidSupplierValue.ToLower()))
            return null;

        return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
    }

 

}
