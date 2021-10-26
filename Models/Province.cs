using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab_04.Models
{
    public class Province
    {
    [Key]
   	[Required]
    [MaxLength(2), MinLength(2)]
    [RegularExpression("^([A-Z]{2})$", ErrorMessage = "Province Code Must be 2 capital characters")]
    [Display (Name = "2-Letter Abbreviation")]
    public string ProvinceCode { get; set; }

	[Required]
    [MaxLength(100), MinLength(1)]
    [RegularExpression("^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "Province Name must only be alphabetic characters")]
   
    [Display (Name ="Province Name")]
    public string ProvinceName { get; set; }

    public List<City> Cities {get; set;}

    }
}

