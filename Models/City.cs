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
    [Display (Name ="City Name")]
    public string CityName { get; set; }
    public int Population {get; set;}

    [Display (Name ="Province Code")]
    public string ProvinceCode {get; set;}

  [ForeignKey("ProvinceCode")]
  public Province Province {get; set;}

    }
}

