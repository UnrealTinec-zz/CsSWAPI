using SWAPI_TestCs.src.Models;
using SWAPI_TestCs.src.SWAPI;
using System;
using System.Text;

namespace SWAPI_TestCs
{
    class Program
    {
        static void Main(string[] args)
        {
            APIHelper.InitApiClient();
            Input:
            Console.WriteLine("Category: - People\n" +
                              "          - Planets\n" +
                              "          - Vehicles");
            Console.WriteLine("Choose Category: ");
            string Catergory = Console.ReadLine();
            Console.WriteLine("ID: ");
            string IDinput = Console.ReadLine();
            int ID;

            if(!int.TryParse(IDinput, out ID)){
                goto Input;
            }

            if (Catergory.ToLower().Equals("people"))
            {
                PrintPeople(ID);
            }
            else if (Catergory.ToLower().Equals("planets"))
            {
                throw new NotImplementedException();
            }
            else if (Catergory.ToLower().Equals("vehicles"))
            {
                PrintVehicles(ID);
            }
            Console.ReadLine();
        } 

        private static async void PrintPeople(int id = 1, bool appendCE = false)
        {
            StringBuilder msg;
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<PeopleModel>(id);
            msg = new StringBuilder(
                $"-------------Character------------\n" 
                + $"Name: {infos.Name}\n" 
                + $"Height: {infos.Height}\n" 
                + $"Mass: {infos.Mass}\n" 
                + $"Hair color: {infos.Hair_color}\n" 
                + $"Skin color: {infos.Skin_color}\n" 
                + $"Eye color: {infos.Eye_color}\n" 
                + $"Birth year: {infos.Birth_year}\n" 
                + $"Gender: {infos.Gender}\n");

            if (appendCE)
            {
                msg.Append($"Created: {infos.ConvertToLocalTime()[0]}\n" +
                $"Edited: {infos.ConvertToLocalTime()[1]}\n");
            }
            msg.Append($"---------------------------------\n");
            Console.WriteLine(msg);

        }
        private static async void PrintVehicles(int id = 4, bool appendCE = false)
        {
            StringBuilder msg;
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<VehiclesModel>(id);
            msg = new StringBuilder($"-------------Vehicle------------\n" +
                $"Name: {infos.Name}\n" +
                $"Model: {infos.Model}\n" +
                $"Manufacturer: {infos.Manufacturer}\n" +
                $"Cost in credits: {infos.Cost_in_credits}\n" +
                $"Lenght: {infos.Length}\n" +
                $"Max atmosphering speed: {infos.Max_atmosphering_speed}\n" +
                $"Crew: {infos.Crew}\n" +
                $"Passengers: {infos.Passengers}\n" +
                $"Cargo capacity: {infos.Cargo_capacity}\n" +
                $"Consumables: {infos.Consumables}\n" +
                $"Vehicle class: {infos.Vehicle_class}\n"
                );

            if (appendCE)
            {
                msg.Append($"Created: {infos.ConvertToLocalTime()[0]}\n" +
                $"Edited: {infos.ConvertToLocalTime()[1]}\n");
            }
            msg.Append($"--------------------------------\n");
            Console.WriteLine(msg);
        }

        /*
        private static async void PrintInfos<T>(int id, bool appendCE) where T: Model
        {
            StringBuilder msg;
            InfoProcessor infoProcessor = new InfoProcessor();
            Type m = typeof(T);
            var infos = await infoProcessor.LoadInfo<m>(id);

        }
        */
    }
}
