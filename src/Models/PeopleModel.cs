using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI_TestCs.Models
{
    //Represents the People fromt the SWAPI listed under https://swapi.dev/api/people/
    public class PeopleModel
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Sking_color { get; set; }
        public string Eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public string[] Films { get; set; }

    }
}
