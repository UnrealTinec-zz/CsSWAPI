using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI_TestCs.src.Models
{
    //Represents the Vehicles fromt the SWAPI listed under https://swapi.dev/api/vehicles/

    class VehiclesModel : Model
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Cost_in_credits { get; set; }
        public string Length { get; set; }
        public string Max_atmosphering_speed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }
        public string Vehicle_class { get; set; }
        public List<string> Pilots { get; set; } //List with links
        public List<string> Films { get; set; } //List with links
    }
}
