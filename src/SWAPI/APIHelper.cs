using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SWAPI_TestCs
{
    public static class APIHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static string URI = "https://swapi.dev/api/people/";

        public static void InitApiClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://swapi.dev/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
