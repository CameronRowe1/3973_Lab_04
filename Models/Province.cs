using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab_04.Models
{
    public class Province
    {
    [Key]
    [Display (Name = "2-Letter Abbreviation")]
    public string ProvinceCode { get; set; }

	[Required]
    [Display (Name ="Province Name")]
    public string ProvinceName { get; set; }

    public List<City> Cities {get; set;}

    }
}

