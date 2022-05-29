using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtremeAspNetCoreArf.Models.Data
{
	public partial class DataSource
    {
        public static readonly IEnumerable<string> Lasers = new[] {
            "CW laser ",
            "QCW",
            "Q-switch  laser",
            "Femto/Pico",            
            "Don’t know"
        };
    }
}
