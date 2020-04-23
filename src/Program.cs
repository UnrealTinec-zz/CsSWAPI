using SWAPI_TestCs.src.Models;
using SWAPI_TestCs.src.SWAPI;
using System;

namespace SWAPI_TestCs
{
    class Program
    {
        static void Main(string[] args)
        {
            APIHelper.InitApiClient();
            //--Tests--
            PrintPeople();
            PrintVehicles();
            //---------
            Console.ReadLine();
        }

        private static async void PrintPeople(int id = 1)
        {
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<PeopleModel>(id);
            Console.WriteLine(
                $"-------------Character------------\n"+
                $"Name: {infos.Name}\n" +
                $"Height: {infos.Height}\n" +
                $"Mass: {infos.Mass}\n" +
                $"Hair color: {infos.Hair_color}\n" +
                $"Skin color: {infos.Skin_color}\n" +
                $"Eye color: {infos.Eye_color}\n" +
                $"Birth year: {infos.Birth_year}\n" +
                $"Gender: {infos.Gender}\n" +
                $"---------------------------------\n");

        }
        private static async void PrintVehicles(int id = 4)
        {
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo<VehiclesModel>(id);
            Console.WriteLine(
                $"-------------Vehicle------------\n" +
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
                $"Vehicle class: {infos.Vehicle_class}\n" +
                $"Created: {infos.ConvertToLocalTime()[0]}\n" +
                $"Edited: {infos.ConvertToLocalTime()[1]}\n" +
                $"--------------------------------\n"
                );
        }
    }
}
