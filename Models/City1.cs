using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_04.Models
{
    public class City1
    {
        public int cityId;
        public string cityName;
        public int population;
        public string provinceCode;
        public string province;

        public City1(int cityId, string cityName, int population, string provinceCode, string province)
        {
            this.cityId = cityId;
            this.cityName = cityName;
            this.population = population;
            this.provinceCode = provinceCode;
            this.province = province;
        }
    }
}
