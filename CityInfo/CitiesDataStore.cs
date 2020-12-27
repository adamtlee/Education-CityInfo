using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Denver",
                    Description = "The home town",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empower Field",
                            Description = "Formerly named as Invesco Field"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Union Station",
                            Description = "Cool Place for travelrs"
                        }
                    }
                },
                 new CityDto()
                {
                    Id = 2,
                    Name = "Arvada",
                    Description = "The second home town",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Lookout Mountain",
                            Description = "Cool place to watch the sun set"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Olde Town",
                            Description = "Downtown for Arvada"
                        }
                    }
                },

                  new CityDto()
                {
                    Id = 3,
                    Name = "Boulder",
                    Description = "The third home town",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Chautauqua Park",
                            Description = "Cool park with scenery"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Flatirons",
                            Description = "Nice and cool place"
                        }
                    }
                },
            };
        }
    }
}
