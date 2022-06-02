using DevExtremeAspNetCoreArf.Models;

namespace DevExtremeAspNetCoreArf.Services
{
    public interface IArfRepository
    {
        IEnumerable<Arf> GetAll();
        Arf Get(int id);
        Arf Update(Arf arf);
    }
}
