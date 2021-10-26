using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_04.Models

{
    public class City
    {
    [Key]
    public int CityId { get; set; }

		[Required]
    [MaxLength(100), MinLength(1)]
    [Display (Name ="City Name")]
    public string CityName { get; set; }

     [Range(1, 99999999)]
    public int Population {get; set;}

    [Display (Name ="Province Code")]
    public string ProvinceCode {get; set;}

  [ForeignKey("ProvinceCode")]
  public Province Province {get; set;}

    }
}

