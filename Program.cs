using SWAPI_TestCs.Models;
using System;

namespace SWAPI_TestCs
{
    class Program
    {
        static void Main(string[] args)
        {
            APIHelper.InitApiClient();
            printPeople();
            Console.ReadLine();
        }

        private static async void printPeople(int id = 1)
        {
            InfoProcessor infoProcessor = new InfoProcessor();
            var infos = await infoProcessor.LoadInfo(id);
            Console.WriteLine(infos.Name);
        }
    }
}
