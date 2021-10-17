using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab_04.Models
{

public class SampleData {
  public static List<Province> GetProvinces() {
      List<Province> provinces = new List<Province>() {
         new Province() {
             ProvinceCode="BC",
             ProvinceName="British Columbia"
         },
         new Province() {
             ProvinceCode="AB",
             ProvinceName="Alberta"
         },
        new Province() {
             ProvinceCode="QE",
             ProvinceName="Quebec"
         },
        new Province() {
             ProvinceCode="ON",
             ProvinceName="Ontario"
         },
      };
      return provinces;
  }
public static List<City> GetCities() {
      List<City> cities = new List<City>() {
         new City() {
             CityId=1,
            CityName="Vancouver",
            Population=3000000,
            ProvinceCode="BC"
         },
         new City() {
             CityId=2,
            CityName="Victoria",
            Population=1000000,
            ProvinceCode="BC"
         },
         new City() {
             CityId=3,
            CityName="Burnaby",
            Population=1000000,
            ProvinceCode="BC"
         },
         new City() {
             CityId=4,
            CityName="Toronto",
            Population=5000000,
            ProvinceCode="ON"
         }
      };
      return cities;
  }
}
}