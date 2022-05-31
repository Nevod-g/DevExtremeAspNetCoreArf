using DevExtremeAspNetCoreArf.Models;

namespace DevExtremeAspNetCoreArf.Services
{
    public interface IArfRepository
    {
        IEnumerable<Arf> GetAllArf();
    }
}
