using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio16.ViewModels
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Laboratorio16.Models;
    using Newtonsoft.Json;

    public class ApiManager
    {
        private const string ApiUrl = "https://api-airbnb-blue.vercel.app/airbnb";

        public async Task<Place[]> GetPlacesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(ApiUrl);
                var placesResponse = JsonConvert.DeserializeObject<PlacesResponse>(response);
                return placesResponse.Places;
            }
        }

    }

}
