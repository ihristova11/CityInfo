using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public CitiesDataStore()
        {
            // init dummy data

            this.Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "Lovech",
                    Description = "My town"
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Sofia",
                    Description = "some city here"
                },
                new CityDTO()
                {
                    Id = 3,
                    Name = "Varna",
                    Description = "Varna city Varna"
                }
            };
        }

        public IList<CityDTO> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
    }
}
