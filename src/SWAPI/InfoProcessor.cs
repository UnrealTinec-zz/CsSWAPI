using SWAPI_TestCs.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SWAPI_TestCs
{
    public class InfoProcessor
    {
        public async Task<PeopleModel> LoadInfo(int ID = 1)
        {
            string url = $"{APIHelper.URI}{ID}/";

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {
                    PeopleModel people = await res.Content.ReadAsAsync<PeopleModel>();
                    return people;
                }
                else
                {
                    throw new Exception("Character not found"); 
                }
            }
        }
    }
}
