namespace DevExtremeAspNetCoreArf.Models
{
    public class AppsLab
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? ShipCountry { get; set; }
        public string? ShipCity { get; set; }
    }
}