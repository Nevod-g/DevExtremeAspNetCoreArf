namespace DevExtremeAspNetCoreArf.Models.Data
{
    public partial class DataSource
    {
        public static readonly IEnumerable<string> ProcessGases = new[] {
            "No",
            "Argon",
            "N2",
            "Welding Mix 90/10",
            "O2",
            "CDA",
            "He",
            "Mixture"
        };
    }
}
