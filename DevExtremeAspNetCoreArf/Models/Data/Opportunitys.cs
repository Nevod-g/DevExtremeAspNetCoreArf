using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtremeAspNetCoreArf.Models.Data
{
	public partial class DataSource
    {
        public static readonly IEnumerable<string> Opportunitys = new[] {
            "Laser",
            "IM/Beam Delivery",
            "Turnkey solution",
            "Other"
        };
    }
}
