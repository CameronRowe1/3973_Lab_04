using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab_04.Models
{
    public class Province
    {
    [Key]
    [MaxLength(2), MinLength(2)]
    [Display (Name = "2-Letter Abbreviation")]
    public string ProvinceCode { get; set; }

	[Required]
    [MaxLength(100), MinLength(1)]
    [Display (Name ="Province Name")]
    public string ProvinceName { get; set; }

    public List<City> Cities {get; set;}

    }
}

