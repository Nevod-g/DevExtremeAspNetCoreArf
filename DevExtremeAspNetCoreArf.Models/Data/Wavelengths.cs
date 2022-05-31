namespace DevExtremeAspNetCoreArf.Models.Data
{
    public partial class DataSource
    {
        public static readonly IEnumerable<string> Wavelengths = new[] {
            "1060-1070nm IR",
            "1940 Thulium",
            "355-nm UV",
            "532-nm",
            "Don’t know"
        };
    }
}
