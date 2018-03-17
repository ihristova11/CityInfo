using System.Collections.Generic;

namespace CityInfo.API.Models
{
    public class CityDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get { return this.PointsOfInterest.Count; }
        }

        public ICollection<PointOfInterestDTO> PointsOfInterest { get; set; } = new List<PointOfInterestDTO>();

    }
}
