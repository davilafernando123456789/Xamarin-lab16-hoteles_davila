using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio16.Models
{
    public class Place
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public Location Location { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Location
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
    public class PlacesResponse
    {
        public Place[] Places { get; set; }
    }


}
