using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SWAPI_TestCs.src.SWAPI
{
    public static class APIHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static string URI_People = "https://swapi.dev/api/people/";
        public static string URI_Vehicles = "https://swapi.dev/api/vehicles/";


        public static void InitApiClient()
        {
            ApiClient = new HttpClient
            {
                BaseAddress = new Uri("https://swapi.dev/api/")
            };
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
