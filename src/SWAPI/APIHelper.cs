using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SWAPI_TestCs.src.SWAPI
{
    public static class APIHelper
    {
        public static HttpClient ApiClient { get; set; }

        internal static string URI_People = "https://swapi.dev/api/people/";
        internal static string URI_Planets = "http://swapi.dev/api/planets/";
        internal static string URI_Films = "http://swapi.dev/api/films/";
        internal static string URI_Species = "http://swapi.dev/api/species/";
        internal static string URI_Vehicles = "https://swapi.dev/api/vehicles/";
        internal static string URI_Starships = "http://swapi.dev/api/starships/";



        public static void InitApiClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
