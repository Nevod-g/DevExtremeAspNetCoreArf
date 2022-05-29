using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtremeAspNetCoreArf.Models.Data
{
	public partial class DataSource
    {
        public static readonly IEnumerable<string> ProcessTypes = new[] {
            "Welding",
            "Cutting",
            "Marking",
            "Engraving",
            "Cleaning",
            "Ablation",
            "Drilling",
            "Cladding",
            "Heat Treating",
            "LightWELD",
            "Texturing",
            "Material Modification",
            "Brazing",
            "Other (please explain)"
        };
    }
}
