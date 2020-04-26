using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWAPI_TestCs.src.SWAPI
{
    public class InfoProcessor
    {
 
        private string URL_Used;
        public async Task<T> LoadInfo<T>(int ID) where T: class, new()
        {

            Type type = typeof(T);

            if (type == typeof(Models.PeopleModel))
            {
                URL_Used = $"{APIHelper.URI_People}{ID}/";
            }
            else if(type == typeof(Models.VehiclesModel))
            {
                URL_Used = $"{APIHelper.URI_Vehicles}{ID}/";
            }
            else if(type == typeof(Models.PlanetsModel))
            {
                URL_Used = $"{APIHelper.URI_Planets}{ID}/";
            }

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(URL_Used))
            {
                if (res.IsSuccessStatusCode)
                {
                    T list = await res.Content.ReadAsAsync<T>();
                    return list;
                }
                else
                {
                    throw new Exception("ID not found"); 
                }
            }
        }
    }
}
