using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI_TestCs.src.Models
{
    public abstract class Model
    {
        public DateTime Created { get; set; } //Creation of the Doc
        public DateTime Edited { get; set; } //Edit of the Doc

        public List<DateTime> ConvertToLocalTime()
        {
            return new List<DateTime> { Created.ToLocalTime(), Edited.ToLocalTime() };
        }
    }
}
