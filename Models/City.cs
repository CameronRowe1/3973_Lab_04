using System;
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
    [RegularExpression("^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "City Name must only be alphabetic characters")]
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

