using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBlazorDemoApp.Shared;

public class Product
{
    [Required]
    public string Name { get; set; }
    [Required]
    [SupplierValidation(ErrorMessage = "VT Wrong value entered", ValidSupplierValue = "Code-Maze")]
    public string Supplier { get; set; }
}