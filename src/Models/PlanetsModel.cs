using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI_TestCs.src.Models
{
    class PlanetsModel : Model
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrian { get; set; }
        public string surface_water { get; set; }
        public string Population { get; set; }
        public List<string> Residents { get; set; } //List with links
        public List<string> Films { get; set; } //List with links

    }
}
