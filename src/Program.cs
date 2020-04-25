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
            //--Tests--
            PrintPeople(1,false);
            PrintVehicles(24,true);
            //---------
            Console.ReadLine();
        } //20.12.2014 22:30:21

        private static async void PrintPeople(int id, bool appendCE)
        {
            StringBuilder msg;
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<PeopleModel>(id);
            msg = new StringBuilder($"-------------Character------------\n" +
                $"Name: {infos.Name}\n" +
                $"Height: {infos.Height}\n" +
                $"Mass: {infos.Mass}\n" +
                $"Hair color: {infos.Hair_color}\n" +
                $"Skin color: {infos.Skin_color}\n" +
                $"Eye color: {infos.Eye_color}\n" +
                $"Birth year: {infos.Birth_year}\n" +
                $"Gender: {infos.Gender}\n");

            if (appendCE)
            {
                msg.Append($"Created: {infos.ConvertToLocalTime()[0]}\n" +
                $"Edited: {infos.ConvertToLocalTime()[1]}\n");
            }
            msg.Append($"---------------------------------\n");
            Console.WriteLine(msg);

        }
        private static async void PrintVehicles(int id, bool appendCE)
        {
            StringBuilder msg;
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<VehiclesModel>(id);
            msg = new StringBuilder($"-------------Vehicle------------\n" +
                $"Name: {infos.Name}\n" +
                $"Model: {infos.Model}\n" +
                $"Manufacturer: {infos.Manufacturer}\n" +
                $"Cost in credits: {infos.Cost_in_credits}\n" +
                $"Lenght: {infos.Lenght}\n" +
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
    }
}
